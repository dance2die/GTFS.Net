namespace Project.GtfsNet.Test.Fixtures
{
	public class VisitorPathFixture
	{
		public string GoodFeedPath { get; } = "feeds/subway";
		public string BadFeedPath { get; } = "feeds/missingRequiredFiles";
		public string NonExistingFeedPath { get; } = "feeds";
	}
}
