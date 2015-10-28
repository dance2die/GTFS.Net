using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
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
}