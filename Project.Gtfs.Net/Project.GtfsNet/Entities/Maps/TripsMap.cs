using CsvHelper.Configuration;

namespace GtfsNet.Entities.Maps
{
	public class TripsMap : CsvClassMap<Trip>
	{
		public TripsMap()
		{
			Map(e => e.Id).Name("trip_id");
			Map(e => e.RouteId).Name("route_id");
			Map(e => e.ServiceId).Name("service_id");
			Map(e => e.Headsign).Name("trip_headsign");
			Map(e => e.ShortName).Name("trip_short_name");
			Map(e => e.DirectionId).Name("direction_id");
			Map(e => e.BlockId).Name("block_id");
			Map(e => e.ShapeId).Name("shape_id");
			Map(e => e.WheelchairAccessibilityType).Name("wheelchair_accessible");
		}
	}
}
