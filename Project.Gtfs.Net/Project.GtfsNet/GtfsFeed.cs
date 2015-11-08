using System.ComponentModel.DataAnnotations;
using GtfsNet.Collections;
using GtfsNet.Visitors;

namespace GtfsNet
{
	public class GtfsFeed : IFeedElement
	{
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
