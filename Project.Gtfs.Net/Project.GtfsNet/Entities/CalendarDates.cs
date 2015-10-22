using System;
using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Enums;

namespace Project.GtfsNet.Entities
{
	public class CalendarDates
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
	}
}
