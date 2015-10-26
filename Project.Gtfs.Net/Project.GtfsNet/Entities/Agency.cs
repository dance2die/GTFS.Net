using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

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
			if (agency == null) return false;

			return AreEqual(agency, this);
		}

		public bool Equals(Agency x, Agency y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(Agency agency)
		{
			return ComputeHashCode(agency);
		}

		protected int ComputeHashCode<T>(T obj)
		{
			return obj.GetType().GetProperties().Sum(property => property.GetHashCode());
		}

		protected bool AreEqual<T>(T obj1, T obj2)
		{
			// http://stackoverflow.com/a/2502468/4035
			foreach (PropertyInfo property in obj1.GetType().GetProperties())
			{
				object value1 = property.GetValue(obj1, null);
				object value2 = property.GetValue(obj2, null);

				if (!value1.Equals(value2))
					return false;
			}

			return true;
		}
	}
}
