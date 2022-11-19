using System;


namespace R5T.F0027
{
	public class DotnetCommandNames : IDotnetCommandNames
	{
		#region Infrastructure

	    public static IDotnetCommandNames Instance { get; } = new DotnetCommandNames();

	    private DotnetCommandNames()
	    {
        }

	    #endregion
	}
}