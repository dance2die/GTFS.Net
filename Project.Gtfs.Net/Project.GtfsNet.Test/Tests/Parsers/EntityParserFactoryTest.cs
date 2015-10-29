using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public class EntityParserFactoryTest
	{
		private readonly ITestOutputHelper _output;

		public EntityParserFactoryTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void GetAgencyParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Agency);

			Assert.True(typeof (Agency).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (AgencyMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetCalendarParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Calendar);

			Assert.True(typeof (Calendar).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (CalendarMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetCalendarDatesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.CalendarDates);

			Assert.True(typeof (CalendarDate).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (CalendarDatesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFareAttributesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.FareAttributes);

			Assert.True(typeof (FareAttribute).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FareAttributesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFareRulesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.FareRules);

			Assert.True(typeof (FareRule).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FareRulesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFeedInfoParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.FeedInfo);

			Assert.True(typeof (FeedInfo).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FeedInfoMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFrequenciesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Frequencies);

			Assert.True(typeof (Frequency).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FrequenciesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetRoutesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Routes);

			Assert.True(typeof (Route).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (RoutesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetShapesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Shapes);

			Assert.True(typeof (Shape).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (ShapesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetStopTimesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.StopTimes);

			Assert.True(typeof (StopTime).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (StopTimesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetStopsParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Stops);

			Assert.True(typeof (Stop).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (StopsMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetTransfersParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Transfers);

			Assert.True(typeof (Transfer).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (TransfersMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetTripsParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(SupportedFileNames.Trips);

			Assert.True(typeof (Trip).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (TripsMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}
	}
}
