using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
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