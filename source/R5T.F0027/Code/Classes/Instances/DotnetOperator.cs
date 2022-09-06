using System;


namespace R5T.F0027
{
	public class DotnetOperator : IDotnetOperator
	{
		#region Infrastructure

	    public static DotnetOperator Instance { get; } = new();

	    private DotnetOperator()
	    {
        }

	    #endregion
	}
}