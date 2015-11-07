using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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