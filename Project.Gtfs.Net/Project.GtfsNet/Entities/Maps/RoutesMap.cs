using CsvHelper.Configuration;

namespace GtfsNet.Entities.Maps
{
	public class RoutesMap : CsvClassMap<Route>
	{
		public RoutesMap()
		{
			Map(e => e.Id).Name("route_id");
			Map(e => e.AgencyId).Name("agency_id");
			Map(e => e.ShortName).Name("route_short_name");
			Map(e => e.LongName).Name("route_long_name");
			Map(e => e.Description).Name("route_desc");
			Map(e => e.Type).Name("route_type");
			Map(e => e.Url).Name("route_url");
			Map(e => e.Color).Name("route_color");
			Map(e => e.TextColor).Name("route_text_color");
		}
	}
}
