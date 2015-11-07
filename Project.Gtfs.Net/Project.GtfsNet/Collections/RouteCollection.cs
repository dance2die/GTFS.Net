using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
{
	public class RouteCollection : HashSet<Route>, IFeedElement
	{
		public RouteCollection()
		{
		}

		public RouteCollection(IEnumerable<Route> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}