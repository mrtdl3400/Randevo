using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Randevo.VarlikKatmani;
using Randevo.VeriErisimKatmani;
using System.Linq;





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

        [HttpPost]
        public IActionResult GirisYap(string eposta, string sifre)
        {
            var kullanici = _context.Kullanicilar
                .FirstOrDefault(x => x.Eposta == eposta && x.Sifre == sifre);

            if (kullanici == null)
            {
                ViewBag.Hata = "E-posta veya şifre hatalı";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
