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
            ViewBag.black = retorno1.black;
            ViewBag.pId = retorno1.personagensValidos;
            ViewBag.pIdade = retorno1.arrayIdade;
            ViewBag.pNome = retorno1.arrayPersonagemNome;
            ViewBag.pDesc = retorno1.arrayPersonagemDescricao;
            

            Group group = new Group();
            List<int> personagensGroup = new List<int>() { 1, 3, 4, 5, 6 };
            group.CreateGroup("grupo2", personagensGroup);
            List<Group> grupo2 = group.ReturnGroup();
            //var a = grupo2[0].name;
            //var b = grupo2[0].itens[3];

            return View("Views/Home/Index.cshtml");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}