using Microsoft.AspNetCore.Mvc;

namespace Sleeptracker.Controllers
{
    public class AlarmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
