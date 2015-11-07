using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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