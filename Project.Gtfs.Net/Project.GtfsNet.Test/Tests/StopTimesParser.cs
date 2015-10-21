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
	public class StopTimesParser : ParserTestBase
	{
		public override string TestFilePath { get; } = "feeds/subway/stop_times.txt";

		public EntitiesParser<StopTimes, StopTimesMap> _parser = new EntitiesParser<StopTimes, StopTimesMap>();

		public StopTimesParser(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void StopTimesFileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<StopTimes> parsed = _parser.Parse(textReader);
				List<StopTimes> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<StopTimes> parsed = _parser.Parse(textReader);
				List<StopTimes> parsedList = parsed.ToList();

				StopTimes item = parsedList[0];

				Assert.Null(item.DropOffType);
				Assert.Null(item.PickupType);
				Assert.Null(item.ShapeDistTravelled);
				Assert.Null(item.StopHeadsign);

				Assert.Equal("01:12:00", item.ArrivalTime);
				Assert.Equal("01:12:00", item.DepartureTime);
				Assert.Equal("56", item.StopId);
				Assert.Equal(1, item.StopSequence);
				Assert.Equal("APP_S_NO.24822", item.TripId);
			}
		}
	}
}
