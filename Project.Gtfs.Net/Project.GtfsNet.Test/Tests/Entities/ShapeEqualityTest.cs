using GtfsNet.Entities;
using Xunit;

namespace GtfsNet.Test.Tests.Entities
{
	public class ShapeEqualityTest
	{
		private readonly Shape _sut1;
		private readonly Shape _sut2;

		private const string ID = "1";
		private const double LATITUDE = 1D;
		private const double LONGITUDE = 2D;
		private const int SEQUENCE = 1;
		private const double DISTANCE = 3D;

		public ShapeEqualityTest()
		{
			_sut1 = new Shape();
			_sut2 = new Shape();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.Id = ID;
			_sut2.Id = ID;

			_sut1.Latitude = LATITUDE;
			_sut2.Latitude = LATITUDE;

			_sut1.Longitude = LONGITUDE;
			_sut2.Longitude = LONGITUDE;

			_sut1.Sequence = SEQUENCE;
			_sut2.Sequence = SEQUENCE;

			_sut1.DistanceTraveled = DISTANCE;
			_sut2.DistanceTraveled = DISTANCE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.Id = ID;
			_sut2.Id = ID;

			_sut1.Latitude = LATITUDE;
			_sut2.Latitude = LATITUDE;

			_sut1.Longitude = LONGITUDE;
			_sut2.Longitude = LONGITUDE;

			_sut1.Sequence = SEQUENCE;
			_sut2.Sequence = 999;

			_sut1.DistanceTraveled = DISTANCE;
			_sut2.DistanceTraveled = DISTANCE;

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
