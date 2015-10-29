using Project.GtfsNet.Parsers;
using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Visitors
{
	/// <summary>
	/// Test if all required files are parsed.
	/// Required file list can be found here.<see cref="https://developers.google.com/transit/gtfs/reference#feed-files"/>
	/// </summary>
	public class RequiredFileVisitorTest
	{
		private const string FEED_PATH = "feeds/subway";

		private readonly ITestOutputHelper _output;

		public RequiredFileVisitorTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void WhenAllFilesAreParsedAllRequiredFilesShoulNotBeEmpty()
		{
			var parser = new GtfsFeedParser();
			var feed = parser.Parse(FEED_PATH);
			RequiredFileVisitor sut = new RequiredFileVisitor();

			feed.Accept(sut);

			Assert.True(sut.IsValid);
		}

		[Fact]
		public void EmptyFeedShouldBeInvalid()
		{
			RequiredFileVisitor sut = new RequiredFileVisitor();

			GtfsFeed emptyFeed = new GtfsFeed();
			emptyFeed.Accept(sut);

			Assert.False(sut.IsValid);
		}
	}
}
