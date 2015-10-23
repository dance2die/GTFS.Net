using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.GtfsNet.Demo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IEntity entity = new EntityParser<Map>().Parse().FirstOrDefault();
			var agency = entity as AgencyEntity;
			Console.WriteLine(agency.Name);
		}
	}

	public class EntityParser<TMap> : IEntityParser<IEntity>
		where TMap : Map
	{
		public IEnumerable<IEntity> Parse()
		{
			yield return new AgencyEntity();
		}
	}

	public interface IEntityParser<out T>
	{
		IEnumerable<T> Parse();
	}

	public interface IEntity{}

	public class AgencyEntity : IEntity { public string Name = "David"; }

	public class Map {}
}
