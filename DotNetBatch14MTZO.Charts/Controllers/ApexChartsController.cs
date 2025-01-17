using Microsoft.AspNetCore.Mvc;

namespace DotNetBatch14MTZO.Charts.Controllers
{
    public class ApexChartsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }
    }
}
