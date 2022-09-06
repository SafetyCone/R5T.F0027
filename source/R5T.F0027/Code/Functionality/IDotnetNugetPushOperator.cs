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

		public void Push_ToLocalDirectory(
			string packageFilePath,
			string localDirectoryPath)
        {
			var pushArguments = this.BuildPushArguments_ToLocalDirectory(
				packageFilePath,
				localDirectoryPath);

			this.Run(pushArguments);
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