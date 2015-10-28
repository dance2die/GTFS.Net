using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
	public class FareRuleCollection : HashSet<FareRule>, IFeedElement
	{
		public FareRuleCollection()
		{
		}

		public FareRuleCollection(IEnumerable<FareRule> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}