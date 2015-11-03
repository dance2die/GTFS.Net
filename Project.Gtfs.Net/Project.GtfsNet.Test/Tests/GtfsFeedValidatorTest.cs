using Project.GtfsNet.Parsers;
using Project.GtfsNet.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class GtfsFeedValidatorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;

		private readonly GtfsFeed _parsedFeedGood;
		private readonly GtfsFeed _parsedFeedBad;
		private readonly GtfsFeed _parsedFeedNonExisting;

		private readonly GtfsFeedValidator _sut;

		public GtfsFeedValidatorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;

			_parsedFeedGood = new GtfsFeedParser().Parse(_visitorPathFixture.GoodFeedPath);
			_parsedFeedBad = new GtfsFeedParser().Parse(_visitorPathFixture.BadFeedPath);
			_parsedFeedNonExisting = new GtfsFeedParser().Parse(_visitorPathFixture.NonExistingFeedPath);

			_sut = new GtfsFeedValidator();
		}

		[Fact]
		public void GoodFeedIsValid()
		{
			bool isValid = _sut.Validate(_parsedFeedGood);

			Assert.True(isValid);
		}

		[Fact]
		public void BadFeedIsInvalid()
		{
			bool isValid = _sut.Validate(_parsedFeedBad);

			Assert.False(isValid);
		}

		[Fact]
		public void NonExistingFeedIsInvalid()
		{
			bool isValid = _sut.Validate(_parsedFeedNonExisting);

			Assert.False(isValid);
		}
	}
}
