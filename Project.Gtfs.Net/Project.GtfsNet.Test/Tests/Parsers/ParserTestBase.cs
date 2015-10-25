using System.IO;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Parsers
{
	public abstract class ParserTestBase
	{
		protected ITestOutputHelper _output;
		public abstract string TestFilePath { get; }

		public TextReader GetTextReader()
		{
			return File.OpenText(TestFilePath);
		}
	}
}