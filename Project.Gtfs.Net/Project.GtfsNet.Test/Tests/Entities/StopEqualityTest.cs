using GtfsNet.Entities;
using GtfsNet.Enums;
using Xunit;

namespace GtfsNet.Test.Tests.Entities
{
	public class StopEqualityTest
	{
		private readonly Stop _sut1;
		private readonly Stop _sut2;

		private const string TEXT_VALUE = "1";
		private const double DOUBLE_VALUE = 1.0D;
		private const LocationType LOCATION_TYPE = LocationType.Stop;

		public StopEqualityTest()
		{
			_sut1 = new Stop();
			_sut2 = new Stop();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.Id = TEXT_VALUE;
			_sut2.Id = TEXT_VALUE;

			_sut1.Code = TEXT_VALUE;
			_sut2.Code = TEXT_VALUE;

			_sut1.Name = TEXT_VALUE;
			_sut2.Name = TEXT_VALUE;

			_sut1.Description = TEXT_VALUE;
			_sut2.Description = TEXT_VALUE;

			_sut1.Latitude = DOUBLE_VALUE;
			_sut2.Latitude = DOUBLE_VALUE;

			_sut1.Longitude = DOUBLE_VALUE;
			_sut2.Longitude = DOUBLE_VALUE;

			_sut1.Zone = TEXT_VALUE;
			_sut2.Zone = TEXT_VALUE;

			_sut1.Url = TEXT_VALUE;
			_sut2.Url = TEXT_VALUE;

			_sut1.LocationType = LOCATION_TYPE;
			_sut2.LocationType = LOCATION_TYPE;

			_sut1.ParentStation = TEXT_VALUE;
			_sut2.ParentStation = TEXT_VALUE;

			_sut1.Timezone = TEXT_VALUE;
			_sut2.Timezone = TEXT_VALUE;

			_sut1.WheelchairBoarding = TEXT_VALUE;
			_sut2.WheelchairBoarding = TEXT_VALUE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.Id = TEXT_VALUE;
			_sut2.Id = TEXT_VALUE;

			_sut1.Code = TEXT_VALUE;
			_sut2.Code = TEXT_VALUE;

			_sut1.Name = TEXT_VALUE;
			_sut2.Name = TEXT_VALUE;

			_sut1.Description = TEXT_VALUE;
			_sut2.Description = TEXT_VALUE;

			_sut1.Latitude = DOUBLE_VALUE;
			_sut2.Latitude = DOUBLE_VALUE;

			_sut1.Longitude = DOUBLE_VALUE;
			_sut2.Longitude = DOUBLE_VALUE;

			_sut1.Zone = TEXT_VALUE;
			_sut2.Zone = TEXT_VALUE;

			_sut1.Url = TEXT_VALUE;
			_sut2.Url = TEXT_VALUE;

			_sut1.LocationType = LOCATION_TYPE;
			_sut2.LocationType = LOCATION_TYPE;

			_sut1.ParentStation = TEXT_VALUE;
			_sut2.ParentStation = TEXT_VALUE;

			_sut1.Timezone = TEXT_VALUE;
			_sut2.Timezone = TEXT_VALUE;

			_sut1.WheelchairBoarding = TEXT_VALUE;
			_sut2.WheelchairBoarding = "999";

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
