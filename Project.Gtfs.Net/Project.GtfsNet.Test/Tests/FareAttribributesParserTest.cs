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
	public class FareAttribributesParserTest : ParserTestBase
	{
		private readonly EntityParser<FareAttribute, FareAttributesMap> _parser = new EntityParser<FareAttribute, FareAttributesMap>();

		public override string TestFilePath { get; } = "feeds/subway/fare_attributes.txt";

		public FareAttribributesParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void FileIsNotEmpty()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<FareAttribute> parsed = _parser.Parse(textReader);
				List<FareAttribute> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
				Assert.Equal(2, parsedList.Count);
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<FareAttribute> parsed = _parser.Parse(textReader);
				List<FareAttribute> parsedList = parsed.ToList();

				FareAttribute item = parsedList[0];

				Assert.Equal("USD", item.CurrencyType);
				Assert.Equal("1", item.FareId);
				Assert.Equal(PaymentMethodType.OnBoard, item.PaymentMethod);
				Assert.Equal("1", item.Price);
				Assert.Equal("", item.TransferDuration);
				Assert.Equal(0, item.Transfers);
			}
		}
	}
}
