using MarvelMasterApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMasterApi.Controllers
{
    public class BlackListController : Controller
    {
        public IActionResult BlackList()
        {
            RetornoIndex blRetorno = new RetornoIndex();
            blRetorno = DataContoller.Dados();

            ViewBag.black = blRetorno.black;
            ViewBag.pId = blRetorno.arrayPersonagemID;
            ViewBag.pNome = blRetorno.arrayPersonagemNome;
            ViewBag.pDesc = blRetorno.arrayPersonagemDescricao;
            ViewBag.limit = blRetorno.limit;

            return View("Views/BlackList/BlackList.cshtml");
        }
    }
}
