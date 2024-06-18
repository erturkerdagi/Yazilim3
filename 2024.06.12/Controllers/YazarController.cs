using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class YazarController : Controller
    {
        YazarYoneticisi yy = new YazarYoneticisi(new EFYazar());
        public IActionResult Yazarlar()
        {
            return View(yy.YazarGetir());
        }
    }
}
