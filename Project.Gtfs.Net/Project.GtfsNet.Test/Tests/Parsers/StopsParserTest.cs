using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GtfsNet.Entities;
using GtfsNet.Entities.Maps;
using GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace GtfsNet.Test.Tests.Parsers
{
	public class StopsParserTest : ParserTestBase
	{
		public override string TestFilePath { get; } = "feeds/subway/stops.txt";

		public EntityParser<Stop,StopsMap> _parser = new EntityParser<Stop, StopsMap>();

		public StopsParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.Throws<ArgumentNullException>(() => _parser.Parse(null));
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Stop> parsed = _parser.Parse(textReader);
				List<Stop> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(124, parsedList.Count);
			}
		}

		[Fact]
		public void CheckAgencyDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Stop> stops = _parser.Parse(textReader);
				List<Stop> stopsList = stops.ToList();

				Stop stopItem = stopsList[0];

				Assert.Null(stopItem.Code);
				Assert.Null(stopItem.Description);
				Assert.Null(stopItem.LocationType);
				Assert.Null(stopItem.ParentStation);
				Assert.Null(stopItem.Timezone);
				Assert.Null(stopItem.Url);
				Assert.Null(stopItem.WheelchairBoarding);
				Assert.Null(stopItem.Zone);

				Assert.Equal("1", stopItem.Id);
				Assert.Equal(40.74128, stopItem.Latitude);
				Assert.Equal(-73.95639, stopItem.Longitude);
				Assert.Equal("Long Island City", stopItem.Name);
			}
		}
	}
}
