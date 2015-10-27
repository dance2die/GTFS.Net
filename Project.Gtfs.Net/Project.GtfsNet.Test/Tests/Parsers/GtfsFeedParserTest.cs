using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class GtfsFeedParserTest
	{
		private readonly ITestOutputHelper _output;
		private readonly GtfsFeedParser _sut;
		private const string FEED_PATH = "feeds/subway";

		public GtfsFeedParserTest(ITestOutputHelper output)
		{
			_output = output;
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

		[Fact]
		public void ParserReturnParsedGtfsFeedWithAtLeastOneRecordInEachProperty()
		{
			GtfsFeed feed = _sut.Parse(FEED_PATH);

			_output.WriteLine("feed.Agencies.Count: {0}", feed.Agencies.Count);
			Assert.NotEmpty(feed.Agencies);

			_output.WriteLine("feed.Calendars.Count: {0}", feed.Calendars.Count);
			Assert.NotEmpty(feed.Calendars);

			_output.WriteLine("feed.CalendarDates.Count: {0}", feed.CalendarDates.Count);
			Assert.NotEmpty(feed.CalendarDates);
			//Assert.NotEmpty(feed.FareAttributes);
			//Assert.NotEmpty(feed.FareRules);
			//Assert.NotEmpty(feed.FeedInfos);
			//Assert.NotEmpty(feed.Frequencies);
			//Assert.NotEmpty(feed.Routes);
			//Assert.NotEmpty(feed.Shapes);
			//Assert.NotEmpty(feed.Stops);
			//Assert.NotEmpty(feed.StopTimes);
			//Assert.NotEmpty(feed.Transfers);
			//Assert.NotEmpty(feed.Trips);
		}
	}
}
