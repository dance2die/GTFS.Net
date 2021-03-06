﻿using CsvHelper.Configuration;

namespace GtfsNet.Entities.Maps
{
	public class FrequenciesMap : CsvClassMap<Frequency>
	{
		public FrequenciesMap()
		{
			Map(e => e.TripId).Name("trip_id");
			Map(e => e.StartTime).Name("start_time");
			Map(e => e.EndTime).Name("end_time");
			Map(e => e.HeadwaySecs).Name("headway_secs");
			Map(e => e.ExactTimes).Name("exact_times");
		}
	}
}
