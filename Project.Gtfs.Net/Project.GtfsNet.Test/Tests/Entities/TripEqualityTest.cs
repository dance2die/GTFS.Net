using Project.GtfsNet.Entities;
using Project.GtfsNet.Enums;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class TripEqualityTest
	{
		private readonly Trip _sut1;
		private readonly Trip _sut2;

		private const string STRING_VALUE = "1";
		private const DirectionType DIRECTION_TYPE = DirectionType.TravelInOneDirection;
		private const WheelchairAccessibilityType WHEELCHAIR_ACCESSIBILITY_TYPE = WheelchairAccessibilityType.NoAccessibility;

		public TripEqualityTest()
		{
			_sut1 = new Trip();
			_sut2 = new Trip();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.Id = STRING_VALUE;
			_sut2.Id = STRING_VALUE;

			_sut1.RouteId = STRING_VALUE;
			_sut2.RouteId = STRING_VALUE;

			_sut1.ServiceId = STRING_VALUE;
			_sut2.ServiceId = STRING_VALUE;

			_sut1.Headsign = STRING_VALUE;
			_sut2.Headsign = STRING_VALUE;

			_sut1.ShortName = STRING_VALUE;
			_sut2.ShortName = STRING_VALUE;

			_sut1.DirectionId = DIRECTION_TYPE;
			_sut2.DirectionId = DIRECTION_TYPE;

			_sut1.BlockId = STRING_VALUE;
			_sut2.BlockId = STRING_VALUE;

			_sut1.ShapeId = STRING_VALUE;
			_sut2.ShapeId = STRING_VALUE;

			_sut1.WheelchairAccessibilityType = WHEELCHAIR_ACCESSIBILITY_TYPE;
			_sut2.WheelchairAccessibilityType = WHEELCHAIR_ACCESSIBILITY_TYPE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.Id = "222";
			_sut2.Id = STRING_VALUE;

			_sut1.RouteId = STRING_VALUE;
			_sut2.RouteId = STRING_VALUE;

			_sut1.ServiceId = STRING_VALUE;
			_sut2.ServiceId = STRING_VALUE;

			_sut1.Headsign = STRING_VALUE;
			_sut2.Headsign = STRING_VALUE;

			_sut1.ShortName = STRING_VALUE;
			_sut2.ShortName = STRING_VALUE;

			_sut1.DirectionId = DIRECTION_TYPE;
			_sut2.DirectionId = DIRECTION_TYPE;

			_sut1.BlockId = STRING_VALUE;
			_sut2.BlockId = STRING_VALUE;

			_sut1.ShapeId = STRING_VALUE;
			_sut2.ShapeId = STRING_VALUE;

			_sut1.WheelchairAccessibilityType = WHEELCHAIR_ACCESSIBILITY_TYPE;
			_sut2.WheelchairAccessibilityType = WHEELCHAIR_ACCESSIBILITY_TYPE;

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
    }
}
