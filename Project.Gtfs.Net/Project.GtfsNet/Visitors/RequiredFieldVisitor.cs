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

		protected virtual void OnAgenciesChecked(AgencyCollection agencies, ValidationEventArgs e)
		{
			AgenciesChecked?.Invoke(agencies, e);
		}

		protected virtual void OnAgenciesChecked(StopCollection stops, ValidationEventArgs e)
		{
			StopsChecked?.Invoke(stops, e);
		}

		public void Visit(AgencyCollection agencies)
		{
			OnAgenciesChecked(agencies, new ValidationEventArgs(CheckValidity(agencies)));
		}

		public void Visit(StopCollection stops)
		{
			OnAgenciesChecked(stops, new ValidationEventArgs(CheckValidity(stops)));
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

		private bool CheckValidity<T>(HashSet<T> items) where T : Entity
		{
			if (items.Count <= 0)
				return false;

			foreach (T item in items)
			{
				IEnumerable<PropertyInfo> requiredProperties = GetRequiredProperties(item);
				if (requiredProperties.Any(requiredProperty => requiredProperty.GetValue(item) == null))
					return false;
			}

			return true;
		}


		private IEnumerable<PropertyInfo> GetRequiredProperties(Entity entity)
		{
			return entity.GetType().GetProperties().Where((pi, index) => Attribute.IsDefined(pi, typeof(RequiredAttribute)));
		}
	}
}