namespace Project.GtfsNet.Entities
{
	//public interface IVisitor
	//{
	//	void Visit(Agency agency);
	//	void Visit(Calendar calendar);
	//	void Visit(CalendarDate calendarDate);
	//	void Visit(FareAttribute fareAttribute);
	//	void Visit(FareRule fareRule);
	//	void Visit(FeedInfo feedInfo);
	//	void Visit(Frequency frequency);
	//	void Visit(Route route);
	//	void Visit(Shape shape);
	//	void Visit(Stop stop);
	//	void Visit(StopTime stopTime);
	//	void Visit(Transfer transfer);
	//	void Visit(Trip trip);
	//}

	public interface IFeedVisitor
	{
		//void Visit(ElementCollection<Agency> agencies);
		//void Visit(ElementCollection<Calendar> calendars);
		//void Visit(ElementCollection<CalendarDate> calendarDates);
		//void Visit(ElementCollection<FareAttribute> fareAttributes);
		//void Visit(ElementCollection<FareRule> fareRules);
		//void Visit(ElementCollection<FeedInfo> feedInfos);
		//void Visit(ElementCollection<Frequency> frequencies);
		//void Visit(ElementCollection<Route> routes);
		//void Visit(ElementCollection<Shape> shapes);
		//void Visit(ElementCollection<Stop> stops);
		//void Visit(ElementCollection<StopTime> stopTimes);
		//void Visit(ElementCollection<Transfer> transfers);
		//void Visit(ElementCollection<Trip> trips);
		////void Visit<T>(ElementCollection<T> elementCollection) where T : Entity;
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