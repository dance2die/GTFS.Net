using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Parsers
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

		//private HashSet<T> GetParsedList<T>(string feedPath)
		//{
		//	using (var textReader = GetTextReader<T>(feedPath))
		//	{
		//		var entityParser = new EntityParserFactory().Create(
		//			EntityParserFactory.SupportedFileNames.GetFileNameByType<T>());
		//		return new HashSet<T>(entityParser.Parse(textReader).Cast<T>());
		//	}
		//}

		//private TextReader GetTextReader<T>(string feedPath)
		//{
		//	string fileName = EntityParserFactory.SupportedFileNames.GetFileNameByType<T>();
		//	var testFilePath = Path.Combine(feedPath, fileName);
		//	return File.OpenText(testFilePath);
		//}
	}
}
