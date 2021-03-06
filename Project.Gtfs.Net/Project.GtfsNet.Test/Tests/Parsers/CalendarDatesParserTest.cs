﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GtfsNet.Entities;
using GtfsNet.Entities.Maps;
using GtfsNet.Enums;
using GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace GtfsNet.Test.Tests.Parsers
{
	public class CalendarDatesParserTest : ParserTestBase
	{
		private readonly EntityParser<CalendarDate, CalendarDatesMap> _parser = new EntityParser<CalendarDate, CalendarDatesMap>();

		public override string TestFilePath { get; } = "feeds/subway/calendar_dates.txt";

		public CalendarDatesParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<CalendarDate> parsed = _parser.Parse(textReader);
				List<CalendarDate> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(5659, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<CalendarDate> parsed = _parser.Parse(textReader);
				List<CalendarDate> parsedList = parsed.ToList();

				CalendarDate item = parsedList[0];

				Assert.Equal(new DateTime(2015, 10, 24), item.Date);
				Assert.Equal(ExceptionType.Removed, item.ExceptionType);
				Assert.Equal("APP_S_NO.21", item.ServiceId);
			}
		}
	}
}
