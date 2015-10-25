using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.GtfsNet.Demo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//TestEntityParser();

			TestHashSet();
		}

		private static void TestHashSet()
		{
			HashSet<Person> persons = new HashSet<Person>(new Person());
			var p1 = new Person {FirstName = "Albert", LastName = "Einstine"};
			var p2 = new Person {FirstName = "Albert", LastName = "Einstine"};
			persons.Add(p1);
			persons.Add(p2);

			Console.WriteLine("Count: {0}", persons.Count);
			Console.Read();
		}

		private static void TestEntityParser()
		{
			IEntity entity = new EntityParser<Map>().Parse().FirstOrDefault();
			var agency = entity as AgencyEntity;
			Console.WriteLine(agency.Name);
		}
	}

	/// <summary>
	/// http://alicebobandmallory.com/articles/2012/10/18/merge-collections-without-duplicates-in-c
	/// </summary>
	public class Person : IEqualityComparer<Person>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override bool Equals(object obj)
		{
			var person = obj as Person;
			return person.FirstName == FirstName && person.LastName == LastName;
		}

		public bool Equals(Person x, Person y)
		{
			return x.Equals(y);
		}

		public int GetHashCode(Person person)
		{
			return person.FirstName.GetHashCode() + person.LastName.GetHashCode();
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
