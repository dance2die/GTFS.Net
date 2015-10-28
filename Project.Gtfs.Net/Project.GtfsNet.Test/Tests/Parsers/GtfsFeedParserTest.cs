using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	//public class GtfsFeedParserTest
	//{
	//	private readonly ITestOutputHelper _output;
	//	private readonly GtfsFeedParser _sut;
	//	private const string FEED_PATH = "feeds/subway";

	//	public GtfsFeedParserTest(ITestOutputHelper output)
	//	{
	//		_output = output;
	//		_sut = new GtfsFeedParser();
	//	}

	//	[Fact]
	//	public void ParserDoesntReturnEmptyGtfsFeedProperties()
	//	{
	//		GtfsFeed feed = _sut.Parse(FEED_PATH);

	//		Assert.NotNull(feed.Agencies);
	//		Assert.NotNull(feed.Calendars);
	//		Assert.NotNull(feed.CalendarDates);
	//		Assert.NotNull(feed.FareAttributes);
	//		Assert.NotNull(feed.FareRules);
	//		Assert.NotNull(feed.FeedInfos);
	//		Assert.NotNull(feed.Frequencies);
	//		Assert.NotNull(feed.Routes);
	//		Assert.NotNull(feed.Shapes);
	//		Assert.NotNull(feed.Stops);
	//		Assert.NotNull(feed.StopTimes);
	//		Assert.NotNull(feed.Transfers);
	//		Assert.NotNull(feed.Trips);
	//	}

	//	[Fact]
	//	public void ParserReturnParsedGtfsFeedWithAtLeastOneRecordInEachProperty()
	//	{
	//		GtfsFeed feed = _sut.Parse(FEED_PATH);

	//		_output.WriteLine("feed.Agencies.Count: {0}", feed.Agencies.Count);
	//		Assert.NotEmpty(feed.Agencies);

	//		_output.WriteLine("feed.Calendars.Count: {0}", feed.Calendars.Count);
	//		Assert.NotEmpty(feed.Calendars);

	//		_output.WriteLine("feed.CalendarDates.Count: {0}", feed.CalendarDates.Count);
	//		Assert.NotEmpty(feed.CalendarDates);

	//		_output.WriteLine("feed.FareAttributes.Count: {0}", feed.FareAttributes.Count);
	//		Assert.NotEmpty(feed.FareAttributes);

	//		_output.WriteLine("feed.FareRules.Count: {0}", feed.FareRules.Count);
	//		Assert.NotEmpty(feed.FareRules);

	//		_output.WriteLine("feed.FeedInfos.Count: {0}", feed.FeedInfos.Count);
	//		Assert.NotEmpty(feed.FeedInfos);

	//		_output.WriteLine("feed.Frequencies.Count: {0}", feed.Frequencies.Count);
	//		Assert.NotEmpty(feed.Frequencies);

	//		_output.WriteLine("feed.Routes.Count: {0}", feed.Routes.Count);
	//		Assert.NotEmpty(feed.Routes);

	//		_output.WriteLine("feed.Shapes.Count: {0}", feed.Shapes.Count);
	//		Assert.NotEmpty(feed.Shapes);

	//		_output.WriteLine("feed.Stops.Count: {0}", feed.Stops.Count);
	//		Assert.NotEmpty(feed.Stops);

	//		_output.WriteLine("feed.StopTimes.Count: {0}", feed.StopTimes.Count);
	//		Assert.NotEmpty(feed.StopTimes);

	//		_output.WriteLine("feed.Transfers.Count: {0}", feed.Transfers.Count);
	//		Assert.NotEmpty(feed.Transfers);

	//		_output.WriteLine("feed.Trips.Count: {0}", feed.Trips.Count);
	//		Assert.NotEmpty(feed.Trips);
	//	}
	//}
}
