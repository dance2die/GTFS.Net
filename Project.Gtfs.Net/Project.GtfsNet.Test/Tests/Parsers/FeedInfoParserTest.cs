using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class FeedInfoParserTest : ParserTestBase
	{
		private readonly EntityParser<FeedInfo, FeedInfoMap> _parser = new EntityParser<FeedInfo, FeedInfoMap>();

		public override string TestFilePath { get; } = "feeds/subway/feed_info.txt";

		public FeedInfoParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<FeedInfo> parsed = _parser.Parse(textReader);
				List<FeedInfo> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(1, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<FeedInfo> parsed = _parser.Parse(textReader);
				List<FeedInfo> parsedList = parsed.ToList();

				FeedInfo item = parsedList[0];

				Assert.Null(item.EndDate);
				Assert.Null(item.StartDate);

				Assert.Equal("en", item.Lang);
				Assert.Equal("Long Island Rail Road", item.PublisherName);
				Assert.Equal("http://web.mta.info/lirr", item.PublisherUrl);
				Assert.Equal("APP_S_NO.2", item.Version);
			}
		}
	}
}
