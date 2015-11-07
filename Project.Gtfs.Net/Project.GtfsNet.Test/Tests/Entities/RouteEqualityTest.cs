using GtfsNet.Entities;
using GtfsNet.Enums;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class RouteEqualityTest
	{
		private readonly Route _sut1;
		private readonly Route _sut2;

		private const string STRING_VALUE = "1";
		private const RouteType ROUTE_TYPE = RouteType.AdditionalRailService;

		public RouteEqualityTest()
		{
			_sut1 = new Route();
			_sut2 = new Route();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.Id = STRING_VALUE;
			_sut2.Id = STRING_VALUE;

			_sut1.AgencyId = STRING_VALUE;
			_sut2.AgencyId = STRING_VALUE;

			_sut1.ShortName = STRING_VALUE;
			_sut2.ShortName = STRING_VALUE;

			_sut1.LongName = STRING_VALUE;
			_sut2.LongName = STRING_VALUE;

			_sut1.Description = STRING_VALUE;
			_sut2.Description = STRING_VALUE;

			_sut1.Type = ROUTE_TYPE;
			_sut2.Type = ROUTE_TYPE;

			_sut1.Url = STRING_VALUE;
			_sut2.Url = STRING_VALUE;

			_sut1.Color = STRING_VALUE;
			_sut2.Color = STRING_VALUE;

			_sut1.TextColor = STRING_VALUE;
			_sut2.TextColor = STRING_VALUE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.Id = STRING_VALUE;
			_sut2.Id = STRING_VALUE;

			_sut1.AgencyId = STRING_VALUE;
			_sut2.AgencyId = STRING_VALUE;

			_sut1.ShortName = STRING_VALUE;
			_sut2.ShortName = STRING_VALUE;

			_sut1.LongName = STRING_VALUE;
			_sut2.LongName = STRING_VALUE;

			_sut1.Description = STRING_VALUE;
			_sut2.Description = STRING_VALUE;

			_sut1.Type = ROUTE_TYPE;
			_sut2.Type = ROUTE_TYPE;

			_sut1.Url = STRING_VALUE;
			_sut2.Url = STRING_VALUE;

			_sut1.Color = STRING_VALUE;
			_sut2.Color = STRING_VALUE;

			_sut1.TextColor = STRING_VALUE;
			_sut2.TextColor = "2";

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
