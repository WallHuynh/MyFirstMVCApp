using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;
using System.Diagnostics;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting =
            hour < 12
            ? "Good Morning. Time is" + DateTime.Now.ToShortTimeString()
            : "Good Afternoon. Time is " + DateTime.Now.ToShortTimeString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}