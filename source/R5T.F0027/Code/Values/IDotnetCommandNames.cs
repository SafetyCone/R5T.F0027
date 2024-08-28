using System;

using R5T.T0131;


namespace R5T.F0027
{
	[ValuesMarker]
	public partial interface IDotnetCommandNames : IValuesMarker
	{
		/// <summary>
		/// <para><value>nuget</value></para>
		/// </summary>
		public string Nuget => "nuget";

        /// <summary>
        /// <para><value>pack</value></para>
        /// </summary>
        public string Pack => "pack";

        /// <summary>
        /// <para><value>publish</value></para>
        /// </summary>
        public string Publish => "publish";

        /// <summary>
        /// <para><value>push</value></para>
        /// </summary>
        public string Push => "push";
	}
}