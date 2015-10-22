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
	}
}
