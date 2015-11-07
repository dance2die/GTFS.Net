using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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