using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

			IEnumerable<T> emptyRecords = new List<T>().AsReadOnly().AsEnumerable();
			if (textReader.Peek() == 0)
				return emptyRecords;

			var csv = new CsvReader(textReader);
			csv.Configuration.RegisterClassMap<TMap>();
			csv.Configuration.WillThrowOnMissingField = false;

			try
			{
				var records = csv.GetRecords<T>().ToList();
				return records;
			}
			catch (Exception)
			{
				return emptyRecords;
			}
		}
	}
}
