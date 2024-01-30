using System;

using R5T.T0132;


namespace R5T.F0027
{
	[FunctionalityMarker]
	public partial interface IDotnetNugetPushOperator : IFunctionalityMarker
	{
		public string BuildNugetArguments(string pushArguments)
        {
			var output = $"{Instances.DotnetCommandNames.Push} {pushArguments}";
			return output;
		}

		public string BuildPushArguments_ToLocalDirectory(
			string packageFilePath,
			string localDirectoryPath)
        {
			var sourceArgument = $"-s \"{localDirectoryPath}\"";

			var pushArguments = $"\"{packageFilePath}\" {sourceArgument}";
			return pushArguments;
		}

		public string BuildPushArguments_ToNuGet(
			string packageFilePath,
			string apiKey)
		{
			var apiKeyArgument = $"-k {apiKey}";
			var sourceArgument = $"-s {Instances.Urls.NuGet}";

			var pushArguments = $"{packageFilePath} {apiKeyArgument} {sourceArgument}";
			return pushArguments;
		}

		public void Run(string pushArguments)
		{
			var nugetArguments = this.BuildNugetArguments(pushArguments);

			Instances.DotnetNugetOperator.Run(nugetArguments);
		}

		/// <summary>
		/// Returns the package file path for the package in the local directory the initial package file was pushed to.s
		/// </summary>
		public string Push_ToLocalDirectory(
			string packageFilePath,
			string localDirectoryPath)
        {
			var pushArguments = this.BuildPushArguments_ToLocalDirectory(
				packageFilePath,
				localDirectoryPath);

			this.Run(pushArguments);

			var packageFileName = F0002.PathOperator.Instance.Get_FileName(packageFilePath);

			var localDirectoryPackageFilePath = F0002.PathOperator.Instance.Get_FilePath(
				localDirectoryPath,
				packageFileName);

			return localDirectoryPackageFilePath;
        }

		public void Push_ToNuGet(
			string packageFilePath,
			string apiKey)
        {
			var pushArguments = this.BuildPushArguments_ToNuGet(
				packageFilePath,
				apiKey);

			this.Run(pushArguments);
        }
	}
}