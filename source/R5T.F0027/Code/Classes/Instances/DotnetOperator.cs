using System;


namespace R5T.F0027
{
	public class DotnetOperator : IDotnetOperator
	{
		#region Infrastructure

	    public static IDotnetOperator Instance { get; } = new DotnetOperator();

	    private DotnetOperator()
	    {
        }

	    #endregion
	}
}