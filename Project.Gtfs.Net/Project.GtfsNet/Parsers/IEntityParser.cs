using System.Collections.Generic;
using System.IO;

namespace Project.GtfsNet.Parsers
{
	public interface IEntityParser<out TEntity>
	{
		IEnumerable<TEntity> Parse(TextReader textReader);
	}
}