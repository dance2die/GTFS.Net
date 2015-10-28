using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Entities;

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

	public class AgencyCollection : HashSet<Agency>, IFeedElement
	{
		public AgencyCollection()
		{
		}

		public AgencyCollection(IEnumerable<Agency> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class StopCollection : HashSet<Stop>, IFeedElement
	{
		public StopCollection()
		{
		}

		public StopCollection(IEnumerable<Stop> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class RouteCollection : HashSet<Route>, IFeedElement
	{
		public RouteCollection()
		{
		}

		public RouteCollection(IEnumerable<Route> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class TripCollection : HashSet<Trip>, IFeedElement
	{
		public TripCollection()
		{
		}

		public TripCollection(IEnumerable<Trip> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class StopTimeCollection : HashSet<StopTime>, IFeedElement
	{
		public StopTimeCollection()
		{
		}

		public StopTimeCollection(IEnumerable<StopTime> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class CalendarCollection : HashSet<Calendar>, IFeedElement
	{
		public CalendarCollection()
		{
		}

		public CalendarCollection(IEnumerable<Calendar> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class CalendarDateCollection : HashSet<CalendarDate>, IFeedElement
	{
		public CalendarDateCollection()
		{
		}

		public CalendarDateCollection(IEnumerable<CalendarDate> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class FareAttributeCollection : HashSet<FareAttribute>, IFeedElement
	{
		public FareAttributeCollection()
		{
		}

		public FareAttributeCollection(IEnumerable<FareAttribute> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class FareRuleCollection : HashSet<FareRule>, IFeedElement
	{
		public FareRuleCollection()
		{
		}

		public FareRuleCollection(IEnumerable<FareRule> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class ShapeCollection : HashSet<Shape>, IFeedElement
	{
		public ShapeCollection()
		{
		}

		public ShapeCollection(IEnumerable<Shape> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class FrequencyCollection : HashSet<Frequency>, IFeedElement
	{
		public FrequencyCollection()
		{
		}

		public FrequencyCollection(IEnumerable<Frequency> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class TransferCollection : HashSet<Transfer>, IFeedElement
	{
		public TransferCollection()
		{
		}

		public TransferCollection(IEnumerable<Transfer> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public class FeedInfoCollection : HashSet<FeedInfo>, IFeedElement
	{
		public FeedInfoCollection()
		{
		}

		public FeedInfoCollection(IEnumerable<FeedInfo> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	//public class ElementCollection<T> : HashSet<T>, IFeedElement where T : Entity
	//{
	//	public void Accept(IFeedVisitor visitor)
	//	{
	//		visitor.Visit(this);
	//	}
	//}

	public interface IFeedElement
	{
		void Accept(IFeedVisitor visitor);
	}
}
