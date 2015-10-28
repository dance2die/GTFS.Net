using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class GtfsFeedVistorTest
	{
		private readonly ITestOutputHelper _output;
		private readonly GtfsFeedParserVisitor _sut;
		private const string FEED_PATH = "feeds/subway";

		public GtfsFeedVistorTest(ITestOutputHelper output)
		{
			_output = output;
			_sut = new GtfsFeedParserVisitor(FEED_PATH);
		}

		[Fact]
		public void ParserDoesntReturnEmptyGtfsFeedProperties()
		{
			GtfsFeed feed = new GtfsFeed();
			feed.Accept(_sut);
			feed = _sut.Feed;

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
			GtfsFeed feed = new GtfsFeed();
			feed.Accept(_sut);

			_output.WriteLine("_sut.Feed.Count: {0}", _sut.Feed.Agencies.Count);
			Assert.NotEmpty(_sut.Feed.Agencies);

			_output.WriteLine("_sut.Feed.Count: {0}", _sut.Feed.Calendars.Count);
			Assert.NotEmpty(_sut.Feed.Calendars);

			_output.WriteLine("_sut.Feed.CalendarDates.Count: {0}", _sut.Feed.CalendarDates.Count);
			Assert.NotEmpty(_sut.Feed.CalendarDates);

			_output.WriteLine("_sut.Feed.FareAttributes.Count: {0}", _sut.Feed.FareAttributes.Count);
			Assert.NotEmpty(_sut.Feed.FareAttributes);

			_output.WriteLine("_sut.Feed.FareRules.Count: {0}", _sut.Feed.FareRules.Count);
			Assert.NotEmpty(_sut.Feed.FareRules);

			_output.WriteLine("_sut.Feed.FeedInfos.Count: {0}", _sut.Feed.FeedInfos.Count);
			Assert.NotEmpty(_sut.Feed.FeedInfos);

			_output.WriteLine("_sut.Feed.Frequencies.Count: {0}", _sut.Feed.Frequencies.Count);
			Assert.NotEmpty(_sut.Feed.Frequencies);

			_output.WriteLine("_sut.Feed.Routes.Count: {0}", _sut.Feed.Routes.Count);
			Assert.NotEmpty(_sut.Feed.Routes);

			_output.WriteLine("_sut.Feed.Shapes.Count: {0}", _sut.Feed.Shapes.Count);
			Assert.NotEmpty(_sut.Feed.Shapes);

			_output.WriteLine("_sut.Feed.Stops.Count: {0}", _sut.Feed.Stops.Count);
			Assert.NotEmpty(_sut.Feed.Stops);

			_output.WriteLine("_sut.Feed.StopTimes.Count: {0}", _sut.Feed.StopTimes.Count);
			Assert.NotEmpty(_sut.Feed.StopTimes);

			_output.WriteLine("_sut.Feed.Transfers.Count: {0}", _sut.Feed.Transfers.Count);
			Assert.NotEmpty(_sut.Feed.Transfers);

			_output.WriteLine("_sut.Feed.Trips.Count: {0}", _sut.Feed.Trips.Count);
			Assert.NotEmpty(_sut.Feed.Trips);
		}
	}
}
