using CsvHelper.Configuration;
using GtfsNet.Parsers;

namespace GtfsNet.Entities.Maps
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

			DateTimeParser dateTimeParser = new DateTimeParser();

			Map(e => e.StartDate).Name("start_date").ConvertUsing(row =>
			{
				string dateTimeText = row.GetField<string>("start_date");
				return dateTimeParser.Parse(dateTimeText);
			});
			Map(e => e.EndDate).Name("end_date").ConvertUsing(row =>
			{
				string dateTimeText = row.GetField<string>("end_date");
				return dateTimeParser.Parse(dateTimeText);
			});
		}
	}
}
