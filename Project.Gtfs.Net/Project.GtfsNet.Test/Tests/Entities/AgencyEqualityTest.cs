using Project.GtfsNet.Entities;
using Xunit;

namespace Project.GtfsNet.Test.Tests.Entities
{
	public class AgencyEqualityTest
	{
		private readonly Agency _sut1;
		private readonly Agency _sut2;

		public AgencyEqualityTest()
		{
			_sut1 = new Agency();
			_sut2 = new Agency();
		}

		[Fact]
		public void CheckThatTwoAgencyObjectsAreSame()
		{
			const string fareUrl = "http://www.google.com";
			const string id = "1";
			const string language = "en";
			const string name = "David";
			const string phone = "111-222-3333";
			const string timezone = "timezone";
			const string url = "http://www.microsoft.com";

			_sut1.FareUrl = fareUrl;
			_sut2.FareUrl = fareUrl;

			_sut1.Id = id;
			_sut2.Id = id;

			_sut1.Language = language;
			_sut2.Language = language;

			_sut1.Name = name;
			_sut2.Name = name;

			_sut1.Phone = phone;
			_sut2.Phone = phone;

			_sut1.Timezone = timezone;
			_sut2.Timezone = timezone;

			_sut1.Url = url;
			_sut2.Url = url;

			Assert.True(_sut1.Equals(_sut1, _sut2));
		}

		[Fact]
		public void CheckThatTwoAgencyObjectsAreDifferent()
		{
			const string fareUrl = "http://www.google.com";
			const string id = "1";
			const string language = "en";
			const string name = "David";
			const string phone = "111-222-3333";
			const string timezone = "timezone";
			const string url = "http://www.microsoft.com";

			_sut1.FareUrl = fareUrl;
			_sut2.FareUrl = fareUrl;

			_sut1.Id = id;
			_sut2.Id = id;

			_sut1.Language = language;
			_sut2.Language = language;

			_sut1.Name = name;
			_sut2.Name = name;

			_sut1.Phone = phone;
			_sut2.Phone = phone;

			_sut1.Timezone = timezone;
			_sut2.Timezone = timezone;

			_sut1.Url = url;
			_sut2.Url = fareUrl;	// <-- Different.

			Assert.False(_sut1.Equals(_sut1, _sut2));
		}
	}
}
