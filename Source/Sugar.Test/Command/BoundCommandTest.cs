﻿using NUnit.Framework;

namespace Sugar.Command
{
    [TestFixture]
    public class BoundCommandTest
    {
        private class FakeCommand : BoundCommand<FakeCommand.Options>
        {
            public class Options
            {
                [Parameter("one", Required = true)]
                public string Input { get; set; }
            }

            public Options GetOptions()
            {
                return OptionsBound;
            }

            public override int Execute(Options options)
            {
                return 0;
            }           
        }

        [Test]
        public void TestSuccess()
        {
            var result = FakeCommand.Success();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestFail()
        {
            var result = FakeCommand.Fail();

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void TestCommandExecutes()
        {
            var parameters = new ParameterParser().Parse("-one two");

            var command = new FakeCommand();

            command.BindParameters(parameters);

            Assert.NotNull(command.GetOptions());
        }

        [Test]
        public void TestCommandDoesNotExecutesWhenRequiredParameterIsMissing()
        {
            var parameters = new ParameterParser().Parse("-three two");

            var command = new FakeCommand();
            
            Assert.Throws<RequiredParameterMissingException>(() => command.BindParameters(parameters));
        }
    }
}
