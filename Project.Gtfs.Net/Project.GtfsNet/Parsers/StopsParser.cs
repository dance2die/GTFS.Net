using System.IO;
using EnsureThat;

namespace Project.GtfsNet.Test.Tests
{
	public class StopsParser
	{
		public Stops Parse(TextReader textReader)
		{
			Ensure.That(() => textReader).IsNotNull();

			return new Stops();
		}
	}
}