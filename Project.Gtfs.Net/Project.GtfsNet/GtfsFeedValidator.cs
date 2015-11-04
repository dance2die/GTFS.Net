using System.Collections.Generic;
using System.Linq;
using Project.GtfsNet.Visitors;

namespace Project.GtfsNet
{
	public class GtfsFeedValidator
	{
		public List<string> UnparsedFiles { get; private set; } = new List<string>();
		public List<string> FilesMissingRequiredFields { get; private set; } = new List<string>();

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

			UnparsedFiles = fileVisitor.UnparsedFiles;

			return fileVisitor.IsValid;
		}

		private bool ValidateFields(GtfsFeed feed)
		{
			var validFlags = new List<bool>();
			RequiredFieldVisitor requiredFieldVisitor = new RequiredFieldVisitor();

			requiredFieldVisitor.AgenciesChecked += (agencies, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Agency);
			};
			requiredFieldVisitor.StopsChecked += (stops, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Stops);
			};
			requiredFieldVisitor.RoutesChecked += (routes, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Routes);
			};
			requiredFieldVisitor.TripsChecked += (trips, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Trips);
			};
			requiredFieldVisitor.StopTimesChecked += (stopTimes, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.StopTimes);
			};
			requiredFieldVisitor.CalendarsChecked += (calendars, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Calendar);
			};
			requiredFieldVisitor.CalendarDatesChecked += (calendarDatess, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.CalendarDates);
			};
			requiredFieldVisitor.FareAttributesChecked += (fareAttributes, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.FareAttributes);
			};
			requiredFieldVisitor.FareRulesChecked += (fareRules, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.FareRules);
			};
			requiredFieldVisitor.ShapesChecked += (shapes, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Shapes);
			};
			requiredFieldVisitor.FrequenciesChecked += (frequencies, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Frequencies);
			};
			requiredFieldVisitor.TransfersChecked += (transfers, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.Transfers);
			};
			requiredFieldVisitor.FeedInfosChecked += (feedInfos, args) =>
			{
				validFlags.Add(args.IsValid);
				FilesMissingRequiredFields.Add(SupportedFileNames.FeedInfo);
			};

			feed.Accept(requiredFieldVisitor);

			return validFlags.All(flag => flag);
		}

	}
}