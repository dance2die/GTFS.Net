using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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