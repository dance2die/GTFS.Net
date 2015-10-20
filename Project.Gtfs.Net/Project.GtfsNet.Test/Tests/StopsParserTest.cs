using System;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class StopsParserTest
	{
		private const string PATH = "feeds/subway/stops.txt";

		private readonly ITestOutputHelper _output;

		private readonly StopsParser _sut = new StopsParser();

		public StopsParserTest(ITestOutputHelper output)
		{
			_output = output;
		}

		[Fact]
		public void EnsureThatParsingOnNullTextReaderThrowsException()
		{
			Assert.ThrowsAny<ArgumentNullException>(() => _sut.Parse(null));
		}
	}
}
