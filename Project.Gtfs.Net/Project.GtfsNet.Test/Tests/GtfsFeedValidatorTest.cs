using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.GtfsNet.Test.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests
{
	public class GtfsFeedValidatorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;

		public GtfsFeedValidatorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;
		}
	}
}
