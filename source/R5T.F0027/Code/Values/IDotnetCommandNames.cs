using System;

using R5T.T0131;


namespace R5T.F0027
{
	[ValuesMarker]
	public partial interface IDotnetCommandNames : IValuesMarker
	{
		public string Nuget => "nuget";
		public string Pack => "pack";
		public string Publish => "publish";
		public string Push => "push";
	}
}