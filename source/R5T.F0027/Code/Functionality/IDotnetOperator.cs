using System;

using R5T.T0132;


namespace R5T.F0027
{
	[FunctionalityMarker]
	public partial interface IDotnetOperator : IFunctionalityMarker
	{
		public void Run(string dotnetArguments)
        {
			Instances.DotnetCommandLineOperator.Run_InterceptErrorInOutput_ThrowIfError_Synchronous(dotnetArguments);
		}
	}
}