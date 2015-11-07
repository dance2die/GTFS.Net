using System.Collections.Generic;
using GtfsNet.Entities;
using GtfsNet.Visitors;

namespace GtfsNet.Collections
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