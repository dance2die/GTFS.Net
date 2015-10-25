using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Enums;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class TripsParserTest : ParserTestBase
	{
		public override string TestFilePath { get; } = "feeds/subway/trips.txt";

		public EntityParser<Trip, TripsMap> _parser = new EntityParser<Trip, TripsMap>();

		public TripsParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Trip> parsed = _parser.Parse(textReader);
				List<Trip> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(2119, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Trip> parsed = _parser.Parse(textReader);
				List<Trip> parsedList = parsed.ToList();

				Trip stopsItem = parsedList[0];

				Assert.Null(stopsItem.BlockId);
				Assert.Null(stopsItem.WheelchairAccessibilityType);

				Assert.Equal(DirectionType.TravelInOneDirection, stopsItem.DirectionId.Value);
				Assert.Equal("Huntington", stopsItem.Headsign);
				Assert.Equal("APP_S_NO.24822", stopsItem.Id);
				Assert.Equal("10", stopsItem.RouteId);
				Assert.Equal("APP_S_NO.273", stopsItem.ServiceId);
				Assert.Equal("0", stopsItem.ShapeId);
				Assert.Equal("4822", stopsItem.ShortName);
			}
		}
	}
}
