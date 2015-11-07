using System.Collections.Generic;
using System.IO;
using System.Linq;
using GtfsNet.Entities;
using GtfsNet.Entities.Maps;
using GtfsNet.Enums;
using GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace GtfsNet.Test.Tests.Parsers
{
	public class TransfersParserTest : ParserTestBase
	{
		private readonly EntityParser<Transfer, TransfersMap> _parser = new EntityParser<Transfer, TransfersMap>();

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
				IEnumerable<Transfer> parsed = _parser.Parse(textReader);
				List<Transfer> parsedList = parsed.ToList();

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
				IEnumerable<Transfer> parsed = _parser.Parse(textReader);
				List<Transfer> parsedList = parsed.ToList();

				Transfer item = parsedList[0];

				Assert.Equal("101", item.FromStopId);
				Assert.Equal("180", item.MinimumTransferTime);
				Assert.Equal("101", item.ToStopId);
				Assert.Equal(TransferType.MinimumTime, item.TransferType);
			}
		}
	}
}
