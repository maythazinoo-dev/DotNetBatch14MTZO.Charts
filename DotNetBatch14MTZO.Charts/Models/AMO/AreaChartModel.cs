namespace DotNetBatch14MTZO.Charts.Models.AMO
{
	public class AreaChartModel
	{
		public AreaChartSerieModel[] Series { get; set; }

		public string[] Labels { get; set; }
	}

	public class AreaChartSerieModel
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public int[] Data { get; set; }
	}
}
