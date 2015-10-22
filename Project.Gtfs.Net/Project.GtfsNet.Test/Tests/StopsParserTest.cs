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
	public class StopsParserTest : ParserTestBase
	{
		public override string TestFilePath { get; } = "feeds/subway/stops.txt";

		public EntitiesParser<Stops,StopsMap> _parser = new EntitiesParser<Stops, StopsMap>();

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
				IEnumerable<Stops> parsed = _parser.Parse(textReader);
				List<Stops> parsedList = parsed.ToList();

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
				IEnumerable<Stops> stops = _parser.Parse(textReader);
				List<Stops> stopsList = stops.ToList();

				Stops stopsItem = stopsList[0];

				Assert.Null(stopsItem.Code);
				Assert.Null(stopsItem.Description);
				Assert.Null(stopsItem.LocationType);
				Assert.Null(stopsItem.ParentStation);
				Assert.Null(stopsItem.Timezone);
				Assert.Null(stopsItem.Url);
				Assert.Null(stopsItem.WheelchairBoarding);
				Assert.Null(stopsItem.Zone);

				Assert.Equal("1", stopsItem.Id);
				Assert.Equal(40.74128, stopsItem.Latitude);
				Assert.Equal(-73.95639, stopsItem.Longitude);
				Assert.Equal("Long Island City", stopsItem.Name);
			}
		}
	}
}
