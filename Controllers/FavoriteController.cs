using MarvelMasterApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMasterApi.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Favoritos()
        {

                RetornoIndex favRetorno = new RetornoIndex();
                favRetorno = DataContoller.Dados();

                ViewBag.fav = favRetorno.fav;
                ViewBag.pId = favRetorno.arrayPersonagemID;
                ViewBag.pNome = favRetorno.arrayPersonagemNome;
                ViewBag.pDesc = favRetorno.arrayPersonagemDescricao;
                ViewBag.limit = favRetorno.limit;

                return View("Views/Favorite/Favorite.cshtml");

        }
    }
}
