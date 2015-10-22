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
	public class ShapesParserTest : ParserTestBase
	{
		private readonly EntitiesParser<Shapes, ShapesMap> _parser = new EntitiesParser<Shapes, ShapesMap>();

		public override string TestFilePath { get; } = "feeds/subway/shapes.txt";

		public ShapesParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Shapes> parsed = _parser.Parse(textReader);
				List<Shapes> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(183725, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Shapes> parsed = _parser.Parse(textReader);
				List<Shapes> parsedList = parsed.ToList();

				Shapes item = parsedList[0];

				Assert.Null(item.DistanceTraveled);

				Assert.Equal("0", item.Id);
				Assert.Equal(40.7673330423, item.Latitude);
				Assert.Equal(-73.5282357452, item.Longitude);
				Assert.Equal(0, item.Sequence);
			}
		}
	}
}
