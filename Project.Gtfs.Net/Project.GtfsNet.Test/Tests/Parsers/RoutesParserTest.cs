using System.Collections.Generic;
using System.IO;
using System.Linq;
using GtfsNet.Entities;
using GtfsNet.Entities.Maps;
using GtfsNet.Enums;
using GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class RoutesParserTest : ParserTestBase
	{
		public override string TestFilePath { get; } =  "feeds/subway/routes.txt";

		public EntityParser<Route, RoutesMap> _parser = new EntityParser<Route, RoutesMap>();

		public RoutesParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Route> parsed = _parser.Parse(textReader);
				List<Route> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(12, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Route> parsed = _parser.Parse(textReader);
				List<Route> parsedList = parsed.ToList();

				Route route = parsedList[0];

				Assert.Null(route.AgencyId);
				Assert.Null(route.Description);
				Assert.Null(route.Url);

				Assert.Equal("00985F", route.Color);
				Assert.Equal("1", route.Id);
				Assert.Equal("Babylon", route.LongName);
				Assert.Equal("", route.ShortName);
				Assert.Equal("FFFFFF", route.TextColor);

				Assert.Equal(RouteType.Rail, route.Type);
			}
		}
	}
}
