﻿using NUnit.Framework;

namespace Comsec.Sugar
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        public void TestHtmlDecode()
        {
            var decoded = "test&amp;&#32;".HtmlDecode();

            Assert.AreEqual("test& ", decoded);
        }

        [Test]
        public void TestHtmlDecodeNullValue()
        {
            var decoded = ((string) null).HtmlDecode();

            Assert.IsNull(decoded);
        }

        [Test]
        public void TestHtmlEncode()
        {
            var decoded = "test& ".HtmlEncode();

            Assert.AreEqual("test&amp; ", decoded);
        }

        [Test]
        public void TestHtmlEncodeNullValue()
        {
            var decoded = ((string)null).HtmlEncode();

            Assert.IsNull(decoded);
        }

        [Test]
        public void TestStartsWithAndIgnoreCase()
        {
            var value = "Bonjour";

            var result = value.StartsWith("BON", true);
            Assert.IsFalse(result);

            result = value.StartsWith("bon", false);
            Assert.IsTrue(result);

            result = value.StartsWith("jour", true);
            Assert.IsFalse(result);
        }
    }
}
