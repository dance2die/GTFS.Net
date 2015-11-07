using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GtfsNet.Enums;

namespace GtfsNet.Entities
{
	/// <summary>
	/// Holds information of a row in stop.txt
	/// </summary>
	/// <remarks>
	/// Copied from "https://github.com/OsmSharp/GTFS/blob/2b8f3201e65ab5dd31cdacd82b4b05d34c288204/GTFS/Entities/Stop.cs"
	/// </remarks>
	public class Stop : Entity, IEqualityComparer<Stop>
	{
		[Required]
		public string Id { get; set; }

		public string Code { get; set; }

		[Required]
		public string Name { get; set; }

		public string Description { get; set; }

		[Required]
		public double Latitude { get; set; }

		[Required]
		public double Longitude { get; set; }

		public string Zone { get; set; }

		public string Url { get; set; }

		public LocationType? LocationType { get; set; }

		public string ParentStation { get; set; }

		public string Timezone { get; set; }

		public string WheelchairBoarding { get; set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1} - {2}", Id, Name, Description);
		}

		public bool Equals(Stop x, Stop y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(Stop obj)
		{
			return ComputeHashCode(obj);
		}
	}
}