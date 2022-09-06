using System;

using R5T.T0132;


namespace R5T.F0027
{
	[FunctionalityMarker]
	public partial interface IDotnetNugetOperator : IFunctionalityMarker
	{
		public string BuildDotnetArguments(string nugetArguments)
        {
			var output = $"{Instances.DotnetCommandNames.Nuget} {nugetArguments}";
			return output;
		}

		public void Run(string nugetArguments)
		{
			var dotnetArguments = this.BuildDotnetArguments(nugetArguments);

			Instances.DotnetOperator.Run(dotnetArguments);
		}
	}
}