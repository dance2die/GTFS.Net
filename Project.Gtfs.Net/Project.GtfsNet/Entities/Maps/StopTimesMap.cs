using CsvHelper.Configuration;

namespace Project.GtfsNet.Entities.Maps
{
	public class StopTimesMap : CsvClassMap<StopTimes>
	{
		public StopTimesMap()
		{
			Map(e => e.TripId).Name("trip_id");
			Map(e => e.ArrivalTime).Name("arrival_time");
			Map(e => e.DepartureTime).Name("departure_time");
			Map(e => e.StopId).Name("stop_id");
			Map(e => e.StopSequence).Name("stop_sequence");
			Map(e => e.StopHeadsign).Name("stop_headsign");
			Map(e => e.PickupType).Name("pickup_type");
			Map(e => e.DropOffType).Name("drop_off_type");
			Map(e => e.ShapeDistTravelled).Name("shape_dist_traveled");
		}
	}
}
