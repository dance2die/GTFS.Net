using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Core;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class StopsParserTest : ParserTestBase, IClassFixture<StopsParserFixture>
	{
		private readonly StopsParserFixture _stopsParserFixture;

		public override string TestFilePath { get; } = "feeds/subway/stops.txt";

		public StopsParserTest(ITestOutputHelper output, StopsParserFixture stopsParserFixture)
		{
			_stopsParserFixture = stopsParserFixture;
			_output = output;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.Throws<ArgumentNullException>(() => _stopsParserFixture.Parser.Parse(null));
		}

		[Fact]
		public void StopsFileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Stops> stops = _stopsParserFixture.Parser.Parse(textReader);
				List<Stops> stopsList = stops.ToList();

				Assert.NotNull(stopsList);
				Assert.True(stopsList.Any());
			}
		}

		[Fact]
		public void CheckAgencyDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Stops> stops = _stopsParserFixture.Parser.Parse(textReader);
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
