using CsvHelper.Configuration;

namespace GtfsNet.Entities.Maps
{
	public class FareRulesMap : CsvClassMap<FareRule>
	{
		public FareRulesMap()
		{
			Map(e => e.FareId).Name("fare_id");
			Map(e => e.RouteId).Name("route_id");
			Map(e => e.OriginId).Name("origin_id");
			Map(e => e.DestinationId).Name("destination_id");
			Map(e => e.ContainsId).Name("contains_id");
		}
	}
}
