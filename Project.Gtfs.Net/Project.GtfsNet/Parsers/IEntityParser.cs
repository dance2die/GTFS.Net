using System.Collections.Generic;
using System.IO;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Parsers
{
	public interface IEntityParser<out T> where T : IEntity
	{
		IEnumerable<T> Parse(TextReader textReader);
	}
}