using System;
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

		public EntitiesParser<Agency, AgencyMap> _parser = new EntitiesParser<Agency, AgencyMap>();

		public AgencyParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.ThrowsAny<ArgumentNullException>(() => _parser.Parse(null));
		}

		[Fact]
		public void AgencyFileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Agency> agencies = _parser.Parse(textReader);
				List<Agency> agencyList = agencies.ToList();

				Assert.NotNull(agencyList);
				Assert.True(agencyList.Any());
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Agency> agencies = _parser.Parse(textReader);
				List<Agency> agencyList = agencies.ToList();

				Agency agency = agencyList[0];
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
