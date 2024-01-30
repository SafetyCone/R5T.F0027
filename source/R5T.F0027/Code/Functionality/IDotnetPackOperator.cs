using System;

using R5T.T0132;


namespace R5T.F0027
{
	[FunctionalityMarker]
	public partial interface IDotnetPackOperator : IFunctionalityMarker
	{
		public void Run(string packArguments)
		{
			var dotnetArguments = $"{Instances.DotnetCommandNames.Pack} {packArguments}";

			Instances.DotnetOperator.Run(dotnetArguments);
		}

		/// <summary>
		/// Returns the file path of the generated package file.
		/// </summary>
		public string Pack(string projectFilePath)
		{
			var pathOperator = F0002.Instances.PathOperator;

			// Build the command.
			// Always release.
			var configurationArgument = "-c Release";

			var packArguments = $"{projectFilePath} {configurationArgument}";

			// Run the command.
			this.Run(packArguments);

			// Now build the output file path.
			var projectName = pathOperator.Get_FileNameStem(projectFilePath);

			// Read the project file to get the version of the project, else assume 1.0.0.
			var version = F0020.Instances.ProjectFileOperator.GetVersionOrDefault(projectFilePath);

			// Use version to create the package file name.
			var versionString = F0000.Instances.VersionOperator.ToString_Major_Minor_Build(version);

			var packageFileName = $"{projectName}.{versionString}.nupkg";

			var projectDirectoryPath = pathOperator.Get_ParentDirectoryPath(projectFilePath);

			var releaseDirectoryPath = pathOperator.Get_DirectoryPath(
				projectDirectoryPath,
				@"bin/Release");

			var packageFilePath = pathOperator.Get_FilePath(
				releaseDirectoryPath,
				packageFileName);

			// Check that the file path *actually* exists.
			F0000.Instances.FileSystemOperator.VerifyFileExists(packageFilePath);

			return packageFilePath;
		}
	}
}