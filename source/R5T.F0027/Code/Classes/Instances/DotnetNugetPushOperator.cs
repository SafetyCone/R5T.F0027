using System;


namespace R5T.F0027
{
	public class DotnetNugetPushOperator : IDotnetNugetPushOperator
	{
		#region Infrastructure

	    public static DotnetNugetPushOperator Instance { get; } = new();

	    private DotnetNugetPushOperator()
	    {
        }

	    #endregion
	}
}