using System.Collections;
using System.Collections.Generic;
using Project.GtfsNet.Collections;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Visitors
{
	/// <summary>
	/// Check if all required files have any record in GTFS feed
	/// </summary>
	public class RequiredFileVisitor : IFeedVisitor
	{
		/// <summary>
		/// Check if visited feed is valid (when all requiref files are parsed and not empty
		/// </summary>
		public bool IsValid { get; private set; } = true;

		public List<string> UnparsedFiles { get; private set; } = new List<string>();

		///// <summary>
		///// Required file names.
		///// Reference: <see cref="https://developers.google.com/transit/gtfs/reference#feed-files"/>
		///// </summary>
		//public List<string> RequiredFiles { get; } = new List<string>
		//{
		//	SupportedFileNames.Agency,
		//	SupportedFileNames.Stops,
		//	SupportedFileNames.Routes,
		//	SupportedFileNames.Trips,
		//	SupportedFileNames.StopTimes,
		//	SupportedFileNames.Calendar,
		//};

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
			//if (!IsValid) return;

			//IsValid = calendars.Count >= 1;
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