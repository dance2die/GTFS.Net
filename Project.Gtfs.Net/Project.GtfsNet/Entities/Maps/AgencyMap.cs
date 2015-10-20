using CsvHelper.Configuration;

namespace Project.GtfsNet.Entities.Maps
{
	public class AgencyMap : CsvClassMap<Agency>
	{
		public AgencyMap()
		{
			Map(e => e.Id).Name("agency_id");
			Map(e => e.Name).Name("agency_name");
			Map(e => e.Url).Name("agency_url");
			Map(e => e.Timezone).Name("agency_timezone");
			Map(e => e.Language).Name("agency_lang");
			Map(e => e.Phone).Name("agency_phone");
			Map(e => e.FareUrl).Name("agency_fare_url");
		}
	}
}