namespace Project.GtfsNet.Entities
{
	public interface IVisitor
	{
		void Visit(Agency agency);
		void Visit(Calendar calendar);
		void Visit(CalendarDate calendarDate);
		void Visit(FareAttribute fareAttribute);
		void Visit(FareRule fareRule);
		void Visit(FeedInfo feedInfo);
		void Visit(Frequency frequency);
		void Visit(Route route);
		void Visit(Shape shape);
		void Visit(Stop stop);
		void Visit(StopTime stopTime);
		void Visit(Transfer transfer);
		void Visit(Trip trip);
	}
}