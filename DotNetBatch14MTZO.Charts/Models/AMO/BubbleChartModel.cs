namespace DotNetBatch14MTZO.Charts.Models.AMO
{
	public class BubbleChartModel
	{
		public BubbleChartDataSet[] Data { get; set; }
	}

	public class BubbleChartDataSet
	{
		public string Label { get; set; }
		public BubbleChartData[] Data { get; set; }
	}

	public class BubbleChartData
	{
		public int R { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
	}
}
