using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
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
}