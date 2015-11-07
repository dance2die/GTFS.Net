namespace GtfsNet.Visitors
{
	public interface IFeedElement
	{
		void Accept(IFeedVisitor visitor);
	}
}