using Microsoft.AspNetCore.Mvc;

namespace Randevo.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var rol = HttpContext.Session.GetString("Rol");

            if (rol != "Admin")
            {
                return RedirectToAction("GirisYap", "Giris");
            }

            return View();
        }
    }
}