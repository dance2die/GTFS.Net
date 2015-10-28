using System.Collections.Generic;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet.Collections
{
	public class ShapeCollection : HashSet<Shape>, IFeedElement
	{
		public ShapeCollection()
		{
		}

		public ShapeCollection(IEnumerable<Shape> collection) : base(collection)
		{
		}

		public void Accept(IFeedVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}