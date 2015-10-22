using CsvHelper.Configuration;

namespace Project.GtfsNet.Entities.Maps
{
	public class FareAttributesMap : CsvClassMap<FareAttributes>
	{
		public FareAttributesMap()
		{
			Map(e => e.FareId).Name("fare_id");
			Map(e => e.Price).Name("price");
			Map(e => e.CurrencyType).Name("currency_type");
			Map(e => e.PaymentMethod).Name("payment_method");
			Map(e => e.Transfers).Name("transfers");
			Map(e => e.TransferDuration).Name("transfer_duration");
		}
	}
}