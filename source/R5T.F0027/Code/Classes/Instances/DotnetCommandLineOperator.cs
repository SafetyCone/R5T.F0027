using System;


namespace R5T.F0027
{
	public class DotnetCommandLineOperator : IDotnetCommandLineOperator
	{
		#region Infrastructure

	    public static DotnetCommandLineOperator Instance { get; } = new();

	    private DotnetCommandLineOperator()
	    {
        }

	    #endregion
	}
}