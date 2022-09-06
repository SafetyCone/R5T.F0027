using System;

using R5T.T0131;


namespace R5T.F0027
{
	[ValuesMarker]
	public partial interface IUrls : IValuesMarker
	{
		public string NuGetAccountPackages => @"https://www.nuget.org/account/Packages";
		/// <summary>
		/// The official NuGet server URL.
		/// Used as the source URL in push operations.
		/// </summary>
		public string NuGet => @"https://api.nuget.org/v3/index.json";
	}
}