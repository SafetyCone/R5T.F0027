using System;


namespace R5T.F0027
{
	public class DotnetNugetOperator : IDotnetNugetOperator
	{
		#region Infrastructure

	    public static DotnetNugetOperator Instance { get; } = new();

	    private DotnetNugetOperator()
	    {
        }

	    #endregion
	}
}