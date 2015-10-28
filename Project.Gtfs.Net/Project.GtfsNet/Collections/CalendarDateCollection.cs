using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
	public class CalendarDateCollection : HashSet<CalendarDate>, IFeedElement
	{
		public CalendarDateCollection()
		{
		}

		public CalendarDateCollection(IEnumerable<CalendarDate> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}