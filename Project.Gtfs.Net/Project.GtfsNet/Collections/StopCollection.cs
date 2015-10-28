using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
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
}