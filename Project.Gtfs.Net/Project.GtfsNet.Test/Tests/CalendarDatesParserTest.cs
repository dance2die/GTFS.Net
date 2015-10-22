using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Enums;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class CalendarDatesParserTest : ParserTestBase
	{
		private readonly EntitiesParser<CalendarDates, CalendarDatesMap> _parser = new EntitiesParser<CalendarDates, CalendarDatesMap>();

		public override string TestFilePath { get; } = "feeds/subway/calendar_dates.txt";

		public CalendarDatesParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void AgencyFileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<CalendarDates> agencies = _parser.Parse(textReader);
				List<CalendarDates> agencyList = agencies.ToList();

				Assert.NotNull(agencyList);
				Assert.True(agencyList.Any());
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<CalendarDates> agencies = _parser.Parse(textReader);
				List<CalendarDates> agencyList = agencies.ToList();

				CalendarDates item = agencyList[0];

				Assert.Equal(new DateTime(2015, 10, 24), item.Date);
				Assert.Equal(ExceptionType.Removed, item.ExceptionType);
				Assert.Equal("APP_S_NO.21", item.ServiceId);
			}
		}
	}
}
