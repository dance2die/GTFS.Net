using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
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