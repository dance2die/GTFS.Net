using System.Collections.Generic;
using System.Linq;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet
{
	public class GtfsFeedValidator
	{
		public bool Validate(GtfsFeed feed)
		{
			bool isFileValid = ValidateFile(feed);
			bool areFieldsValid = ValidateFields(feed);

			return isFileValid && areFieldsValid;
		}

		private bool ValidateFile(GtfsFeed feed)
		{
			var fileVisitor = new RequiredFileVisitor();
			feed.Accept(fileVisitor);
			return fileVisitor.IsValid;
		}

		private bool ValidateFields(GtfsFeed feed)
		{
			var validFlags = new List<bool>();
			RequiredFieldVisitor requiredFieldVisitor = new RequiredFieldVisitor();

			requiredFieldVisitor.AgenciesChecked += (agencies, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.StopsChecked += (stops, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.RoutesChecked += (routes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.TripsChecked += (trips, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.StopTimesChecked += (stopTimes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.CalendarsChecked += (calendars, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.CalendarDatesChecked += (calendarDatess, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FareAttributesChecked += (fareAttributes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FareRulesChecked += (fareRules, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.ShapesChecked += (shapes, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FrequenciesChecked += (frequencies, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.TransfersChecked += (transfers, args) => validFlags.Add(args.IsValid);
			requiredFieldVisitor.FeedInfosChecked += (feedInfos, args) => validFlags.Add(args.IsValid);

			feed.Accept(requiredFieldVisitor);

			return validFlags.All(flag => flag);
		}
	}
}