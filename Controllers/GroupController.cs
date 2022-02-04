using MarvelMasterApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarvelMasterApi.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Grupos()
        {
            RetornoIndex groupRetorno = new RetornoIndex();
            groupRetorno = DataContoller.Dados();

            ViewBag.group = groupRetorno.groups;
            ViewBag.pId = groupRetorno.arrayPersonagemID;
            ViewBag.pNome = groupRetorno.arrayPersonagemNome;
            ViewBag.pDesc = groupRetorno.arrayPersonagemDescricao;
            ViewBag.limit = groupRetorno.limit;

            return View("Views/Groups/Groups.cshtml");
        }
    }
}
