using System;


namespace R5T.F0027
{
	public class Urls : IUrls
	{
		#region Infrastructure

	    public static Urls Instance { get; } = new();

	    private Urls()
	    {
        }

	    #endregion
	}
}