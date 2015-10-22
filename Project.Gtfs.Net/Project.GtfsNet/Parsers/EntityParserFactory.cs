using System;
using System.IO;
using EnsureThat;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;

namespace Project.GtfsNet.Parsers
{
	public class EntityParserFactory
	{
		public IEntityParser<IEntity> Create(string filePath)
		{
			Ensure.That(filePath).IsNotNullOrWhiteSpace();

			string fileName = Path.GetFileName(filePath);
			switch (fileName)
			{
				case "agency.txt":
					return new EntityParser<Agency, AgencyMap>();
				case "calendar.txt":
					return new EntityParser<Calendar, CalendarMap>();
				case "calendar_dates.txt":
					return new EntityParser<CalendarDates, CalendarDatesMap>();
				case "fare_attributes.txt":
					return new EntityParser<FareAttributes, FareAttributesMap>();
				case "fare_rules.txt":
					return new EntityParser<FareRules, FareRulesMap>();
			}

			throw new ArgumentException();
		}
	}
}