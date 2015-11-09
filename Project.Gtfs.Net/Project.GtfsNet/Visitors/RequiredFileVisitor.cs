using System.Collections.Generic;
using System.Threading.Tasks;
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

		private async Task SetValidityAsync<T>(HashSet<T> collection) where T : Entity
		{
			await Task.Run(() => SetValidity(collection));
		}

		public async void Visit(AgencyCollection agencies)
		{
			await SetValidityAsync(agencies);
		}

		public async void Visit(StopCollection stops)
		{
			await SetValidityAsync(stops);
		}

		public async void Visit(RouteCollection routes)
		{
			await SetValidityAsync(routes);
		}

		public async void Visit(TripCollection trips)
		{
			await SetValidityAsync(trips);
		}

		public async void Visit(StopTimeCollection stopTimes)
		{
			await SetValidityAsync(stopTimes);
		}

		public async void Visit(CalendarCollection calendars)
		{
			await SetValidityAsync(calendars);
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