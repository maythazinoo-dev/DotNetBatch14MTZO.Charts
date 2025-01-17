using Microsoft.AspNetCore.Mvc;

namespace DotNetBatch14MTZO.Charts.Controllers
{
    public class NyiNyiController : Controller
    {
        [ActionName("BarChart")]
        public IActionResult BarChart()
        {
            return View();
        }
    }
}
