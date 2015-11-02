using System.Collections.Generic;
using System.Linq;
using Project.GtfsNet.Test.Fixtures;
using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Visitors
{
	public class RequiredFieldVisitorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;
		private readonly RequiredFieldVisitor _sut;
		private readonly GtfsFeed _parsedFeedGood;
		private readonly GtfsFeed _parsedFeedNonExisting;

		public RequiredFieldVisitorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;
			_sut = new RequiredFieldVisitor();
			_parsedFeedGood = GetParsedFeed(_visitorPathFixture.GoodFeedPath);
			_parsedFeedNonExisting = GetParsedFeed(_visitorPathFixture.NonExistingFeedPath);
		}

		private GtfsFeed GetParsedFeed(string feedPath)
		{
			GtfsFeed feed = new GtfsFeed();
			GtfsFeedParserVisitor parseVisitor = new GtfsFeedParserVisitor(feedPath);
			feed.Accept(parseVisitor);
			return parseVisitor.Feed;
		}

		//[Fact]
		//public void GoodFeedHasAllRequiredFields()
		//{
		//	_parsedFeedGood.Accept(_sut);

		//	Assert.True(_sut.IsValid);
		//}

		[Fact]
		public void GoodFeedHasValid()
		{
			List<bool> validFlags = new List<bool>();
			_sut.AgenciesChecked += (agencies, args) => validFlags.Add(args.IsValid);
			_sut.StopsChecked += (stops, args) => validFlags.Add(args.IsValid);
			_sut.RoutesChecked += (routes, args) => validFlags.Add(args.IsValid);
			_sut.TripsChecked += (trips, args) => validFlags.Add(args.IsValid);
			_sut.StopTimesChecked += (stopTimes, args) => validFlags.Add(args.IsValid);
			_sut.CalendarsChecked += (calendars, args) => validFlags.Add(args.IsValid);

			_parsedFeedGood.Accept(_sut);

			Assert.True(validFlags.All(flag => flag));
		}

		[Fact]
		public void EmptyFeedHasInvalidFields()
		{
			List<bool> validFlags = new List<bool>();
			_sut.AgenciesChecked += (agencies, args) => validFlags.Add(args.IsValid);
			_sut.StopsChecked += (stops, args) => validFlags.Add(args.IsValid);
			_sut.RoutesChecked += (routes, args) => validFlags.Add(args.IsValid);
			_sut.TripsChecked += (trips, args) => validFlags.Add(args.IsValid);
			_sut.StopTimesChecked += (stopTimes, args) => validFlags.Add(args.IsValid);
			_sut.CalendarsChecked += (calendars, args) => validFlags.Add(args.IsValid);

			_parsedFeedNonExisting.Accept(_sut);

			Assert.True(validFlags.Any(flag => flag == false));
		}
	}
}
