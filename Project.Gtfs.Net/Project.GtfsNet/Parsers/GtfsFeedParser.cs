using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Parsers
{
	//public class GtfsFeedParser
	//{
	//	/// <summary>
	//	/// @ToDo: Convert the parser to use Visitor pattern instead.
	//	/// </summary>
	//	public GtfsFeed Parse(string feedPath)
	//	{
	//		var result = new GtfsFeed
	//		{
	//			Agencies = GetParsedList<Agency>(feedPath),
	//			Calendars = GetParsedList<Calendar>(feedPath),
	//			CalendarDates = GetParsedList<CalendarDate>(feedPath),
	//			FareAttributes = GetParsedList<FareAttribute>(feedPath),
	//			FareRules = GetParsedList<FareRule>(feedPath),
	//			FeedInfos = GetParsedList<FeedInfo>(feedPath),
	//			Frequencies = GetParsedList<Frequency>(feedPath),
	//			Routes = GetParsedList<Route>(feedPath),
	//			Shapes = GetParsedList<Shape>(feedPath),
	//			Stops = GetParsedList<Stop>(feedPath),
	//			StopTimes = GetParsedList<StopTime>(feedPath),
	//			Transfers = GetParsedList<Transfer>(feedPath),
	//			Trips = GetParsedList<Trip>(feedPath)
	//		};

	//		return result;
	//	}

	//	private HashSet<T> GetParsedList<T>(string feedPath)
	//	{
	//		using (var textReader = GetTextReader<T>(feedPath))
	//		{
	//			var entityParser = new EntityParserFactory().Create(
	//				EntityParserFactory.SupportedFileNames.GetFileNameByType<T>());
	//			return new HashSet<T>(entityParser.Parse(textReader).Cast<T>());
	//		}
	//	}

	//	private TextReader GetTextReader<T>(string feedPath)
	//	{
	//		string fileName = EntityParserFactory.SupportedFileNames.GetFileNameByType<T>();
	//		var testFilePath = Path.Combine(feedPath, fileName);
	//		return File.OpenText(testFilePath);
	//	}
	//}
}
