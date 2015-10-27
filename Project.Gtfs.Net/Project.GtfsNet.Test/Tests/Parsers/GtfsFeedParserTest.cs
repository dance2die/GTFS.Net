using Project.GtfsNet.Parsers;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class GtfsFeedParserTest
	{
		private readonly GtfsFeedParser _sut;
		private const string FEED_PATH = "feeds/subway";

		public GtfsFeedParserTest()
		{
			_sut = new GtfsFeedParser();
		}

		[Fact]
		public void ParserDoesntReturnEmptyGtfsFeedProperties()
		{
			GtfsFeed feed = _sut.Parse(FEED_PATH);

			Assert.NotNull(feed.Agencies);
			Assert.NotNull(feed.Calendars);
			Assert.NotNull(feed.CalendarDates);
			Assert.NotNull(feed.FareAttributes);
			Assert.NotNull(feed.FareRules);
			Assert.NotNull(feed.FeedInfos);
			Assert.NotNull(feed.Frequencies);
			Assert.NotNull(feed.Routes);
			Assert.NotNull(feed.Shapes);
			Assert.NotNull(feed.Stops);
			Assert.NotNull(feed.StopTimes);
			Assert.NotNull(feed.Transfers);
			Assert.NotNull(feed.Trips);
		}
	}
}
