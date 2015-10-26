using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Enums;

namespace Project.GtfsNet.Entities
{
	/// <remarks>
	/// https://github.com/OsmSharp/GTFS/blob/226a247861cf90badde49655095193ac829cf227/GTFS/Entities/CalendarDate.cs
	/// </remarks>
	public class CalendarDate : Entity, IEqualityComparer<CalendarDate>
	{
		[Required]
		public string ServiceId { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[Required]
		public ExceptionType ExceptionType { get; set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1} {2}", ServiceId, Date, ExceptionType);
		}

		public bool Equals(CalendarDate x, CalendarDate y)
		{
			return AreEqual(x, y);
		}

		public int GetHashCode(CalendarDate obj)
		{
			return ComputeHashCode(obj);
		}
	}
}
