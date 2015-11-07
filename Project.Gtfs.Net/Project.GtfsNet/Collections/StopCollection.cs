using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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