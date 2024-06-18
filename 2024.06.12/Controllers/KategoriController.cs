using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class KategoriController : Controller
    {
        KategoriYoneticisi ky = new KategoriYoneticisi(new EFKategori());
        public IActionResult Kategoriler()
        {
            return View(ky.KategoriGetir());
        }
    }
}
