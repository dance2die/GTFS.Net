using Project.GtfsNet.Entities;
using Project.GtfsNet.Enums;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class FareAttributeEqualityTest
	{
		private readonly FareAttribute _sut1;
		private readonly FareAttribute _sut2;

		private const string FARE_ID = "1";
		private const string PRICE = "1.00";
		private const string CURRENCY_TYPE = "USD";
		private const PaymentMethodType PAYMENT_METHOD_TYPE = PaymentMethodType.OnBoard;
		private const int TRANSFERS = 1;
		private const string TRANSFER_DURATION = "none";

		public FareAttributeEqualityTest()
		{
			_sut1 = new FareAttribute();
			_sut2 = new FareAttribute();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.FareId = FARE_ID;
			_sut2.FareId = FARE_ID;

			_sut1.Price = PRICE;
			_sut2.Price = PRICE;

			_sut1.CurrencyType = CURRENCY_TYPE;
			_sut2.CurrencyType = CURRENCY_TYPE;

			_sut1.PaymentMethod = PAYMENT_METHOD_TYPE;
			_sut2.PaymentMethod = PAYMENT_METHOD_TYPE;

			_sut1.Transfers = TRANSFERS;
			_sut2.Transfers = TRANSFERS;

			_sut1.TransferDuration = TRANSFER_DURATION;
			_sut2.TransferDuration = TRANSFER_DURATION;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.FareId = FARE_ID;
			_sut2.FareId = "2";

			_sut1.Price = PRICE;
			_sut2.Price = PRICE;

			_sut1.CurrencyType = CURRENCY_TYPE;
			_sut2.CurrencyType = CURRENCY_TYPE;

			_sut1.PaymentMethod = PAYMENT_METHOD_TYPE;
			_sut2.PaymentMethod = PAYMENT_METHOD_TYPE;

			_sut1.Transfers = TRANSFERS;
			_sut2.Transfers = TRANSFERS;

			_sut1.TransferDuration = TRANSFER_DURATION;
			_sut2.TransferDuration = TRANSFER_DURATION;

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
