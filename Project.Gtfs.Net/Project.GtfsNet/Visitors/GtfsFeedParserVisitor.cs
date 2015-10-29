using System.IO;
using System.Linq;
using Project.GtfsNet.Collections;
using Project.GtfsNet.Entities;
using Project.GtfsNet.Parsers;

namespace Project.GtfsNet.Visitors
{
	public class GtfsFeedParserVisitor : IFeedVisitor
	{
		private readonly string _feedPath;
		public GtfsFeed Feed { get; }

		public GtfsFeedParserVisitor(string feedPath)
		{
			_feedPath = feedPath;
			Feed = new GtfsFeed();
		}

		public void Visit(AgencyCollection agencies)
		{
			using (var textReader = GetTextReader<Agency>(_feedPath))
			{
				Feed.Agencies = new AgencyCollection(GetEntityParser<Agency>().Parse(textReader).Cast<Agency>());
			}
		}

		public void Visit(StopCollection stops)
		{
			using (var textReader = GetTextReader<Stop>(_feedPath))
			{
				Feed.Stops = new StopCollection(GetEntityParser<Stop>().Parse(textReader).Cast<Stop>());
			}
		}

		public void Visit(RouteCollection routes)
		{
			using (var textReader = GetTextReader<Route>(_feedPath))
			{
				Feed.Routes = new RouteCollection(GetEntityParser<Route>().Parse(textReader).Cast<Route>());
			}
		}

		public void Visit(TripCollection trips)
		{
			using (var textReader = GetTextReader<Trip>(_feedPath))
			{
				Feed.Trips = new TripCollection(GetEntityParser<Trip>().Parse(textReader).Cast<Trip>());
			}
		}

		public void Visit(StopTimeCollection stopTimes)
		{
			using (var textReader = GetTextReader<StopTime>(_feedPath))
			{
				Feed.StopTimes = new StopTimeCollection(GetEntityParser<StopTime>().Parse(textReader).Cast<StopTime>());
			}
		}

		public void Visit(CalendarCollection calendars)
		{
			using (var textReader = GetTextReader<Calendar>(_feedPath))
			{
				Feed.Calendars = new CalendarCollection(GetEntityParser<Calendar>().Parse(textReader).Cast<Calendar>());
			}
		}

		public void Visit(CalendarDateCollection calendarDates)
		{
			using (var textReader = GetTextReader<CalendarDate>(_feedPath))
			{
				Feed.CalendarDates = new CalendarDateCollection(GetEntityParser<CalendarDate>().Parse(textReader).Cast<CalendarDate>());
			}
		}

		public void Visit(FareAttributeCollection fareAttributes)
		{
			using (var textReader = GetTextReader<FareAttribute>(_feedPath))
			{
				Feed.FareAttributes = new FareAttributeCollection(GetEntityParser<FareAttribute>().Parse(textReader).Cast<FareAttribute>());
			}
		}

		public void Visit(FareRuleCollection fareRules)
		{
			using (var textReader = GetTextReader<FareRule>(_feedPath))
			{
				Feed.FareRules = new FareRuleCollection(GetEntityParser<FareRule>().Parse(textReader).Cast<FareRule>());
			}
		}

		public void Visit(ShapeCollection shapes)
		{
			using (var textReader = GetTextReader<Shape>(_feedPath))
			{
				Feed.Shapes = new ShapeCollection(GetEntityParser<Shape>().Parse(textReader).Cast<Shape>());
			}
		}

		public void Visit(FrequencyCollection frequencies)
		{
			using (var textReader = GetTextReader<Frequency>(_feedPath))
			{
				Feed.Frequencies = new FrequencyCollection(GetEntityParser<Frequency>().Parse(textReader).Cast<Frequency>());
			}
		}

		public void Visit(TransferCollection transfers)
		{
			using (var textReader = GetTextReader<Transfer>(_feedPath))
			{
				Feed.Transfers = new TransferCollection(GetEntityParser<Transfer>().Parse(textReader).Cast<Transfer>());
			}
		}

		public void Visit(FeedInfoCollection feedInfos)
		{
			using (var textReader = GetTextReader<FeedInfo>(_feedPath))
			{
				Feed.FeedInfos = new FeedInfoCollection(GetEntityParser<FeedInfo>().Parse(textReader).Cast<FeedInfo>());
			}
		}

		private TextReader GetTextReader<T>(string feedPath)
		{
			string fileName = SupportedFileNames.GetFileNameByType<T>();
			var testFilePath = Path.Combine(feedPath, fileName);
			return File.OpenText(testFilePath);
		}

		private IEntityParser<IEntity> GetEntityParser<T>()
		{
			return new EntityParserFactory().Create(
				SupportedFileNames.GetFileNameByType<T>());
		}
	}
}