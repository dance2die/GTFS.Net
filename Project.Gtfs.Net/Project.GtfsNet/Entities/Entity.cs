using System.Linq;
using System.Reflection;

namespace Project.GtfsNet.Entities
{
	public abstract class Entity : IEntity
	{
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
				if (value1 == null) continue;

				if (!value1.Equals(value2))
					return false;
			}

			return true;
		}
	}
}
