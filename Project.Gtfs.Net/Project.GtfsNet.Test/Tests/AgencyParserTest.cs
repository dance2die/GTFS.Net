using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class AgencyParserTest :  ParserTestBase
	{
		public override string TestFilePath { get; } = "feeds/subway/agency.txt";

		//private readonly EntityParser<Agency, AgencyMap> _parser;
		private readonly IEntityParser<IEntity> _parser;

		public AgencyParserTest(ITestOutputHelper output)
		{
			_output = output;
			_parser = new EntityParserFactory().Create(TestFilePath);
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.ThrowsAny<ArgumentNullException>(() => _parser.Parse(null));
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<IEntity> parsed = _parser.Parse(textReader);
				List<IEntity> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(1, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<IEntity> agencies = _parser.Parse(textReader);
				List<IEntity> agencyList = agencies.ToList();

				dynamic agency = agencyList[0];
				Assert.Equal("LI", agency.Id);
				Assert.Equal("en", agency.Language);
				Assert.Equal("Long Island Rail Road", agency.Name);
				Assert.Equal("718-558-7400", agency.Phone);
				Assert.Equal("America/New_York", agency.Timezone);
				Assert.Equal("http://web.mta.info/lirr", agency.Url);
				Assert.Null(agency.FareUrl);
			}
		}
	}
}
