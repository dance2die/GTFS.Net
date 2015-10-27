using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Parsers
{
	public class GtfsFeedParser
	{
		public GtfsFeed Parse(string feedPath)
		{
			var result = new GtfsFeed();
			var parserFactory = new EntityParserFactory();

			var agencyTextReader = GetTextReader(feedPath, EntityParserFactory.SupportedFileNames.Agency);
			result.Agencies = new HashSet<Agency>(
				parserFactory.Create(EntityParserFactory.SupportedFileNames.Agency).Parse(agencyTextReader).Cast<Agency>());

			var calendarTextReader = GetTextReader(feedPath, EntityParserFactory.SupportedFileNames.Calendar);
			result.Calendars = new HashSet<Calendar>(
				parserFactory.Create(EntityParserFactory.SupportedFileNames.Calendar).Parse(calendarTextReader).Cast<Calendar>());

			var calendarDatesTextReader = GetTextReader(feedPath, EntityParserFactory.SupportedFileNames.CalendarDates);
			result.CalendarDates = new HashSet<CalendarDate>(
				parserFactory.Create(EntityParserFactory.SupportedFileNames.CalendarDates).Parse(calendarDatesTextReader).Cast<CalendarDate>());

			return result;
		}

		public TextReader GetTextReader(string feedPath, string fileName)
		{
			var testFilePath = Path.Combine(feedPath, fileName);
			return File.OpenText(testFilePath);
		}
	}
}
