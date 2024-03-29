﻿using System.Threading;
using System.Threading.Tasks;
using Sugar.Command.Binder;

namespace Sugar.Command
{
    /// <summary>
    /// Represent a command bound to parameters (e.g. program.exe -parameter value)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BoundAsyncCommand<T> : IAsyncCommand where T : class, new()
    {
        protected T OptionsBound;

        /// <summary>
        /// Returns the success exit code cast as an int (0).
        /// </summary>
        /// <returns>0</returns>
        public static int Success()
        {
            return (int) ExitCode.Success;
        }

        /// <summary>
        /// Returns the default failure return code (-1).
        /// </summary>
        /// <returns>-1</returns>
        public static int Fail()
        {
            return (int) ExitCode.GeneralError;
        }

        /// <summary>
        /// Executes the specified options.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public abstract Task<int> Execute(T options, CancellationToken cancellationToken = default);

        /// <summary>
        /// Binds the parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        public void BindParameters(Parameters parameters)
        {
            OptionsBound = ParameterBinder.Bind<T>(parameters);
        }

        /// <summary>
        /// Executes this command.
        /// </summary>
        /// <returns></returns>
        public async Task<int> Execute(CancellationToken cancellationToken = default)
        {
            if (OptionsBound == null)
            {
                return (int) ExitCode.NoCommand;
            }

            return await Execute(OptionsBound, cancellationToken);
        }
    }
}
