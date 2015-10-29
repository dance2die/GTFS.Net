using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Visitors
{
	public class RequiredFieldVisitorTest
	{
		private readonly ITestOutputHelper _output;

		public RequiredFieldVisitorTest(ITestOutputHelper output)
		{
			_output = output;
		}
	}
}
