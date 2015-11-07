using System.Collections.Generic;
using System.IO;
using System.Linq;
using GtfsNet.Entities;
using GtfsNet.Entities.Maps;
using GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class FrequenciesParserTest : ParserTestBase
	{
		private readonly EntityParser<Frequency, FrequenciesMap> _parser = new EntityParser<Frequency, FrequenciesMap>();

		public override string TestFilePath { get; } = "feeds/subway/frequencies.txt";

		public FrequenciesParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Frequency> parsed = _parser.Parse(textReader);
				List<Frequency> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(11, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Frequency> parsed = _parser.Parse(textReader);
				List<Frequency> parsedList = parsed.ToList();

				Frequency item = parsedList[0];

				Assert.Null(item.ExactTimes);

				Assert.Equal("22:00:00", item.EndTime);
				Assert.Equal("1800", item.HeadwaySecs);
				Assert.Equal("6:00:00", item.StartTime);
				Assert.Equal("STBA", item.TripId);
			}
		}
	}
}
