using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
{
	public class FareAttributeCollection : HashSet<FareAttribute>, IFeedElement
	{
		public FareAttributeCollection()
		{
		}

		public FareAttributeCollection(IEnumerable<FareAttribute> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}