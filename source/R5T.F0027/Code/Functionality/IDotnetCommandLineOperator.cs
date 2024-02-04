using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using R5T.T0132;


namespace R5T.F0027
{
	[FunctionalityMarker]
	public partial interface IDotnetCommandLineOperator : IFunctionalityMarker
	{
        /// <summary>
        /// Configures and starts a dotnet process.
        /// </summary>s
        public Process Start(
            string dotnetArguments,
            DataReceivedEventHandler receiveOutputData,
            out StreamWriter standardInput)
        {
            var process = F0000.Instances.CommandLineOperator.Start(
                Instances.ExecutableNames.Dotnet,
                dotnetArguments,
                receiveOutputData,
                true);

            standardInput = process.StandardInput;

            return process;
        }

        /// <summary>
        /// Configures and starts a dotnet process.
        /// </summary>s
        public Process Start(
            string dotnetArguments,
            DataReceivedEventHandler receiveOutputData,
            DataReceivedEventHandler receiveErrorData,
            out StreamWriter standardInput)
        {
            var process = F0000.Instances.CommandLineOperator.Start(
                Instances.ExecutableNames.Dotnet,
                dotnetArguments,
                receiveOutputData,
                receiveErrorData,
                true);

            standardInput = process.StandardInput;

            return process;
        }

        public void Run_Synchronous(string dotnetArguments)
        {
            F0000.Instances.CommandLineOperator.Run_Synchronous(
                Instances.ExecutableNames.Dotnet,
                dotnetArguments);
        }

        public int Run_InterceptErrorInOutput_ThrowIfError_Synchronous(string dotnetArguments)
        {
            var currentDirectory = F0000.Instances.EnvironmentOperator.GetCurrentDirectory();

            var output = this.Run_InterceptErrorInOutput_ThrowIfError_Synchronous(
                dotnetArguments,
                currentDirectory);

            return output;
        }

        public int Run_InterceptErrorInOutput_ThrowIfError_Synchronous(
            string dotnetArguments,
            string currentDirectory)
        {
            List<Exception> exceptions = new List<Exception>();

            void OutputReceivedHandler(object sender, DataReceivedEventArgs eventArgs)
            {
                F0000.Instances.CommandLineOperator.Default_OutputReceivedHandler(sender, eventArgs);

                var isError = F0000.StringOperator.Instance.Is_NotNullOrEmpty(eventArgs.Data)
                    && F0000.StringOperator.Instance.Contains(eventArgs.Data, ": error");

                if(isError)
                {
                    var exception = F0000.Instances.ExceptionOperator.Get_ErrorDataReceivedException(eventArgs);

                    exceptions.Add(exception);
                }
            }

            var exitCode = F0000.Instances.CommandLineOperator.Run_Synchronous(
                Instances.ExecutableNames.Dotnet,
                dotnetArguments,
                OutputReceivedHandler,
                F0000.Instances.CommandLineOperator.GetErrorReceivedEventHandler(exceptions));

            var isFailure = F0000.Instances.ExitCodeOperator.IsFailure(exitCode);
            if(isFailure && exceptions.Any())
            {
                throw new AggregateException($"The command had error output. Exit code: {exitCode}", exceptions);
            }

            return exitCode;
        }
    }
}