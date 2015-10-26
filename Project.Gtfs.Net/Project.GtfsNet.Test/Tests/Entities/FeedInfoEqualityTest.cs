using Project.GtfsNet.Entities;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class FeedInfoEqualityTest
	{
		private readonly FeedInfo _sut1;
		private readonly FeedInfo _sut2;

		private const string VALUE = "1";

		public FeedInfoEqualityTest()
		{
			_sut1 = new FeedInfo();
			_sut2 = new FeedInfo();
		}

		[Fact]
		public void CheckThatTwoObjectsAreSame()
		{
			_sut1.PublisherName = VALUE;
			_sut2.PublisherName = VALUE;

			_sut1.PublisherUrl = VALUE;
			_sut2.PublisherUrl = VALUE;

			_sut1.Lang = VALUE;
			_sut2.Lang = VALUE;

			_sut1.StartDate = VALUE;
			_sut2.StartDate = VALUE;

			_sut1.EndDate = VALUE;
			_sut2.EndDate = VALUE;

			_sut1.Version = VALUE;
			_sut2.Version = VALUE;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoObjectsAreDifferent()
		{
			_sut1.PublisherName = VALUE;
			_sut2.PublisherName = VALUE;

			_sut1.PublisherUrl = VALUE;
			_sut2.PublisherUrl = VALUE;

			_sut1.Lang = VALUE;
			_sut2.Lang = VALUE;

			_sut1.StartDate = VALUE;
			_sut2.StartDate = VALUE;

			_sut1.EndDate = VALUE;
			_sut2.EndDate = VALUE;

			_sut1.Version = VALUE;
			_sut2.Version = "2";

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
