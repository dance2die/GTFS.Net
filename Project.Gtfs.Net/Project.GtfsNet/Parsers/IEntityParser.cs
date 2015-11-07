using System.Collections.Generic;
using System.IO;
using GtfsNet.Entities;

namespace GtfsNet.Parsers
{
	public interface IEntityParser<out T> where T : IEntity
	{
		IEnumerable<T> Parse(TextReader textReader);
	}
}