using Project.GtfsNet.Entities;
using Project.GtfsNet.Enums;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class TransferEqualityTest
	{
		private readonly Transfer _sut1;
		private readonly Transfer _sut2;

		private const string STRING_VALUE = "1";
		private const TransferType TRANSFER_TYPE = TransferType.MinimumTime;

		public TransferEqualityTest()
		{
			_sut1 = new Transfer();
			_sut2 = new Transfer();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.FromStopId = STRING_VALUE;
			_sut2.FromStopId = STRING_VALUE;

			_sut1.ToStopId = STRING_VALUE;
			_sut2.ToStopId = STRING_VALUE;

			_sut1.TransferType = TRANSFER_TYPE;
			_sut2.TransferType = TRANSFER_TYPE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.FromStopId = STRING_VALUE;
			_sut2.FromStopId = STRING_VALUE;

			_sut1.ToStopId = STRING_VALUE;
			_sut2.ToStopId = "999";

			_sut1.TransferType = TRANSFER_TYPE;
			_sut2.TransferType = TRANSFER_TYPE;

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
    }
}
