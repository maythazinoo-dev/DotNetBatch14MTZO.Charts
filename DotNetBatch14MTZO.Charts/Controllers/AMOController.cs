using DotNetBatch14MTZO.Charts.Models.AMO;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBatch14MTZO.Charts.Controllers;

public class AMOController : Controller
{
	[ActionName("SplineAreaChart")]
	public IActionResult SplineAreaChart()
	{
		AreaChartModel model = new()
		{
			Series = new AreaChartSerieModel[]
			{
			new()
			{
				Name = "First serie",
				Type = "area",
				Data = new int[] {23,45, 12,67,89, 34, 121 }
			},
			new()
			{
				Name = "Second serie",
				Type = "area",
				Data = new int[] {32,67, 56,23,78, 43, 36 }
			}
			},
			Labels = new string[] { "April", "May", "June", "July", "August", "September", "October" }
		};
		return View(model);
	}

	[ActionName("CandlestickChart")]
	public IActionResult CandlestickChart()
	{
		
		return View();
	}

	[ActionName("BubbleChart")]
	public IActionResult BubbleChart()
	{

		

		BubbleChartData[] data1 = new BubbleChartData[] {
				  new () { R = 10, X = 4, Y = 5},
                  new () { R = 4, X = 6, Y = 3},
                  new () { R = 7, X = 4, Y = 9},
                  new () { R = 3, X = 5, Y = 7},
                  new () { R = 9, X = 3, Y = 5},
                  new () { R = 5, X = 2, Y = 5}
              };
		BubbleChartData[] data2 = new BubbleChartData[] {
				  new () { R = 2, X = 4, Y = 2},
				  new () { R = 4, X = 5, Y = 8},
				  new () { R = 6, X = 8, Y = 1},
				  new () { R = 4, X = 6, Y = 9},
				  new () { R = 8, X = 4, Y = 7},
				  new () { R = 5, X = 1, Y = 6}
			  };

		BubbleChartDataSet dataSet1 = new()
		{
			Label = "Data Set 1",
			Data = data1
		};

		BubbleChartDataSet dataSet2 = new()
		{
			Label = "Data Set 2",
			Data = data2
		};

		BubbleChartModel model = new BubbleChartModel();
		model.Data = new BubbleChartDataSet[] { dataSet1, dataSet2 };

		return View(model);
	}
}
