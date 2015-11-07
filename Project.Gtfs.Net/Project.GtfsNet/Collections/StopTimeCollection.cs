using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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