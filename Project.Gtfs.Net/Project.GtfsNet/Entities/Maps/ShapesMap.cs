using CsvHelper.Configuration;

namespace Project.GtfsNet.Entities.Maps
{
	public class ShapesMap : CsvClassMap<Shape>
	{
		public ShapesMap()
		{
			Map(e => e.Id).Name("shape_id");
			Map(e => e.Latitude).Name("shape_pt_lat");
			Map(e => e.Longitude).Name("shape_pt_lon");
			Map(e => e.Sequence).Name("shape_pt_sequence");
			Map(e => e.DistanceTraveled).Name("shape_dist_traveled");
		}
	}
}
