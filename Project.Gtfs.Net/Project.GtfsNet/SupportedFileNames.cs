using System;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet
{
	public static class SupportedFileNames
	{
		public const string Agency = "agency.txt";
		public const string Calendar = "calendar.txt";
		public const string CalendarDates = "calendar_dates.txt";
		public const string FareAttributes = "fare_attributes.txt";
		public const string FareRules = "fare_rules.txt";
		public const string FeedInfo = "feed_info.txt";
		public const string Frequencies = "frequencies.txt";
		public const string Routes = "routes.txt";
		public const string Shapes = "shapes.txt";
		public const string StopTimes = "stop_times.txt";
		public const string Stops = "stops.txt";
		public const string Transfers = "transfers.txt";
		public const string Trips = "trips.txt";

		public static string GetFileNameByType<T>()
		{
			if (typeof(T) == typeof(Agency))
				return Agency;

			if (typeof(T) == typeof(Calendar))
				return Calendar;

			if (typeof(T) == typeof(CalendarDate))
				return CalendarDates;

			if (typeof(T) == typeof(FareAttribute))
				return FareAttributes;

			if (typeof(T) == typeof(FareRule))
				return FareRules;

			if (typeof(T) == typeof(FeedInfo))
				return FeedInfo;

			if (typeof(T) == typeof(Frequency))
				return Frequencies;

			if (typeof(T) == typeof(Route))
				return Routes;

			if (typeof(T) == typeof(Shape))
				return Shapes;

			if (typeof(T) == typeof(StopTime))
				return StopTimes;

			if (typeof(T) == typeof(Stop))
				return Stops;

			if (typeof(T) == typeof(Transfer))
				return Transfers;

			if (typeof(T) == typeof(Trip))
				return Trips;

			throw new NotSupportedException(string.Format("Type, \"{0}\" is not supported", typeof(T).Name));
		}
	}

}
