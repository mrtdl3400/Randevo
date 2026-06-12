using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Randevo.VarlikKatmani;
using Randevo.VeriErisimKatmani;




namespace Randevo.Web.Controllers
{
    public class GirisController : Controller
    {
        private readonly Context _context;

        public GirisController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayitOl(Kullanici kullanici)
        {
            kullanici.KayitTarihi = DateTime.Now;
            kullanici.Rol = "Kullanici";

            _context.Kullanicilar.Add(kullanici);
            _context.SaveChanges();

            return RedirectToAction("GirisYap");
        }

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
