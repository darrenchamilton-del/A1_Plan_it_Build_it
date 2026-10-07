using Microsoft.AspNetCore.Mvc;
using SleepTracker.Models;

namespace SleepTracker.Controllers
{
    public class SleepLogControllerbak : Controller
    {
        private static List<SleepAndHabitLog> records = new List<SleepAndHabitLog>();

        public IActionResult Index()
        {
            return View(records);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SleepAndHabitLog record)
        {
            if (record.SleepQuality < 1 || record.SleepQuality > 10)
            {
                ModelState.AddModelError("SleepQuality", "Sleep quality must be between 1 and 10.");
                return View(record);
            }

            records.Add(record);

            return RedirectToAction("Index");
        }
    }
}