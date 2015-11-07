namespace GtfsNet.Enums
{
	/// <summary>
	/// https://developers.google.com/transit/gtfs/reference#stopstxt
	/// </summary>
	public enum LocationType
	{
		/// <summary>
		/// 0 or blank - Stop. A location where passengers board or disembark from a transit vehicle.
		/// </summary>
		Stop,
		/// <summary>
		/// 1 - Station. A physical structure or area that contains one or more stop.
		/// </summary>
		Station
	}
}
