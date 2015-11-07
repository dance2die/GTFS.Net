using GtfsNet.Entities;
using Xunit;

namespace GtfsNet.Test.Tests.Entities
{
	public class FareRuleEqualityTest
	{
		private readonly FareRule _sut1;
		private readonly FareRule _sut2;

		private const string ID = "1";

		public FareRuleEqualityTest()
		{
			_sut1 = new FareRule();
			_sut2 = new FareRule();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.FareId = ID;
			_sut2.FareId = ID;

			_sut1.RouteId = ID;
			_sut2.RouteId = ID;

			_sut1.OriginId = ID;
			_sut2.OriginId = ID;

			_sut1.DestinationId = ID;
			_sut2.DestinationId = ID;

			_sut1.ContainsId = ID;
			_sut2.ContainsId = ID;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.FareId = ID;
			_sut2.FareId = ID;

			_sut1.RouteId = ID;
			_sut2.RouteId = ID;

			_sut1.OriginId = ID;
			_sut2.OriginId = ID;

			_sut1.DestinationId = ID;
			_sut2.DestinationId = ID;

			_sut1.ContainsId = ID;
			_sut2.ContainsId = "2";

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
