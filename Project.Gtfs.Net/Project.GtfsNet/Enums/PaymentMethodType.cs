namespace GtfsNet.Enums
{
	/// <summary>
	/// Indicates when the fare must be paid.
	/// </summary>
	/// <remarks>
	/// Copied from
	/// https://github.com/OsmSharp/GTFS/blob/226a247861cf90badde49655095193ac829cf227/GTFS/Entities/Enumerations/PaymentMethodType.cs
	/// </remarks>
	public enum PaymentMethodType
	{
		/// <summary>
		/// Fare is paid on board.
		/// </summary>
		OnBoard,
		/// <summary>
		/// Fare must be paid before boarding.
		/// </summary>
		BeforeBoarding
	}
}