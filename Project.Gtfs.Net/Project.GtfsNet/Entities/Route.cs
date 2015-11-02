using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Enums;

namespace Project.GtfsNet.Entities
{
	public class Route : Entity, IEqualityComparer<Route>
	{
		[Required]
		public string Id { get; set; }

		public string AgencyId { get; set; }

		[Required]
		public string ShortName { get; set; }

		[Required]
		public string LongName { get; set; }

		public string Description { get; set; }

		[Required]
		public RouteType Type { get; set; }

		public string Url { get; set; }

		public string Color { get; set; }

		public string TextColor { get; set; }

		public bool Equals(Route x, Route y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(Route obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
