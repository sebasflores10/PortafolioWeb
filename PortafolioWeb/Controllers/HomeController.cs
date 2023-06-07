using Microsoft.AspNetCore.Mvc;
using PortafolioWeb.Models;
using PortafolioWeb.Services;
using System.Diagnostics;

namespace PortafolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository repo; // Interfaz creada en el archivo ProjectsRepository.cs

        //private readonly TestSingleton singleton;
        //private readonly TestScoped scoped;
        //private readonly TestTransient transient;

        public HomeController(ILogger<HomeController> logger, IProjectsRepository repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        //public HomeController(ILogger<HomeController> logger, IProjectsRepository repo, 
        //    TestSingleton singleton,
        //    TestScoped scoped,
        //    TestTransient transient)
        //{
        //    _logger = logger;
        //    this.repo = repo;
        //    this.singleton = singleton;
        //    this.scoped = scoped;
        //    this.transient = transient;
        //}

        public IActionResult Index()
        {
            var proyectos = repo.obtenerPortafolio().ToList();

            var modelo = new HomeIndexViewModel { 
                portafolioDTO = proyectos
            };
            return View(modelo);
        }

        // EJEMPLO SERVICIOS //
        /// ////////////////////////////////////////////////////// 
        /// <summary>
        /// Demuestra el funcionamiento de los servicios definidos en el archivo Program.cs
        /// Existen 3 tipos de servicios, los cuales son:
        /// 1) Singleton
        /// 2) Scoped
        /// 3) Transient
        /// </summary>
        /// <returns>
        /// Singleton: Un mismo valor en toda la ejecución de la aplicación
        /// Scoped: Mismo valor de una misma petición HTTP
        /// Transient: Valor más corto del ciclo de vida de la petición. Por cada petición, su valor cambia
        /// </returns>
        /// 
        //public IActionResult Index()
        //{
        //    var proyectos = repo.obtenerPortafolio().ToList();
        //    var guid = new ExampleViewModel()
        //    {
        //        xSingleton = singleton.obtenerGuid,
        //        xScoped = scoped.obtenerGuid,
        //        xTransient = transient.obtenerGuid
        //    };

        //    var modelo = new HomeIndexViewModel
        //    {
        //        portafolioDTO = proyectos,
        //        exampleViewModel = guid
        //    };
        //    return View(modelo);
        //}

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