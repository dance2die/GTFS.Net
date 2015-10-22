using System;
using System.IO;
using EnsureThat;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;

namespace Project.GtfsNet.Parsers
{
	public class EntityParserFactory
	{
		public IEntityParser<IEntity> Create(string filePath)
		{
			Ensure.That(filePath).IsNotNullOrWhiteSpace();

			string fileName = Path.GetFileName(filePath);
			switch (fileName)
			{
				case SupportedFileNames.Agency:
					return new EntityParser<Agency, AgencyMap>();
				case SupportedFileNames.Calendar:
					return new EntityParser<Calendar, CalendarMap>();
				case SupportedFileNames.CalendarDates:
					return new EntityParser<CalendarDates, CalendarDatesMap>();
				case SupportedFileNames.FareAttributes:
					return new EntityParser<FareAttributes, FareAttributesMap>();
				case SupportedFileNames.FareRules:
					return new EntityParser<FareRules, FareRulesMap>();
				case SupportedFileNames.FeedInfo:
					return new EntityParser<FeedInfo, FeedInfoMap>();
				case SupportedFileNames.Frequencies:
					return new EntityParser<Frequencies, FrequenciesMap>();
				case SupportedFileNames.Routes:
					return new EntityParser<Routes, RoutesMap>();
				case SupportedFileNames.Shapes:
					return new EntityParser<Shapes, ShapesMap>();
				case SupportedFileNames.StopTimes:
					return new EntityParser<StopTimes, StopTimesMap>();
				case SupportedFileNames.Stops:
					return new EntityParser<Stops, StopsMap>();
				case SupportedFileNames.Transfers:
					return new EntityParser<Transfers, TransfersMap>();
				case SupportedFileNames.Trips:
					return new EntityParser<Trips, TripsMap>();
				default:
					throw new ArgumentException();
			}
		}

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
		}
	}
}