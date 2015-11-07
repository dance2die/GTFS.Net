using System;
using System.Globalization;

namespace GtfsNet.Parsers
{
	public class DateTimeParser
	{
		public DateTime Parse(string dateTimeText)
		{
			// This is format specified in GTFS specification
			// https://developers.google.com/transit/gtfs/reference?hl=en#calendartxt
			const string gtfsDateFormat = "yyyyMMdd";

			// http://stackoverflow.com/a/4720481/4035
			return DateTime.ParseExact(dateTimeText, gtfsDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None);
		}
	}
}
