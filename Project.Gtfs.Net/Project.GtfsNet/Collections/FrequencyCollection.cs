using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
	public class FrequencyCollection : HashSet<Frequency>, IFeedElement
	{
		public FrequencyCollection()
		{
		}

		public FrequencyCollection(IEnumerable<Frequency> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}