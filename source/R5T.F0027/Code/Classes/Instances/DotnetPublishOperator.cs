using System;


namespace R5T.F0027
{
	public class DotnetPublishOperator : IDotnetPublishOperator
	{
		#region Infrastructure

	    public static DotnetPublishOperator Instance { get; } = new();

	    private DotnetPublishOperator()
	    {
        }

	    #endregion
	}
}