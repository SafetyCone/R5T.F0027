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
            var process = Instances.CommandLineOperator.Start(
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
            var process = Instances.CommandLineOperator.Start(
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
            Instances.CommandLineOperator.Run_Synchronous(
                Instances.ExecutableNames.Dotnet,
                dotnetArguments);
        }

        public int Run_InterceptErrorInOutput_ThrowIfError_Synchronous(string dotnetArguments)
        {
            var currentDirectory = Instances.EnvironmentOperator.Get_CurrentDirectoryPath();

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
                Instances.CommandLineOperator.Default_OutputReceivedHandler(sender, eventArgs);

                var isError = Instances.StringOperator.Is_NotNullOrEmpty(eventArgs.Data)
                    && Instances.StringOperator.Contains(eventArgs.Data, ": error");

                if(isError)
                {
                    var exception = Instances.ExceptionOperator.Get_ErrorDataReceivedException(eventArgs);

                    exceptions.Add(exception);
                }
            }

            var exitCode = Instances.CommandLineOperator.Run_Synchronous(
                Instances.ExecutableNames.Dotnet,
                dotnetArguments,
                OutputReceivedHandler,
                Instances.CommandLineOperator.GetErrorReceivedEventHandler(exceptions));

            var isFailure = Instances.ExitCodeOperator.IsFailure(exitCode);
            if(isFailure && exceptions.Any())
            {
                throw new AggregateException($"The command had error output. Exit code: {exitCode}", exceptions);
            }

            return exitCode;
        }
    }
}