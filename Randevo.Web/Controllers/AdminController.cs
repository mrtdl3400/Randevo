using Microsoft.AspNetCore.Mvc;

namespace Randevo.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {

            var rol = HttpContext.Session.GetString("Rol");

            var eposta = HttpContext.Session.GetString("Eposta");

            if (rol != "Admin" || eposta != "mertdalkran963@hotmail.com")
            {
                return RedirectToAction("GirisYap", "Giris");
            }

            return View();
        }


    }
}