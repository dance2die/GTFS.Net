using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project.GtfsNet.Entities
{
	/// <remarks>
	/// https://github.com/OsmSharp/GTFS/blob/2b8f3201e65ab5dd31cdacd82b4b05d34c288204/GTFS/Entities/Agency.cs
	/// </remarks>
	public class Agency : IEntity, IEqualityComparer<Agency>
	{
		public string Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Url { get; set; }

		[Required]
		public string Timezone { get; set; }

		public string Language { get; set; }

		public string Phone { get; set; }

		public string FareUrl { get; set; }

		/// <summary>
		/// Credit <see cref="https://github.com/OsmSharp/GTFS/blob/2b8f3201e65ab5dd31cdacd82b4b05d34c288204/GTFS/Entities/Agency.cs"/>
		/// </summary>
		public override string ToString()
		{
			return string.Format("[{0}] {1}", Id, Name);
		}

		public override bool Equals(object obj)
		{
			Agency agency = obj as Agency;
			return agency.Id == Id &&
				   agency.Name == Name &&
				   agency.Url == Url &&
				   agency.Timezone == Timezone &&
				   agency.Language == Language &&
				   agency.Phone == Phone &&
				   agency.FareUrl == FareUrl;
		}

		public bool Equals(Agency x, Agency y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(Agency agency)
		{
			return agency.Id.GetHashCode() +
				   agency.Name.GetHashCode() +
				   agency.Url.GetHashCode() +
				   agency.Timezone.GetHashCode() +
				   agency.Language.GetHashCode() +
				   agency.Phone.GetHashCode() +
				   agency.FareUrl.GetHashCode();
		}
	}
}
