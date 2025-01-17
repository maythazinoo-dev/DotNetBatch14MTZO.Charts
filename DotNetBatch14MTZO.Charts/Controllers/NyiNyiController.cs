using System.Xml.Linq;

using DotNetBatch14MTZO.Charts.Models.NyiNyi;
using Microsoft.AspNetCore.Mvc;


namespace DotNetBatch14MTZO.Charts.Controllers;

public class NyiNyiController : Controller
{
    

    [ActionName("barchart")]
    public IActionResult BarChart()
    {
        BarChartModel model = new BarChartModel()
        {
            Series = new BarChartSeriModel[]
            {
                new BarChartSeriModel
                {
                    Name = "Actual",
                    Data = new BarChartData[]
                    {
                        new BarChartData
                        {
                            X = "2011",
                            Y = 12,
                            Goals = new Goal[]
                            {
                                new Goal
                                {
                                    Name = "Expected",
                                    Value = 14,
                                    StrokeWidth = 2,
                                    StrokeDashArray = 2,
                                    StrokeColor = "#775DD0"
                                }
                            }
                        },
                        new BarChartData
                        {
                            X = "2012",
                            Y = 44,
                            Goals = new Goal[]
                            {
                                new Goal
                                {
                                    Name = "Expected",
                                    Value = 54,
                                    StrokeWidth = 5,
                                    StrokeHeight = 10,
                                    StrokeColor = "#775DD0"
                                }
                            }
                        },
                        new BarChartData
                        {
                            X = "2013",
                            Y = 54,
                            Goals = new Goal[]
                            {
                                new Goal
                                {
                                    Name = "Expected",
                                    Value = 52,
                                    StrokeWidth = 10,
                                    StrokeHeight = 0,
                                    StrokeLineCap = "round",
                                    StrokeColor = "#775DD0"
                                }
                            }
                        },
                        new BarChartData
                        {
                            X = "2014",
                            Y = 66,
                            Goals = new Goal[]
                            {
                                new Goal
                                {
                                    Name = "Expected",
                                    Value = 61,
                                    StrokeWidth = 10,
                                    StrokeHeight = 0,
                                    StrokeLineCap = "round",
                                    StrokeColor = "#775DD0"
                                }
                            }
                        },
                        new BarChartData
                        {
                            X = "2015",
                            Y = 81,
                            Goals = new Goal[]
                            {
                                new Goal
                                {
                                    Name = "Expected",
                                    Value = 66,
                                    StrokeWidth = 10,
                                    StrokeHeight = 0,
                                    StrokeLineCap = "round",
                                    StrokeColor = "#775DD0"
                                }
                            }
                        },
                        new BarChartData
                        {
                            X = "2016",
                            Y = 67,
                            Goals = new Goal[]
                            {
                                new Goal
                                {
                                    Name = "Expected",
                                    Value = 70,
                                    StrokeWidth = 5,
                                    StrokeHeight = 10,
                                    StrokeColor = "#775DD0"
                                }
                            }
                        }
                    }
                }
            }
        };

        
        return View(model);
    }

    [ActionName("piechart")]
    public IActionResult PieChart()
    {
        var model = new PieChartModel
        {
            Labels = new[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
            Data = new[] { 12, 19, 3, 5, 2, 3 }
        };

        return View(model);
    }
}
