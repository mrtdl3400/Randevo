using Microsoft.AspNetCore.Mvc;
using Randevo.Web.Models;
using System.Diagnostics;

namespace Randevo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult AdminPanel()
        {
            if (HttpContext.Session.GetString("Rol") != "Admin")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Rol") == null)
            {
                return RedirectToAction("GirisYap", "Giris");
            }

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
