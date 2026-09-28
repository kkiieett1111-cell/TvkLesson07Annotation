using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TvkLesson07Annotation.Models;

namespace TvkLesson07Annotation.Controllers
{
    public class TvkMembersController : Controller
    {
        private static List<TvkMember> tvkMembers = new List<TvkMember>();

        // GET: TvkMembersController
        public ActionResult Index()
        {
            return View(tvkMembers);
        }

        // GET: TvkMembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TvkMembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TvkMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TvkMember tvkMember)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(tvkMember);
                }
                tvkMembers.Add(tvkMember);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TvkMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TvkMembersController/Edit/5
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
                return View();
            }
        }

        // GET: TvkMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TvkMembersController/Delete/5
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
                return View();
            }
        }
    }
}
