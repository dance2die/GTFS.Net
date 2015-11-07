using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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