using System;


namespace R5T.F0027
{
	public class DotnetNugetOperator : IDotnetNugetOperator
	{
		#region Infrastructure

	    public static IDotnetNugetOperator Instance { get; } = new DotnetNugetOperator();

	    private DotnetNugetOperator()
	    {
        }

	    #endregion
	}
}