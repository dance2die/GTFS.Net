using System.Collections.Generic;
using System.IO;
using CsvHelper;
using EnsureThat;
using Project.GtfsNet.Core;
using Project.GtfsNet.Core.Maps;

namespace Project.GtfsNet.Parsers
{
	public class AgencyParser
	{
		public IEnumerable<Agency> Parse(TextReader textReader)
		{
			Ensure.That(() => textReader).IsNotNull();

			var csv = new CsvReader(textReader);
			csv.Configuration.RegisterClassMap<AgencyMap>();
			csv.Configuration.WillThrowOnMissingField = false;
			var records = csv.GetRecords<Agency>();

			return records;
		}
	}
}