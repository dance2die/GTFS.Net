﻿using CsvHelper.Configuration;
using Project.GtfsNet.Parsers;

namespace Project.GtfsNet.Entities.Maps
{
	public class CalendarDatesMap : CsvClassMap<CalendarDates>
	{
		public CalendarDatesMap()
		{
			Map(e => e.ServiceId).Name("service_id");
			Map(e => e.Date).Name("date").ConvertUsing(row =>
			{
				DateTimeParser dateTimeParser = new DateTimeParser();
				string dateTimeText = row.GetField<string>("date");
				return dateTimeParser.Parse(dateTimeText);
			});
			Map(e => e.ExceptionType).Name("exception_type");
		}
	}
}
