using Project.GtfsNet.Entities;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class FrequencyEqualityTest
	{
		private readonly Frequency _sut1;
		private readonly Frequency _sut2;

		private const string STRING_VALUE = "1";
		private const bool EXACT_TIMES = true;

		public FrequencyEqualityTest()
		{
			_sut1 = new Frequency();
			_sut2 = new Frequency();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.TripId = STRING_VALUE;
			_sut2.TripId = STRING_VALUE;

			_sut1.StartTime = STRING_VALUE;
			_sut2.StartTime = STRING_VALUE;

			_sut1.EndTime = STRING_VALUE;
			_sut2.EndTime = STRING_VALUE;

			_sut1.HeadwaySecs = STRING_VALUE;
			_sut2.HeadwaySecs = STRING_VALUE;

			_sut1.ExactTimes = EXACT_TIMES;
			_sut2.ExactTimes = EXACT_TIMES;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.TripId = STRING_VALUE;
			_sut2.TripId = STRING_VALUE;

			_sut1.StartTime = STRING_VALUE;
			_sut2.StartTime = STRING_VALUE;

			_sut1.EndTime = STRING_VALUE;
			_sut2.EndTime = STRING_VALUE;

			_sut1.HeadwaySecs = STRING_VALUE;
			_sut2.HeadwaySecs = STRING_VALUE;

			_sut1.ExactTimes = EXACT_TIMES;
			_sut2.ExactTimes = false;

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
