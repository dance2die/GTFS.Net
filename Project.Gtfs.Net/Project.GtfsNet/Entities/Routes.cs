using System.ComponentModel.DataAnnotations;
using Project.GtfsNet.Enums;

namespace Project.GtfsNet.Entities
{
	public class Routes : IEntity
	{
		[Required]
		public string Id { get; set; }

		[Required]
		public string AgencyId { get; set; }

		[Required]
		public string ShortName { get; set; }

		[Required]
		public string LongName { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public RouteType Type { get; set; }

		public string Url { get; set; }

		public string Color { get; set; }

		public string TextColor { get; set; }
	}
}
