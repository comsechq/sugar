﻿using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Sugar.Http
{
    public class RetryDelegatingHandlerTest
    {
        private class FakeHandler : HttpMessageHandler
        {
            public int FailedCount = 0;
            public int AuthorizationAttempts = 0;
            public int OkCount = 0;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (AuthorizationAttempts == 0)
                {
                    if (request.RequestUri.PathAndQuery.Contains("authorize"))
                    {
                        AuthorizationAttempts++;

                        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
                    }

                    FailedCount++;
                    return Task.FromResult(new HttpResponseMessage(HttpStatusCode.Unauthorized));
                }

                OkCount++;

                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            }
        }

        [Fact]
        public async Task TestHttpClientWithoutIntercept()
        {
            var innerHandler = new FakeHandler();

            var retryHandler = new RetryDelegatingHandler
            {
                InnerHandler = innerHandler
            };

            var client = new HttpClient(retryHandler);

            var response = await client.GetAsync("http://hello.world/test");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);

            Assert.Equal(1, innerHandler.FailedCount);
            Assert.Equal(0, innerHandler.AuthorizationAttempts);
            Assert.Equal(0, innerHandler.OkCount);
        }

        [Fact]
        public async Task TestHttpClientWithRetryIntercept()
        {
            // The fake handler lets us track the number of 'actual' requests
            var innerHandler = new FakeHandler();

            var retryHandler = new RetryDelegatingHandler
            {
                InnerHandler = innerHandler,
                RetryIntercept = async delegate (HttpResponseMessage responseMessage)
                {
                    if (responseMessage.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        // Predent we authenticate
                        var retryClient = new HttpClient(innerHandler);

                        var authorizeResponse = await retryClient.GetAsync("http://hello.world/authorize?a=bcd");

                        return authorizeResponse.IsSuccessStatusCode;
                    }

                    return false;
                }
            };

            var client = new HttpClient(retryHandler);

            var response = await client.GetAsync("http://hello.world/test");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            Assert.Equal(1, innerHandler.FailedCount);
            Assert.Equal(1, innerHandler.AuthorizationAttempts);
            Assert.Equal(1, innerHandler.OkCount);
        }
    }
}
