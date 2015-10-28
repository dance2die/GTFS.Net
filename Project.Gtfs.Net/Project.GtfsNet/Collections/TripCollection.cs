using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
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
}