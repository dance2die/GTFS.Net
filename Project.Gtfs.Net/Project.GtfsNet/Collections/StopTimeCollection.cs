using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
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
}