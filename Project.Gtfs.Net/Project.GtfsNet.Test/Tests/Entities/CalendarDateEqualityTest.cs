using System;
using GtfsNet.Entities;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class CalendarDateEqualityTest
	{
		private readonly CalendarDate _sut1;
		private readonly CalendarDate _sut2;

		private const string SERVICE_ID = "1";
		private readonly DateTime _dateValue = DateTime.Now;

		public CalendarDateEqualityTest()
		{
			_sut1 = new CalendarDate();
			_sut2 = new CalendarDate();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.ServiceId = SERVICE_ID;
			_sut2.ServiceId = SERVICE_ID;

			_sut1.Date = _dateValue;
			_sut2.Date = _dateValue;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.ServiceId = SERVICE_ID;
			_sut2.ServiceId = SERVICE_ID;

			_sut1.Date = _dateValue;
			_sut2.Date = _dateValue.Add(new TimeSpan(1));

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
