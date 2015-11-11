using System.Collections.Generic;
using System.Linq;
using GtfsNet.Parsers;
using GtfsNet.Test.Fixtures;
using GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace GtfsNet.Test.Tests.Visitors
{
	/// <summary>
	/// Test if all required files are parsed.
	/// Required file list can be found here.<see cref="https://developers.google.com/transit/gtfs/reference#feed-files"/>
	/// </summary>
	public class RequiredFileVisitorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;

		public RequiredFileVisitorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;
		}

		[Fact]
		public void WhenAllFilesAreParsedAllRequiredFilesShoulNotBeEmpty()
		{
			var parser = new GtfsFeedParser();
			var feed = parser.Parse(_visitorPathFixture.GoodFeedPath);
			RequiredFileVisitor sut = new RequiredFileVisitor();

			feed.Accept(sut);

			Assert.True(sut.IsValid);
		}

		[Fact]
		public void WhenFeedPathMissesRequiredFilesThenValidatorReportsNotValid()
		{
			var parser = new GtfsFeedParser();
			var feed = parser.Parse(_visitorPathFixture.BadFeedPath);
			RequiredFileVisitor sut = new RequiredFileVisitor();

			feed.Accept(sut);
			PrintUnparsedFiles(sut);

			Assert.False(sut.IsValid);
		}

		[Fact]
		public void EmptyFeedShouldBeInvalid()
		{
			RequiredFileVisitor sut = new RequiredFileVisitor();

			GtfsFeed emptyFeed = new GtfsFeed();
			emptyFeed.Accept(sut);

			Assert.False(sut.IsValid);
		}

		[Fact]
		public void VisitorShouldReportMissingRequiredFileNames()
		{
			var parser = new GtfsFeedParser();
			var feed = parser.Parse(_visitorPathFixture.NonExistingFeedPath);
			RequiredFileVisitor sut = new RequiredFileVisitor();

			feed.Accept(sut);
			PrintUnparsedFiles(sut);

			Assert.Contains(SupportedFileNames.Agency, sut.UnparsedFiles);
			Assert.Contains(SupportedFileNames.Stops, sut.UnparsedFiles);
			Assert.Contains(SupportedFileNames.Routes, sut.UnparsedFiles);
			Assert.Contains(SupportedFileNames.Trips, sut.UnparsedFiles);
			Assert.Contains(SupportedFileNames.StopTimes, sut.UnparsedFiles);
			Assert.Contains(SupportedFileNames.Calendar, sut.UnparsedFiles);
		}

		[Fact]
		public void GoodFeedPathreturnsNoUnparsedFileAndIsValid()
		{
			var parser = new GtfsFeedParser();
			var feed = parser.Parse(_visitorPathFixture.GoodFeedPath);
			RequiredFileVisitor sut = new RequiredFileVisitor();

			feed.Accept(sut);
			PrintUnparsedFiles(sut);

			Assert.True(sut.UnparsedFiles.Count == 0);
			Assert.True(sut.IsValid);
		}


		private void PrintUnparsedFiles(RequiredFileVisitor sut)
		{
			List<string> files = sut.UnparsedFiles.ToList();
			foreach (string unparsedFile in files)
			{
				_output.WriteLine("Not Parsed: {0}", unparsedFile);
			}
		}
	}
}
