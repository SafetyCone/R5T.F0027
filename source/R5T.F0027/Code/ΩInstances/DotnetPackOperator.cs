using System;


namespace R5T.F0027
{
	public class DotnetPackOperator : IDotnetPackOperator
	{
		#region Infrastructure

	    public static IDotnetPackOperator Instance { get; } = new DotnetPackOperator();

	    private DotnetPackOperator()
	    {
        }

	    #endregion
	}
}