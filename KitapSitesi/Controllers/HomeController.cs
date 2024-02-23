using KitapSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KitapSitesi.Controllers
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
            KitapModel kitap = new KitapModel();
            kitap.KitapId = 1;
            kitap.KitapAd = "Metro 2033";
            kitap.SayfaSayisi = 630;
            kitap.Yazar = "Dmitri Gluhovski";
            kitap.Tur = "roman";
            ViewBag.Kitap = kitap;
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