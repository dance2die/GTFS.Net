using System;
using EnsureThat;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;

namespace Project.GtfsNet.Parsers
{
	public class EntityParserFactory
	{
		public IEntityParser<IEntity> Create(string fileName)
		{
			Ensure.That(fileName).IsNotNullOrWhiteSpace();

			if (fileName == "agency.txt")
			{
				return new EntityParser<Agency, AgencyMap>();
			}

			throw new ArgumentException();
		}
	}
}