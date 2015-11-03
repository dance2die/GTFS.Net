using System.Collections.Generic;
using System.Linq;
using Project.GtfsNet.Parsers;
using Project.GtfsNet.Test.Fixtures;
using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class GtfsFeedValidatorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;

		private readonly GtfsFeed _parsedFeedGood;
		private readonly GtfsFeed _parsedFeedNonExisting;

		private readonly GtfsFeedValidator _sut;

		public GtfsFeedValidatorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;

			_parsedFeedGood = new GtfsFeedParser().Parse(_visitorPathFixture.GoodFeedPath);
			_parsedFeedNonExisting = new GtfsFeedParser().Parse(_visitorPathFixture.NonExistingFeedPath);

			_sut = new GtfsFeedValidator();
		}

		[Fact]
		public void GoodFeedIsValid()
		{
			bool isValid = _sut.Validate(_parsedFeedGood);

			Assert.True(isValid);
		}
	}

	public class GtfsFeedValidator
	{
		private readonly RequiredFieldVisitor _fieldVisitor;
		private readonly RequiredFileVisitor _fileVisitor;

		public GtfsFeedValidator()
		{
			_fieldVisitor = new RequiredFieldVisitor();
			_fileVisitor = new RequiredFileVisitor();
		}

		public bool Validate(GtfsFeed feed)
		{
			bool isFileValid = ValidateFile(feed);
			bool areFieldsValid = ValidateFields(feed);

			return isFileValid && areFieldsValid;
		}

		private bool ValidateFile(GtfsFeed feed)
		{
			feed.Accept(_fileVisitor);
			return _fileVisitor.IsValid;
		}

		private bool ValidateFields(GtfsFeed feed)
		{
			List<bool> validFlags = new List<bool>();
			RequiredFieldVisitor requiredFieldVisitor = new RequiredFieldVisitor();
            requiredFieldVisitor.AgenciesChecked += (agencies, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.StopsChecked += (stops, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.RoutesChecked += (routes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.TripsChecked += (trips, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.StopTimesChecked += (stopTimes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.CalendarsChecked += (calendars, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.CalendarDatesChecked += (calendarDatess, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FareAttributesChecked += (fareAttributes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FareRulesChecked += (fareRules, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.ShapesChecked += (shapes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FrequenciesChecked += (frequencies, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.TransfersChecked += (transfers, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FeedInfosChecked += (feedInfos, args) => validFlags.Add(args.IsValid);

			feed.Accept(requiredFieldVisitor);

			return validFlags.All(flag => flag);
		}
	}
}
