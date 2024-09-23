using System;

using R5T.T0132;


namespace R5T.F0027
{
	[FunctionalityMarker]
	public partial interface IDotnetPublishOperator : IFunctionalityMarker
	{
		public void Run(string publishArguments)
		{
			var dotnetArguments = $"{Instances.DotnetCommandNames.Publish} {publishArguments}";

			Instances.DotnetOperator.Run(dotnetArguments);
		}

		//public void Publish(string projectFilePath)
		//{
		//	// Value is from R5T.Z0011 FYI.
		//	var folderPublishProfileFilePath = Instances.ExecutableFileRelativeFilePaths.FolderPublishProfileFilePath;

		//	var publicProfileArgument = $"-p:PublishProfileFullPath=\"{folderPublishProfileFilePath}\"";

		//	var publishArguments = $"\"{projectFilePath}\" {publicProfileArgument}";

		//	this.Run(publishArguments);
		//}

        public void Publish(
            string projectFilePath,
            string outputDirectoryPath)
        {
            // Always the release configuration.
            var configurationArgument = "-c Release";

            var outputDirectoryArgument = $"-o \"{outputDirectoryPath}\"";

            var publishArguments = $"\"{projectFilePath}\" {configurationArgument} {outputDirectoryArgument}";

            this.Run(publishArguments);
        }

        /// <summary>
        /// Runs the publish command with the WasmEnableWebcil=false property.
		/// This is useful in survey-specific builds of Blazor WebAssembly projects, because it generates DLL files that can be examined.
        /// </summary>
        public void Publish_WithWasmEnableWebcilPropertyForBlazorWebassembly(
            string projectFilePath,
            string outputDirectoryPath)
        {
            // Always the release configuration.
            var configurationArgument = "-c Release";

            var outputDirectoryArgument = $"-o \"{outputDirectoryPath}\"";

			var wasmEnableWebcil_Argument = "-p:WasmEnableWebcil=false";

			// For some reason, the output directory path argument has to be last.
            var publishArguments = $"\"{projectFilePath}\" {configurationArgument} {wasmEnableWebcil_Argument} {outputDirectoryArgument}";

            this.Run(publishArguments);
        }

        public void Publish_WithRuntimeArgument(
			string projectFilePath,
			string outputDirectoryPath)
		{
			// Always the release configuration.
			var configurationArgument = "-c Release";

			var outputDirectoryArgument = $"-o \"{outputDirectoryPath}\"";

			var runtimeArgument = "-r win-x64 --self-contained";

			var publishArguments = $"\"{projectFilePath}\" {configurationArgument} {outputDirectoryArgument} {runtimeArgument}";

			this.Run(publishArguments);
		}
	}
}