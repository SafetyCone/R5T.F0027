using System;


namespace R5T.F0027
{
	public class DotnetCommandNames : IDotnetCommandNames
	{
		#region Infrastructure

	    public static DotnetCommandNames Instance { get; } = new();

	    private DotnetCommandNames()
	    {
        }

	    #endregion
	}
}