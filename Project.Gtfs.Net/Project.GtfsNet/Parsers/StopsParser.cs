using System.Collections.Generic;
using System.IO;
using CsvHelper;
using EnsureThat;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;

namespace Project.GtfsNet.Parsers
{
	public class StopsParser
	{
		public IEnumerable<Stops> Parse(TextReader textReader)
		{
			Ensure.That(() => textReader).IsNotNull();

			var csv = new CsvReader(textReader);
			csv.Configuration.RegisterClassMap<StopsMap>();
			csv.Configuration.WillThrowOnMissingField = false;
			var records = csv.GetRecords<Stops>();

			return records;
		}
	}
}