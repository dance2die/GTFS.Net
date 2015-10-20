using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Core;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class AgencyParserTest
	{
		private readonly ITestOutputHelper _output;
		private const string PATH = "feeds/subway/agency.txt";

		public AgencyParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			var sut = new AgencyParser();

			Assert.ThrowsAny<ArgumentNullException>(() => sut.Parse(null));
		}

		[Fact]
		public void AgencyFileIsNotEmpty()
		{
			var sut = new AgencyParser();

			using (TextReader textReader = GetAgencyTextReader())
			{
				IEnumerable<Agency> agencies = sut.Parse(textReader);
				List<Agency> agencyList = agencies.ToList();

				Assert.NotNull(agencyList);
				Assert.True(agencyList.Any());
			}
		}

		[Fact]
		public void CheckAgencyDataIsParsedCorrectly()
		{
			var sut = new AgencyParser();

			using (TextReader textReader = GetAgencyTextReader())
			{
				IEnumerable<Agency> agencies = sut.Parse(textReader);
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

		public TextReader GetAgencyTextReader()
		{
			return File.OpenText(PATH);
		}
	}
}
