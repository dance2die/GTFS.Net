using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet
{
	public class GtfsFeed
	{
		[Required]
		public HashSet<Agency> Agencies { get; } = new HashSet<Agency>();
		[Required]
		public HashSet<Stop> Stops { get; } = new HashSet<Stop>();
		[Required]
		public HashSet<Route> Routes { get; } = new HashSet<Route>();
		[Required]
		public HashSet<Trip> Trips { get; } = new HashSet<Trip>();
		[Required]
		public HashSet<StopTime> StopTimes { get; } = new HashSet<StopTime>();
		[Required]
		public HashSet<Calendar> Calendars { get; } = new HashSet<Calendar>();

		public HashSet<CalendarDate> CalendarDates { get; } = new HashSet<CalendarDate>();
		public HashSet<FareAttribute> FareAttributes { get; } = new HashSet<FareAttribute>();
		public HashSet<FareRule> FareRules { get; } = new HashSet<FareRule>();
		public HashSet<Shape> Shapes { get; } = new HashSet<Shape>();
		public HashSet<Frequency> Frequencies { get; } = new HashSet<Frequency>();
		public HashSet<Transfer> Transfers { get; } = new HashSet<Transfer>();
		public HashSet<FeedInfo> FeedInfos { get; } = new HashSet<FeedInfo>();
	}
}
