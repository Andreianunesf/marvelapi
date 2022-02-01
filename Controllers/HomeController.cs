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
            //Personagem personagem;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                // parametros da url

                string ts = "1642539689";
                string publicKey = "89737e2b5be01e946ade4173055a5522";
                string hash = "2cd7277ab38669204ee5f5758d7e8037";
                string url = "http://gateway.marvel.com/v1/public/";
                int limit = 20;
                string linkUrl = url + "characters?ts=" + ts + "&apikey=" + publicKey + "&hash=" + hash + "&limit=" + limit;

                HttpResponseMessage response = client.GetAsync(linkUrl).Result;
                          
                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                int[] arrayPersonagemID = new int[limit];
                string[] arrayPersonagemNome = new string[limit];
                string[] arrayPersonagemDescricao = new string[limit];
                
                string stringName = "";
                string stringDescription= "";

                Personagem _personagens = new Personagem();

                for (int i= 0; i < limit; i++)
                {
                    stringName = resultado.data.results[i].name;
                    stringDescription = resultado.data.results[i].description;

                    _personagens.CriarPersonagem(i, stringName, stringDescription);

                    arrayPersonagemID[i] = i;
                    arrayPersonagemNome[i] = stringName;
                    arrayPersonagemDescricao[i] = stringDescription;
                }

                BlackList _blacklist = new BlackList();
                _blacklist.InsertBackList(2);
                _blacklist.InsertBackList(3);
                _blacklist.ReturnBlackList();

                Favorite _favorite = new Favorite();
                _favorite.InsertFavorite(2);
                _favorite.InsertFavorite(3);
                _favorite.ReturnFavorite();


            }

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