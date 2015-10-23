using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using EnsureThat;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Parsers
{
	public class EntityParser<T, TMap> : IEntityParser<T>
		where T : IEntity
		where TMap : CsvClassMap
	{
		public IEnumerable<T> Parse(TextReader textReader)
		{
			Ensure.That(() => textReader).IsNotNull();

			var csv = new CsvReader(textReader);
			csv.Configuration.RegisterClassMap<TMap>();
			csv.Configuration.WillThrowOnMissingField = false;

			var records = csv.GetRecords<T>();

			return records;
		}
	}
}
