using System.Collections.Generic;
using Project.GtfsNet.Collections;

namespace Project.GtfsNet.Visitors
{
	/// <summary>
	/// Validates GTFS Feed
	/// </summary>
	public class RequiredFileVisitor : IFeedVisitor
	{
		/// <summary>
		/// Check if visited feed is valid (when all requiref files are parsed and not empty
		/// </summary>
		public bool IsValid { get; private set; } = true;

		/// <summary>
		/// Required file names.
		/// Reference: <see cref="https://developers.google.com/transit/gtfs/reference#feed-files"/>
		/// </summary>
		public List<string> RequiredFiles { get; } = new List<string>
		{
			SupportedFileNames.Agency,
			SupportedFileNames.Stops,
			SupportedFileNames.Routes,
			SupportedFileNames.Trips,
			SupportedFileNames.StopTimes,
			SupportedFileNames.Calendar,
		};

		public void Visit(AgencyCollection agencies)
		{
			IsValid = agencies.Count >= 1;
		}

		public void Visit(StopCollection stops)
		{
			IsValid = stops.Count >= 1;
		}

		public void Visit(RouteCollection routes)
		{
			IsValid = routes.Count >= 1;
		}

		public void Visit(TripCollection trips)
		{
			IsValid = trips.Count >= 1;
		}

		public void Visit(StopTimeCollection stopTimes)
		{
			IsValid = stopTimes.Count >= 1;
		}

		public void Visit(CalendarCollection calendars)
		{
			IsValid = calendars.Count >= 1;
		}

		public void Visit(CalendarDateCollection calendarDates)
		{
			
		}

		public void Visit(FareAttributeCollection fareAttributes)
		{
			
		}

		public void Visit(FareRuleCollection fareRules)
		{
			
		}

		public void Visit(ShapeCollection shapes)
		{
			
		}

		public void Visit(FrequencyCollection frequencies)
		{
			
		}

		public void Visit(TransferCollection transfers)
		{
			
		}

		public void Visit(FeedInfoCollection feedInfos)
		{
			
		}
	}
}