using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Core;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class StopsParserTest : ParserTestBase
	{
		private readonly StopsParser _sut = new StopsParser();

		public override string TestFilePath { get; } = "feeds/subway/stops.txt";

		public StopsParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.Throws<ArgumentNullException>(() => _sut.Parse(null));
		}

		[Fact]
		public void StopsFileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Stops> stops = _sut.Parse(textReader);
				List<Stops> stopsList = stops.ToList();

				Assert.NotNull(stopsList);
				Assert.True(stopsList.Any());
			}
		}
	}
}
