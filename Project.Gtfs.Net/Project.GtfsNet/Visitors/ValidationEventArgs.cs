namespace GtfsNet.Visitors
{
	public class ValidationEventArgs
	{
		public bool IsValid { get; set; }

		public ValidationEventArgs(bool isValid)
		{
			IsValid = isValid;
		}
	}
}