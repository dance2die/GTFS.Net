using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Core;
using Project.GtfsNet.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class AgencyParserTest :  ParserTestBase, IClassFixture<AgencyParserFixture>
	{
		public override string TestFilePath { get; } = "feeds/subway/agency.txt";

		private readonly AgencyParserFixture _agencyParserFixture;

		public AgencyParserTest(ITestOutputHelper output, AgencyParserFixture agencyParserFixture)
		{
			_output = output;
			_agencyParserFixture = agencyParserFixture;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.ThrowsAny<ArgumentNullException>(() => _agencyParserFixture.Parser.Parse(null));
		}

		[Fact]
		public void AgencyFileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Agency> agencies = _agencyParserFixture.Parser.Parse(textReader);
				List<Agency> agencyList = agencies.ToList();

				Assert.NotNull(agencyList);
				Assert.True(agencyList.Any());
			}
		}

		[Fact]
		public void CheckAgencyDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Agency> agencies = _agencyParserFixture.Parser.Parse(textReader);
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
