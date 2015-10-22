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
		private readonly EntitiesParser<FareAttributes, FareAttributesMap> _parser = new EntitiesParser<FareAttributes, FareAttributesMap>();

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
				IEnumerable<FareAttributes> parsed = _parser.Parse(textReader);
				List<FareAttributes> parsedList = parsed.ToList();

				Assert.NotNull(parsedList);
				Assert.True(parsedList.Any());
			}
		}

		[Fact]
		public void CheckDataIsParsedCorrectly()
		{
			using (TextReader textReader = GetTextReader())
			{
				IEnumerable<FareAttributes> parsed = _parser.Parse(textReader);
				List<FareAttributes> parsedList = parsed.ToList();

				FareAttributes item = parsedList[0];

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
