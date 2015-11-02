using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Project.GtfsNet.Collections;
using Project.GtfsNet.Entities;

namespace Project.GtfsNet.Visitors
{
	/// <summary>
	/// This visitor decides if every required field in each object of each collection does exist or not
	/// </summary>
	public class RequiredFieldVisitor : IFeedVisitor
	{
		public event EventHandler<ValidationEventArgs> AgenciesChecked;
		public event EventHandler<ValidationEventArgs> StopsChecked;
		public event EventHandler<ValidationEventArgs> RoutesChecked;
		public event EventHandler<ValidationEventArgs> TripsChecked;
		public event EventHandler<ValidationEventArgs> StopTimesChecked;
		public event EventHandler<ValidationEventArgs> CalendarsChecked;
		public event EventHandler<ValidationEventArgs> CalendarDatesChecked;
		public event EventHandler<ValidationEventArgs> FareAttributesChecked;
		public event EventHandler<ValidationEventArgs> FareRulesChecked;

		protected virtual void OnAgenciesChecked(AgencyCollection agencies, ValidationEventArgs e)
		{
			AgenciesChecked?.Invoke(agencies, e);
		}

		protected virtual void OnStopsChecked(StopCollection stops, ValidationEventArgs e)
		{
			StopsChecked?.Invoke(stops, e);
		}

		protected virtual void OnRoutesChecked(RouteCollection routes, ValidationEventArgs e)
		{
			RoutesChecked?.Invoke(routes, e);
		}

		protected virtual void OnTripsChecked(TripCollection trips, ValidationEventArgs e)
		{
			TripsChecked?.Invoke(trips, e);
		}

		protected virtual void OnStopTimesChecked(StopTimeCollection stopTimes, ValidationEventArgs e)
		{
			StopTimesChecked?.Invoke(stopTimes, e);
		}

		protected virtual void OnCalendarsChecked(CalendarCollection calendars, ValidationEventArgs e)
		{
			CalendarsChecked?.Invoke(calendars, e);
		}

		protected virtual void OnCalendarsChecked(CalendarDateCollection calendarDates, ValidationEventArgs e)
		{
			CalendarDatesChecked?.Invoke(calendarDates, e);
		}

		protected virtual void OnFareAttributesChecked(FareAttributeCollection fareAttributes, ValidationEventArgs e)
		{
			FareAttributesChecked?.Invoke(fareAttributes, e);
		}

		protected virtual void OnFareAttributesChecked(FareRuleCollection fareRules, ValidationEventArgs e)
		{
			FareRulesChecked?.Invoke(fareRules, e);
		}

		public void Visit(AgencyCollection agencies)
		{
			OnAgenciesChecked(agencies, new ValidationEventArgs(CheckValidity(agencies)));
		}

		public void Visit(StopCollection stops)
		{
			OnStopsChecked(stops, new ValidationEventArgs(CheckValidity(stops)));
		}

		public void Visit(RouteCollection routes)
		{
			OnRoutesChecked(routes, new ValidationEventArgs(CheckValidity(routes)));
		}

		public void Visit(TripCollection trips)
		{
			OnTripsChecked(trips, new ValidationEventArgs(CheckValidity(trips)));
		}

		public void Visit(StopTimeCollection stopTimes)
		{
			OnStopTimesChecked(stopTimes, new ValidationEventArgs(CheckValidity(stopTimes)));
		}

		public void Visit(CalendarCollection calendars)
		{
			OnCalendarsChecked(calendars, new ValidationEventArgs(CheckValidity(calendars)));
		}

		public void Visit(CalendarDateCollection calendarDates)
		{
			OnCalendarsChecked(calendarDates, new ValidationEventArgs(CheckValidity(calendarDates)));
		}

		public void Visit(FareAttributeCollection fareAttributes)
		{
			OnFareAttributesChecked(fareAttributes, new ValidationEventArgs(CheckValidity(fareAttributes)));
		}

		public void Visit(FareRuleCollection fareRules)
		{
			OnFareAttributesChecked(fareRules, new ValidationEventArgs(CheckValidity(fareRules)));
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

		private bool CheckValidity<T>(HashSet<T> items) where T : Entity
		{
			if (items.Count <= 0)
				return false;

			foreach (T item in items)
			{
				IEnumerable<PropertyInfo> requiredProperties = GetRequiredProperties(item);
				foreach (var requiredProperty in requiredProperties)
				{
					if (requiredProperty.GetValue(item) == null)
						return false;
				}
			}

			return true;
		}


		private IEnumerable<PropertyInfo> GetRequiredProperties(Entity entity)
		{
			return entity.GetType().GetProperties().Where((pi, index) => Attribute.IsDefined(pi, typeof(RequiredAttribute)));
		}
	}
}