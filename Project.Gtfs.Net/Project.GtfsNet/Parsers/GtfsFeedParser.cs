using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Parsers
{
	public class GtfsFeedParser
	{
		public GtfsFeed Parse(string feedPath)
		{
			var result = new GtfsFeed();
			var parserFactory = new EntityParserFactory();

			var agencyTextReader = GetTextReader(feedPath, EntityParserFactory.SupportedFileNames.Agency);
			result.Agencies = new HashSet<Agency>(
				parserFactory.Create(EntityParserFactory.SupportedFileNames.Agency).Parse(agencyTextReader).Cast<Agency>());

			return result;
		}

		public TextReader GetTextReader(string feedPath, string fileName)
		{
			var testFilePath = Path.Combine(feedPath, fileName);
			return File.OpenText(testFilePath);
		}
	}
}
