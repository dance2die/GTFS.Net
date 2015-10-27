using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet
{
	public class GtfsFeed
	{
		[Required]
		public HashSet<Agency> Agencies { get; set; } = new HashSet<Agency>();
		[Required]
		public HashSet<Stop> Stops { get; set; } = new HashSet<Stop>();
		[Required]
		public HashSet<Route> Routes { get; set; } = new HashSet<Route>();
		[Required]
		public HashSet<Trip> Trips { get; set; } = new HashSet<Trip>();
		[Required]
		public HashSet<StopTime> StopTimes { get; set; } = new HashSet<StopTime>();
		[Required]
		public HashSet<Calendar> Calendars { get; set; } = new HashSet<Calendar>();

		public HashSet<CalendarDate> CalendarDates { get; set; } = new HashSet<CalendarDate>();
		public HashSet<FareAttribute> FareAttributes { get; set; } = new HashSet<FareAttribute>();
		public HashSet<FareRule> FareRules { get; set; } = new HashSet<FareRule>();
		public HashSet<Shape> Shapes { get; set; } = new HashSet<Shape>();
		public HashSet<Frequency> Frequencies { get; set; } = new HashSet<Frequency>();
		public HashSet<Transfer> Transfers { get; set; } = new HashSet<Transfer>();
		public HashSet<FeedInfo> FeedInfos { get; set; } = new HashSet<FeedInfo>();
	}
}
