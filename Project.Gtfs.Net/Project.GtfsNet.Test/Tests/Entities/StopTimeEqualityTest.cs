using GtfsNet.Entities;
using GtfsNet.Enums;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class StopTimeEqualityTest
	{
		private readonly StopTime _sut1;
		private readonly StopTime _sut2;

		private const string STRING_VALUE = "1";
		private const int INT_VALUE = 1;
		private const PickupType PICKUP_TYPE = PickupType.DriverForPickup;
		private const DropOffType DROP_OFF_TYPE = DropOffType.DriverForPickup;

		public StopTimeEqualityTest()
		{
			_sut1 = new StopTime();
			_sut2 = new StopTime();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.TripId = STRING_VALUE;
			_sut2.TripId = STRING_VALUE;

			_sut1.ArrivalTime = STRING_VALUE;
			_sut2.ArrivalTime = STRING_VALUE;

			_sut1.DepartureTime = STRING_VALUE;
			_sut2.DepartureTime = STRING_VALUE;

			_sut1.StopId = STRING_VALUE;
			_sut2.StopId = STRING_VALUE;

			_sut1.StopSequence = INT_VALUE;
			_sut2.StopSequence = INT_VALUE;

			_sut1.StopHeadsign = STRING_VALUE;
			_sut2.StopHeadsign = STRING_VALUE;

			_sut1.PickupType = PICKUP_TYPE;
			_sut2.PickupType = PICKUP_TYPE;

			_sut1.DropOffType = DROP_OFF_TYPE;
			_sut2.DropOffType = DROP_OFF_TYPE;

			_sut1.ShapeDistTravelled = STRING_VALUE;
			_sut2.ShapeDistTravelled = STRING_VALUE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.TripId = STRING_VALUE;
			_sut2.TripId = STRING_VALUE;

			_sut1.ArrivalTime = STRING_VALUE;
			_sut2.ArrivalTime = STRING_VALUE;

			_sut1.DepartureTime = STRING_VALUE;
			_sut2.DepartureTime = STRING_VALUE;

			_sut1.StopId = STRING_VALUE;
			_sut2.StopId = STRING_VALUE;

			_sut1.StopSequence = INT_VALUE;
			_sut2.StopSequence = INT_VALUE;

			_sut1.StopHeadsign = STRING_VALUE;
			_sut2.StopHeadsign = STRING_VALUE;

			_sut1.PickupType = PICKUP_TYPE;
			_sut2.PickupType = PICKUP_TYPE;

			_sut1.DropOffType = DROP_OFF_TYPE;
			_sut2.DropOffType = DROP_OFF_TYPE;

			_sut1.ShapeDistTravelled = STRING_VALUE;
			_sut2.ShapeDistTravelled = "99999";

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
