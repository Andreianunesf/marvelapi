using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarvelMasterApi.Context;

namespace MarvelMasterApi.Controllers
{
    public class ApiController : Controller
    {
        private ContextCharacter db = new ContextCharacter();

        // GET: ApiController
        public ActionResult Index()
        {
            
            return View(db);
        }

        // GET: ApiController/Details/5
        public ActionResult Details(int id)
        {
            return View(db);
        }

        // GET: ApiController/Create
        public ActionResult Create()
        {
            return View(db);
        }

        // POST: ApiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(db);
            }
        }

        // GET: ApiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db);
        }

        // POST: ApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(db);
            }
        }

        // GET: ApiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db);
        }

        // POST: ApiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(db);
            }
        }
    }
}
