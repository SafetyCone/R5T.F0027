using System;


namespace R5T.F0027
{
	public class DotnetCommandLineOperator : IDotnetCommandLineOperator
	{
		#region Infrastructure

	    public static IDotnetCommandLineOperator Instance { get; } = new DotnetCommandLineOperator();

	    private DotnetCommandLineOperator()
	    {
        }

	    #endregion
	}
}