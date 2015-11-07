using System;
using GtfsNet.Entities;
using Xunit;

namespace GtfsNet.Test.Tests.Entities
{
	public class CalendarEqualityTest
	{
		private readonly Calendar _sut1;
		private readonly Calendar _sut2;

		private const string SERVICE_ID = "1";
		private const bool DAY_VALUE = true;
		private readonly DateTime _dateValue = DateTime.Now;

		public CalendarEqualityTest()
		{
			_sut1 = new Calendar();
			_sut2 = new Calendar();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.ServiceId = SERVICE_ID;
			_sut2.ServiceId = SERVICE_ID;

			_sut1.Monday = DAY_VALUE;
			_sut2.Monday = DAY_VALUE;

			_sut1.Tuesday = DAY_VALUE;
			_sut2.Tuesday = DAY_VALUE;

			_sut1.Wednesday = DAY_VALUE;
			_sut2.Wednesday = DAY_VALUE;

			_sut1.Thursday = DAY_VALUE;
			_sut2.Thursday = DAY_VALUE;

			_sut1.Friday = DAY_VALUE;
			_sut2.Friday = DAY_VALUE;

			_sut1.Saturday = DAY_VALUE;
			_sut2.Saturday = DAY_VALUE;

			_sut1.Sunday = DAY_VALUE;
			_sut2.Sunday = DAY_VALUE;

			_sut1.StartDate = _dateValue;
			_sut2.StartDate = _dateValue;

			_sut1.EndDate = _dateValue;
			_sut2.EndDate = _dateValue;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.ServiceId = SERVICE_ID;
			_sut2.ServiceId = SERVICE_ID;

			_sut1.Monday = DAY_VALUE;
			_sut2.Monday = DAY_VALUE;

			_sut1.Tuesday = DAY_VALUE;
			_sut2.Tuesday = DAY_VALUE;

			_sut1.Wednesday = DAY_VALUE;
			_sut2.Wednesday = DAY_VALUE;

			_sut1.Thursday = DAY_VALUE;
			_sut2.Thursday = DAY_VALUE;

			_sut1.Friday = DAY_VALUE;
			_sut2.Friday = DAY_VALUE;

			_sut1.Saturday = DAY_VALUE;
			_sut2.Saturday = DAY_VALUE;

			_sut1.Sunday = DAY_VALUE;
			_sut2.Sunday = DAY_VALUE;

			_sut1.StartDate = _dateValue;
			_sut2.StartDate = _dateValue;

			_sut1.EndDate = _dateValue;
			_sut2.EndDate = _dateValue.Add(new TimeSpan(1));

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
