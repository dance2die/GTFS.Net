using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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