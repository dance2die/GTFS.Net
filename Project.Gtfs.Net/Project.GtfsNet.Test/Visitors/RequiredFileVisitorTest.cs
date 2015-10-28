using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Visitors
{
	/// <summary>
	/// Test if all required files are parsed.
	/// Required file list can be found here.<see cref="https://developers.google.com/transit/gtfs/reference#feed-files"/>
	/// </summary>
	public class RequiredFileVisitorTest
	{
		private readonly ITestOutputHelper _output;

		public RequiredFileVisitorTest(ITestOutputHelper output)
		{
			_output = output;
		}
	}
}
