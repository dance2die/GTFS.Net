﻿using System.Collections.Generic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using EnsureThat;

namespace Project.GtfsNet.Parsers
{
	public class EntitiesParser<TEntity, TEntityMap> where TEntityMap : CsvClassMap
	{
		public IEnumerable<TEntity> Parse(TextReader textReader)
		{
			Ensure.That(() => textReader).IsNotNull();

			var csv = new CsvReader(textReader);
			csv.Configuration.RegisterClassMap<TEntityMap>();
			csv.Configuration.WillThrowOnMissingField = false;

			var records = csv.GetRecords<TEntity>();

			return records;
		}

	}
}