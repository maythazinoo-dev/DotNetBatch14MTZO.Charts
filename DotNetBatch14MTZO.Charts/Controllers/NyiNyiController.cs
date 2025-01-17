using Microsoft.AspNetCore.Mvc;

namespace DotNetBatch14MTZO.Charts.Controllers
{
    public class NyiNyiController : Controller
    {
        [ActionName("barchart")]
        public IActionResult BarChart()
        {
            return View();
        }

        [ActionName("piechart")]
        public IActionResult PieChart()
        {
            Console.WriteLine("PieChart action hit");
            return View();
        }
    }
}
