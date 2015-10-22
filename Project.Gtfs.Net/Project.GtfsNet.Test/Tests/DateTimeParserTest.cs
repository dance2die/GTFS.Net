using System;
using Project.GtfsNet.Parsers;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class DateTimeParserTest
	{
		private readonly ITestOutputHelper _output;

		public DateTimeParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void ThrowFormatExceptionIfInputIsInBadFormat()
		{
			var sut = new DateTimeParser();

			string invalidDateTimeText = "10/21/2015";
			Assert.Throws<FormatException>(() => sut.Parse(invalidDateTimeText));
		}

		[Theory]
		[InlineData("20150123", 2015, 1, 23)]
		[InlineData("19991225", 1999, 12, 25)]
		public void TestThatValidDateTimeTextParsesSuccesfully(string input, int expectedYear, int expectedMonth, int expectedDay)
		{
			var sut = new DateTimeParser();

			var expected = new DateTime(expectedYear, expectedMonth, expectedDay);
			var actual = sut.Parse(input);
			_output.WriteLine("Expected: {0}\nActual: {1}", expected, actual);

			Assert.Equal(expected, actual);
		}
	}
}
