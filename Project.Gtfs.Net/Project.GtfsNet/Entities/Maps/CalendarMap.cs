using System;
using System.Globalization;
using CsvHelper.Configuration;

namespace Project.GtfsNet.Entities.Maps
{
	public class CalendarMap : CsvClassMap<Calendar>
	{
		public CalendarMap()
		{
			Map(e => e.ServiceId).Name("service_id");
			Map(e => e.Monday).Name("monday");
			Map(e => e.Tuesday).Name("tuesday");
			Map(e => e.Wednesday).Name("wednesday");
			Map(e => e.Thursday).Name("thursday");
			Map(e => e.Friday).Name("friday");
			Map(e => e.Saturday).Name("saturday");
			Map(e => e.Sunday).Name("sunday");
			Map(e => e.StartDate).Name("start_date").ConvertUsing(row =>
			{
				string dateTimeText = row.GetField<string>("start_date");
				return ParseDateTime(dateTimeText);
			});
			Map(e => e.EndDate).Name("end_date").ConvertUsing(row =>
			{
				string dateTimeText = row.GetField<string>("end_date");
				return ParseDateTime(dateTimeText);
			});
		}

		private DateTime ParseDateTime(string dateTimeText)
		{
			// This is format specified in GTFS specification
			// https://developers.google.com/transit/gtfs/reference?hl=en#calendartxt
			const string gtfsDateFormat = "yyyyMMdd";

			// http://stackoverflow.com/a/4720481/4035
			return DateTime.ParseExact(dateTimeText, gtfsDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
		}
	}
}
