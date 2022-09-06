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

		public void Publish(string projectFilePath)
		{
			var folderPublishProfileFilePath = Z0011.Instances.ExecutableFileRelativeFilePaths.FolderPublishProfileFilePath;

			var publicProfileArgument = $"-p:PublishProfileFullPath=\"{folderPublishProfileFilePath}\"";

			var publishArguments = $"\"{projectFilePath}\" {publicProfileArgument}";

			this.Run(publishArguments);
		}

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
	}
}