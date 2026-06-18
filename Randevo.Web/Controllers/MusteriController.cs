using Microsoft.AspNetCore.Mvc;
using Randevo.VeriErisimKatmani;

namespace Randevo.Web.Controllers
{
    public class MusteriController : Controller
    {
        private readonly Context _context;

        public MusteriController(Context context)
        {
            _context = context;
        }

        public IActionResult Listele()
        {
            var musteriler = _context.Musteriler.ToList();

            return View(musteriler);
        }
    }
}
