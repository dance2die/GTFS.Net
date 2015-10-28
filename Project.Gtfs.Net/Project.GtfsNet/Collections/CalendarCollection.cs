using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
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