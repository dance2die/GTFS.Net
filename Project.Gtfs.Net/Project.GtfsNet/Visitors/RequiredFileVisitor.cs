using System.Collections.Generic;
using GtfsNet.Collections;
using GtfsNet.Entities;

namespace GtfsNet.Visitors
{
	/// <summary>
	/// Check if all required files have any record in GTFS feed
	/// 
	/// There are 6 required files
	/// 1.) agency.txt
	/// 2.) stops.txt
	/// 3.) routes.txt
	/// 4.) trips.txt
	/// 5.) stop_times.txt
	/// 6.) calendar.txt
	/// </summary>
	public class RequiredFileVisitor : IFeedVisitor
	{
		/// <summary>
		/// Check if visited feed is valid (when all requiref files are parsed and not empty
		/// </summary>
		public bool IsValid { get; private set; } = true;

		public List<string> UnparsedFiles { get; } = new List<string>();

		private void SetValidity<T>(HashSet<T> collection) where T : Entity
		{
			if (collection.Count > 0 && IsValid)
			{
				IsValid = collection.Count >= 1;
			}
			else
			{
				UnparsedFiles.Add(SupportedFileNames.GetFileNameByType<T>());
				IsValid = false;
			}
		}

		public void Visit(AgencyCollection agencies)
		{
			SetValidity(agencies);
		}

		public void Visit(StopCollection stops)
		{
			SetValidity(stops);
		}

		public void Visit(RouteCollection routes)
		{
			SetValidity(routes);
		}

		public void Visit(TripCollection trips)
		{
			SetValidity(trips);
		}

		public void Visit(StopTimeCollection stopTimes)
		{
			SetValidity(stopTimes);
		}

		public void Visit(CalendarCollection calendars)
		{
			SetValidity(calendars);
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