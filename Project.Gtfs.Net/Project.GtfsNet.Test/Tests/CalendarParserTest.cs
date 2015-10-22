using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class CalendarParserTest : ParserTestBase
	{
		private readonly EntitiesParser<Calendar, CalendarMap> _parser = new EntitiesParser<Calendar, CalendarMap>();

		public override string TestFilePath { get; } = "feeds/subway/calendar.txt";

		public CalendarParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Calendar> parsed = _parser.Parse(textReader);
				List<Calendar> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(10, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Calendar> agencies = _parser.Parse(textReader);
				List<Calendar> agencyList = agencies.ToList();

				Calendar calendar = agencyList[0];

				Assert.True(calendar.Monday);
				Assert.True(calendar.Tuesday);
				Assert.True(calendar.Wednesday);
				Assert.True(calendar.Thursday);
				Assert.True(calendar.Friday);
				Assert.False(calendar.Saturday);
				Assert.False(calendar.Sunday);

				Assert.Equal("A20150614WKD", calendar.ServiceId);
				Assert.Equal(new DateTime(2015, 6, 14), calendar.StartDate);
				Assert.Equal(new DateTime(2016, 12, 31), calendar.EndDate);
			}
		}
	}
}
