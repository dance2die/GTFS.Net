using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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