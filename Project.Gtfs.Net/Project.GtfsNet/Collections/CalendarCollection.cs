using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
{
	public class CalendarCollection : HashSet<Calendar>, IFeedElement
	{
		public CalendarCollection()
		{
		}

		public CalendarCollection(IEnumerable<Calendar> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}