using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
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

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Agency);

			Assert.True(typeof (Agency).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (AgencyMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetCalendarParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Calendar);

			Assert.True(typeof (Calendar).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (CalendarMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetCalendarDatesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.CalendarDates);

			Assert.True(typeof (CalendarDates).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (CalendarDatesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFareAttributesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.FareAttributes);

			Assert.True(typeof (FareAttributes).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FareAttributesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFareRulesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.FareRules);

			Assert.True(typeof (FareRules).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FareRulesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFeedInfoParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.FeedInfo);

			Assert.True(typeof (FeedInfo).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FeedInfoMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFrequenciesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Frequencies);

			Assert.True(typeof (Frequencies).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FrequenciesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetRoutesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Routes);

			Assert.True(typeof (Routes).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (RoutesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetShapesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Shapes);

			Assert.True(typeof (Shapes).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (ShapesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetStopTimesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.StopTimes);

			Assert.True(typeof (StopTimes).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (StopTimesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetStopsParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Stops);

			Assert.True(typeof (Stops).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (StopsMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetTransfersParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Transfers);

			Assert.True(typeof (Transfers).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (TransfersMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetTripsParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create(EntityParserFactory.SupportedFileNames.Trips);

			Assert.True(typeof (Trips).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (TripsMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}
	}
}
