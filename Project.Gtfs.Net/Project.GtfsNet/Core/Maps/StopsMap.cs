using CsvHelper.Configuration;

namespace Project.GtfsNet.Core.Maps
{
	public class StopsMap : CsvClassMap<Stops>
	{
		public StopsMap()
		{
			Map(e => e.Id).Name("stop_id");
			Map(e => e.Code).Name("stop_code");
			Map(e => e.Name).Name("stop_name");
			Map(e => e.Description).Name("stop_desc");
			Map(e => e.Latitude).Name("stop_lat");
			Map(e => e.Longitude).Name("stop_lon");
			Map(e => e.Zone).Name("zone_id");
			Map(e => e.Url).Name("stop_url");
			Map(e => e.LocationType).Name("location_type");
			Map(e => e.ParentStation).Name("parent_station");
			Map(e => e.Timezone).Name("stop_timezone");
			Map(e => e.WheelchairBoarding).Name("wheelchair_boarding");
		}
	}
}
