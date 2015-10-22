using System.Collections.Generic;
using System.IO;
using System.Linq;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Entities.Maps;
using Project.GtfsNet.Enums;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class TransfersParserTest : ParserTestBase
	{
		private readonly EntityParser<Transfers, TransfersMap> _parser = new EntityParser<Transfers, TransfersMap>();

		public override string TestFilePath { get; } = "feeds/subway/transfers.txt";

		public TransfersParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Transfers> parsed = _parser.Parse(textReader);
				List<Transfers> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(610, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<Transfers> parsed = _parser.Parse(textReader);
				List<Transfers> parsedList = parsed.ToList();

				Transfers item = parsedList[0];

				Assert.Equal("101", item.FromStopId);
				Assert.Equal("180", item.MinimumTransferTime);
				Assert.Equal("101", item.ToStopId);
				Assert.Equal(TransferType.MinimumTime, item.TransferType);
			}
		}
	}
}
