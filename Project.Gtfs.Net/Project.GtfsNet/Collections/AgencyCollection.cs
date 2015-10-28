using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
	public class AgencyCollection : HashSet<Agency>, IFeedElement
	{
		public AgencyCollection()
		{
		}

		public AgencyCollection(IEnumerable<Agency> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}