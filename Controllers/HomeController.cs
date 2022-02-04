using MarvelMasterApi.Models;
using MarvelMasterApi.Models.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;


namespace MarvelMasterApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly object arrayPersonagemName;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromServices] IConfiguration config)
        {

            RetornoIndex retorno1 = new RetornoIndex();
            retorno1 = DataContoller.Dados();

            // Parametros para view

            ViewBag.limit = retorno1.limit;
            ViewBag.fav = retorno1.fav;
            ViewBag.black = retorno1.black;
            ViewBag.pId = retorno1.arrayPersonagemID;
            ViewBag.pNome = retorno1.arrayPersonagemNome;
            ViewBag.pDesc = retorno1.arrayPersonagemDescricao;


            return View("Views/Home/Index.cshtml");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}