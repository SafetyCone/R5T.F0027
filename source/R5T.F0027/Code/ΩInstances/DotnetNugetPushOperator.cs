using System;


namespace R5T.F0027
{
	public class DotnetNugetPushOperator : IDotnetNugetPushOperator
	{
		#region Infrastructure

	    public static IDotnetNugetPushOperator Instance { get; } = new DotnetNugetPushOperator();

	    private DotnetNugetPushOperator()
	    {
        }

	    #endregion
	}
}