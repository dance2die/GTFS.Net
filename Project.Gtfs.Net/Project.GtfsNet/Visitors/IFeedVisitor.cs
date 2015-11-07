using GtfsNet.Collections;

namespace GtfsNet.Visitors
{
	public interface IFeedVisitor
	{
		void Visit(AgencyCollection agencies);
		void Visit(StopCollection stops);
		void Visit(RouteCollection routes);
		void Visit(TripCollection trips);
		void Visit(StopTimeCollection stopTimes);
		void Visit(CalendarCollection calendars);
		void Visit(CalendarDateCollection calendarDates);
		void Visit(FareAttributeCollection fareAttributes);
		void Visit(FareRuleCollection fareRules);
		void Visit(ShapeCollection shapes);
		void Visit(FrequencyCollection frequencies);
		void Visit(TransferCollection transfers);
		void Visit(FeedInfoCollection feedInfos);
	}
}