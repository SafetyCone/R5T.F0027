using System;


namespace R5T.F0027
{
	public class DotnetPublishOperator : IDotnetPublishOperator
	{
		#region Infrastructure

	    public static IDotnetPublishOperator Instance { get; } = new DotnetPublishOperator();

	    private DotnetPublishOperator()
	    {
        }

	    #endregion
	}
}