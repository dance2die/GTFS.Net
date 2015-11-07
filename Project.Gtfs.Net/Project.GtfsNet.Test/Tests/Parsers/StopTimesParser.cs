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
	public class StopTimesParser : ParserTestBase
	{
		public override string TestFilePath { get; } = "feeds/subway/stop_times.txt";

		public EntityParser<StopTime, StopTimesMap> _parser = new EntityParser<StopTime, StopTimesMap>();

		public StopTimesParser(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<StopTime> parsed = _parser.Parse(textReader);
				List<StopTime> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(23908, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<StopTime> parsed = _parser.Parse(textReader);
				List<StopTime> parsedList = parsed.ToList();

				StopTime item = parsedList[0];

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
