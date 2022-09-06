using System;


namespace R5T.F0027
{
	public class ExecutableNames : IExecutableNames
	{
		#region Infrastructure

	    public static ExecutableNames Instance { get; } = new();

	    private ExecutableNames()
	    {
        }

	    #endregion
	}
}