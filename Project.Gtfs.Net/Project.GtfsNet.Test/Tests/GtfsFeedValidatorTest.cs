using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.GtfsNet.Parsers;
using Project.GtfsNet.Test.Fixtures;
using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class GtfsFeedValidatorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;

		private readonly GtfsFeed _parsedFeedGood;
		private readonly GtfsFeed _parsedFeedNonExisting;

		private readonly GtfsFeedValidator _sut;

		public GtfsFeedValidatorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;

			_parsedFeedGood = new GtfsFeedParser().Parse(_visitorPathFixture.GoodFeedPath);
			_parsedFeedNonExisting = new GtfsFeedParser().Parse(_visitorPathFixture.NonExistingFeedPath);

			_sut = new GtfsFeedValidator();
		}


	}

	public class GtfsFeedValidator
	{
		private readonly RequiredFieldVisitor _fieldVisitor;
		private readonly RequiredFileVisitor _fileVisitor;

		public GtfsFeedValidator()
		{
			_fieldVisitor = new RequiredFieldVisitor();
			_fileVisitor = new RequiredFileVisitor();
		}
	}
}
