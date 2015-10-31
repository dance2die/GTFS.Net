using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.GtfsNet.Collections;
using Project.GtfsNet.Test.Fixtures;
using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;

namespace Project.GtfsNet.Test.Tests.Visitors
{
	public class RequiredFieldVisitorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;
		private readonly RequiredFieldVisitor _sut;

		public RequiredFieldVisitorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;
			_sut = new RequiredFieldVisitor();
		}

		//[Fact]
		//public void 
	}

	/// <summary>
	/// This visitor decides if every required field in each object of each collection does exist or not
	/// </summary>
	public class RequiredFieldVisitor : IFeedVisitor
	{
		public void Visit(AgencyCollection agencies)
		{
			
		}

		public void Visit(StopCollection stops)
		{
			
		}

		public void Visit(RouteCollection routes)
		{
			
		}

		public void Visit(TripCollection trips)
		{
			
		}

		public void Visit(StopTimeCollection stopTimes)
		{
			
		}

		public void Visit(CalendarCollection calendars)
		{
			
		}

		public void Visit(CalendarDateCollection calendarDates)
		{
			
		}

		public void Visit(FareAttributeCollection fareAttributes)
		{
			
		}

		public void Visit(FareRuleCollection fareRules)
		{
			
		}

		public void Visit(ShapeCollection shapes)
		{
			
		}

		public void Visit(FrequencyCollection frequencies)
		{
			
		}

		public void Visit(TransferCollection transfers)
		{
			
		}

		public void Visit(FeedInfoCollection feedInfos)
		{
			
		}
	}
}
