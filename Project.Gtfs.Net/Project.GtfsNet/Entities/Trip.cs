using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GtfsNet.Enums;

namespace GtfsNet.Entities
{
	public class Trip : Entity, IEqualityComparer<Trip>
	{
		[Required]
		public string Id { get; set; }

		[Required]
		public string RouteId { get; set; }

		[Required]
		public string ServiceId { get; set; }

		public string Headsign { get; set; }

		public string ShortName { get; set; }

		public DirectionType? DirectionId { get; set; }

		public string BlockId { get; set; }

		public string ShapeId { get; set; }

		public WheelchairAccessibilityType? WheelchairAccessibilityType { get; set; }

		/// <remarks>https://github.com/OsmSharp/GTFS/blob/226a247861cf90badde49655095193ac829cf227/GTFS/Entities/Trip.cs</remarks>
		public override string ToString()
		{
			return string.Format("[{0}] {1}", this.ShortName, this.Headsign);
		}

		public bool Equals(Trip x, Trip y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(Trip obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
