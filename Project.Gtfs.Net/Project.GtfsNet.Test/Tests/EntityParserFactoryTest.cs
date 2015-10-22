using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			//var sut = new EntityParserFactory();

			//var parser = sut.Create("agency.txt");
		}
	}

	//public class EntityParserFactory
	//{
	//	public EntityParser<TEntity, TEntityMap> Create(string fileName)
	//	{
	//		if (fileName == "agency.txt")
	//		{
	//			return new EntityParser<Agency, AgencyMap>();
	//		}
	//	}
	//}
}
