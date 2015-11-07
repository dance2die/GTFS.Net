using CsvHelper.Configuration;

namespace GtfsNet.Entities.Maps
{
	public class TransfersMap : CsvClassMap<Transfer>
	{
		public TransfersMap()
		{
			Map(e => e.FromStopId).Name("from_stop_id");
			Map(e => e.ToStopId).Name("to_stop_id");
			Map(e => e.TransferType).Name("transfer_type");
			Map(e => e.MinimumTransferTime).Name("min_transfer_time");
		}
	}
}
