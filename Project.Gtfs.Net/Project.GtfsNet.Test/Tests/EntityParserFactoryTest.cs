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

			var parser = sut.Create("agency.txt");

			Assert.True(typeof (Agency).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (AgencyMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetCalendarParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create("calendar.txt");

			Assert.True(typeof (Calendar).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (CalendarMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetCalendarDatesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create("calendar_dates.txt");

			Assert.True(typeof (CalendarDates).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (CalendarDatesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}

		[Fact]
		public void GetFareAttributesParser()
		{
			var sut = new EntityParserFactory();

			var parser = sut.Create("fare_attributes.txt");

			Assert.True(typeof (FareAttributes).IsAssignableFrom(parser.GetType().GetGenericArguments()[0]));
			Assert.True(typeof (FareAttributesMap).IsAssignableFrom(parser.GetType().GetGenericArguments()[1]));
		}
	}
}
