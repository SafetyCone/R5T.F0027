using System;


namespace R5T.F0027
{
	public class DotnetPackOperator : IDotnetPackOperator
	{
		#region Infrastructure

	    public static DotnetPackOperator Instance { get; } = new();

	    private DotnetPackOperator()
	    {
        }

	    #endregion
	}
}