using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Parsers
{
	public class GtfsFeedParser
	{
		public GtfsFeed Parse(string feedPath)
		{
			var result = new GtfsFeed();

			result.Agencies = GetParsedList<Agency>(feedPath);
			result.Calendars = GetParsedList<Calendar>(feedPath);
			result.CalendarDates = GetParsedList<CalendarDate>(feedPath);
			result.FareAttributes = GetParsedList<FareAttribute>(feedPath);
			result.FareRules = GetParsedList<FareRule>(feedPath);
			result.FeedInfos = GetParsedList<FeedInfo>(feedPath);
			result.Frequencies = GetParsedList<Frequency>(feedPath);
			result.Routes = GetParsedList<Route>(feedPath);
			result.Shapes = GetParsedList<Shape>(feedPath);
			result.Stops = GetParsedList<Stop>(feedPath);
			result.StopTimes = GetParsedList<StopTime>(feedPath);
			result.Transfers = GetParsedList<Transfer>(feedPath);
			result.Trips = GetParsedList<Trip>(feedPath);

			return result;
		}

		private HashSet<T> GetParsedList<T>(string feedPath)
		{
			var textReader = GetTextReader<T>(feedPath);
			var entityParser = new EntityParserFactory().Create(EntityParserFactory.SupportedFileNames.GetFileNameByType<T>());
			return new HashSet<T>(entityParser.Parse(textReader).Cast<T>());
		}

		public TextReader GetTextReader<T>(string feedPath)
		{
			string fileName = EntityParserFactory.SupportedFileNames.GetFileNameByType<T>();
			var testFilePath = Path.Combine(feedPath, fileName);
			return File.OpenText(testFilePath);
		}
	}
}
