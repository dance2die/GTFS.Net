using GtfsNet.Visitors;

namespace GtfsNet.Parsers
{
	public class GtfsFeedParser
	{
		/// <summary>
		/// Facade for parsing GTFS feed
		/// </summary>
		public GtfsFeed Parse(string feedPath)
		{
			GtfsFeedParserVisitor parser = new GtfsFeedParserVisitor(feedPath);
			GtfsFeed feed = new GtfsFeed();
			feed.Accept(parser);

			return parser.Feed;
		}
	}
}
