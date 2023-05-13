using Microsoft.AspNetCore.Mvc;
using PortafolioWeb.Models;
using System.Diagnostics;

namespace PortafolioWeb.Controllers
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
            var proyectos = obtenerPortafolio().ToList();
            var modelo = new HomeIndexViewModel { portafolioDTO = proyectos };
            return View(modelo);
        }

        private List<PortafolioDTO> obtenerPortafolio()
        {

            return new List<PortafolioDTO> { new PortafolioDTO

                {
                    titulo = "Tek Experts",
                    descripcion = "Technical Support Engineer Lvl2",
                    imagenURL = "/img/tek-experts.png",
                    link = "https://www.tek-experts.com/"
                }
            };
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