using CsvHelper.Configuration;

namespace GtfsNet.Entities.Maps
{
	public class FeedInfoMap : CsvClassMap<FeedInfo>
	{
		public FeedInfoMap()
		{
			Map(e => e.PublisherName).Name("feed_publisher_name");
			Map(e => e.PublisherUrl).Name("feed_publisher_url");
			Map(e => e.Lang).Name("feed_lang");
			Map(e => e.StartDate).Name("feed_start_date");
			Map(e => e.EndDate).Name("feed_end_date");
			Map(e => e.Version).Name("feed_version");
		}
	}
}
