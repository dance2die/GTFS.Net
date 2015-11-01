using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Project.GtfsNet.Collections;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Test.Fixtures;
using Project.GtfsNet.Visitors;
using Xunit;
using Xunit.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Project.GtfsNet.Test.Tests.Visitors
{
	public class RequiredFieldVisitorTest : IClassFixture<VisitorPathFixture>
	{
		private readonly ITestOutputHelper _output;
		private readonly VisitorPathFixture _visitorPathFixture;
		private readonly RequiredFieldVisitor _sut;
		private readonly GtfsFeed _parsedFeedGood;
		private readonly GtfsFeed _parsedFeedNonExisting;

		public RequiredFieldVisitorTest(ITestOutputHelper output, VisitorPathFixture visitorPathFixture)
		{
			_output = output;
			_visitorPathFixture = visitorPathFixture;
			_sut = new RequiredFieldVisitor();
			_parsedFeedGood = GetParsedFeed(_visitorPathFixture.GoodFeedPath);
			_parsedFeedNonExisting = GetParsedFeed(_visitorPathFixture.NonExistingFeedPath);
		}

		private GtfsFeed GetParsedFeed(string feedPath)
		{
			GtfsFeed feed = new GtfsFeed();
			GtfsFeedParserVisitor parseVisitor = new GtfsFeedParserVisitor(feedPath);
			feed.Accept(parseVisitor);
			return parseVisitor.Feed;
		}

		//[Fact]
		//public void GoodFeedHasAllRequiredFields()
		//{
		//	_parsedFeedGood.Accept(_sut);

		//	Assert.True(_sut.IsValid);
		//}

		[Fact]
		public void GoodFeedHasValid()
		{
			bool isAllValid = true;
			_sut.AgenciesChecked += (agencies, args) =>
			{
				if (isAllValid && !args.IsValid)
					isAllValid = false;
			};

			_parsedFeedGood.Accept(_sut);

			Assert.True(_sut.IsValid);
		}

		[Fact]
		public void EmptyFeedHasInvalidFields()
		{
			List<bool> validFlags = new List<bool>();
			_sut.AgenciesChecked += (agencies, args) => validFlags.Add(args.IsValid);

			_parsedFeedNonExisting.Accept(_sut);

			Assert.True(validFlags.Any(flag => flag == false));
		}
	}

	/// <summary>
	/// This visitor decides if every required field in each object of each collection does exist or not
	/// </summary>
	public class RequiredFieldVisitor : IFeedVisitor
	{
		public bool IsValid { get; set; } = true;

		public event EventHandler<ValidationEventArgs> AgenciesChecked;

		protected virtual void OnAgenciesChecked(AgencyCollection agencies, ValidationEventArgs e)
		{
			AgenciesChecked?.Invoke(agencies, e);
		}

		public void Visit(AgencyCollection agencies)
		{
			OnAgenciesChecked(agencies, new ValidationEventArgs(CheckValidity(agencies)));
		}

		private bool CheckValidity<T>(HashSet<T> items) where T : Entity
		{
			bool result = true;

			if (items.Count <= 0)
			{
				result = false;
			}
			else
			{
				foreach (T item in items)
				{
					IEnumerable<PropertyInfo> requiredProperties = GetRequiredProperties(item);
					foreach (PropertyInfo requiredProperty in requiredProperties)
					{
						var value = requiredProperty.GetValue(item);
						if (value != null) continue;

						result = false;
						break;
					}
				}
			}

			return result;
		}


		private IEnumerable<PropertyInfo> GetRequiredProperties(Entity entity)
		{
			return entity.GetType().GetProperties().Where((pi, index) => Attribute.IsDefined(pi, typeof(RequiredAttribute)));
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

	public class ValidationEventArgs
	{
		public bool IsValid { get; set; }

		public ValidationEventArgs(bool isValid)
		{
			IsValid = isValid;
		}
	}
}
