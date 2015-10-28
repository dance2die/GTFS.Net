using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Collections;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet
{
	public class GtfsFeed : IFeedElement
	{
		//[Required]
		//public HashSet<Agency> Agencies { get; set; } = new HashSet<Agency>();
		//[Required]
		//public HashSet<Stop> Stops { get; set; } = new HashSet<Stop>();
		//[Required]
		//public HashSet<Route> Routes { get; set; } = new HashSet<Route>();
		//[Required]
		//public HashSet<Trip> Trips { get; set; } = new HashSet<Trip>();
		//[Required]
		//public HashSet<StopTime> StopTimes { get; set; } = new HashSet<StopTime>();
		//[Required]
		//public HashSet<Calendar> Calendars { get; set; } = new HashSet<Calendar>();

		//public HashSet<CalendarDate> CalendarDates { get; set; } = new HashSet<CalendarDate>();
		//public HashSet<FareAttribute> FareAttributes { get; set; } = new HashSet<FareAttribute>();
		//public HashSet<FareRule> FareRules { get; set; } = new HashSet<FareRule>();
		//public HashSet<Shape> Shapes { get; set; } = new HashSet<Shape>();
		//public HashSet<Frequency> Frequencies { get; set; } = new HashSet<Frequency>();
		//public HashSet<Transfer> Transfers { get; set; } = new HashSet<Transfer>();
		//public HashSet<FeedInfo> FeedInfos { get; set; } = new HashSet<FeedInfo>();

		[Required]
		public AgencyCollection Agencies { get; set; } = new AgencyCollection();
		[Required]
		public StopCollection Stops { get; set; } = new StopCollection();
		[Required]
		public RouteCollection Routes { get; set; } = new RouteCollection();
		[Required]
		public TripCollection Trips { get; set; } = new TripCollection();
		[Required]
		public StopTimeCollection StopTimes { get; set; } = new StopTimeCollection();
		[Required]
		public CalendarCollection Calendars { get; set; } = new CalendarCollection();

		public CalendarDateCollection CalendarDates { get; set; } = new CalendarDateCollection();
		public FareAttributeCollection FareAttributes { get; set; } = new FareAttributeCollection();
		public FareRuleCollection FareRules { get; set; } = new FareRuleCollection();
		public ShapeCollection Shapes { get; set; } = new ShapeCollection();
		public FrequencyCollection Frequencies { get; set; } = new FrequencyCollection();
		public TransferCollection Transfers { get; set; } = new TransferCollection();
		public FeedInfoCollection FeedInfos { get; set; } = new FeedInfoCollection();

		public void Accept(IFeedVisitor visitor)
		{
			Agencies.Accept(visitor);
			Stops.Accept(visitor);
			Routes.Accept(visitor);
			Trips.Accept(visitor);
			StopTimes.Accept(visitor);
			Calendars.Accept(visitor);
			CalendarDates.Accept(visitor);
			FareAttributes.Accept(visitor);
			FareRules.Accept(visitor);
			Shapes.Accept(visitor);
			Frequencies.Accept(visitor);
			Transfers.Accept(visitor);
			FeedInfos.Accept(visitor);
		}
	}
}
