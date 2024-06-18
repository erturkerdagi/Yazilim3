using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class YaziController : Controller
    {
        YaziYoneticisi yy = new YaziYoneticisi(new EFYazi());
        KategoriYoneticisi ky = new KategoriYoneticisi(new EFKategori());
        YazarYoneticisi yy2 = new YazarYoneticisi(new EFYazar());
        public IActionResult Yazilar()
        {
            var yazilar = yy.YaziGetir();
            foreach (var yazi in yazilar)
            {
                yazi.Kategori = ky.KategoriGetir(yazi.KategoriID);
                yazi.Yazar = yy2.YazarGetir(yazi.YazarID);
            }
            return View(yazilar);
        }

        public IActionResult YaziDetayi(int id) 
        {
            ViewBag.YaziID = id;
            return View(yy.YaziGetir(id));
        }
    }
}
