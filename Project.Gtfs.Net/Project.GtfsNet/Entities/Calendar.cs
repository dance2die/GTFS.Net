using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GtfsNet.Entities
{
	/// <summary>
	/// Represents a row in calendar.txt
	/// </summary>
	/// <remarks>
	/// Copied from
	/// https://github.com/OsmSharp/GTFS/blob/master/GTFS/Entities/Calendar.cs
	/// </remarks>
	public class Calendar : Entity, IEqualityComparer<Calendar>
	{
		[Required]
		public string ServiceId { get; set; }

		[Required]
		public bool Monday { get; set; }

		[Required]
		public bool Tuesday { get; set; }

		[Required]
		public bool Wednesday { get; set; }

		[Required]
		public bool Thursday { get; set; }

		[Required]
		public bool Friday { get; set; }

		[Required]
		public bool Saturday { get; set; }

		[Required]
		public bool Sunday { get; set; }

		[Required]
		public DateTime StartDate { get; set; }

		[Required]
		public DateTime EndDate { get; set; }

		public override string ToString()
		{
			return string.Format("[{0}] mon-sun {1}:{2}:{3}:{4}:{5}:{6}:{7}",
				ServiceId,
				Monday ? "1" : "0",
				Tuesday ? "1" : "0",
				Wednesday ? "1" : "0",
				Thursday ? "1" : "0",
				Friday ? "1" : "0",
				Saturday ? "1" : "0",
				Sunday ? "1" : "0");
		}

		public bool Equals(Calendar x, Calendar y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(Calendar obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
