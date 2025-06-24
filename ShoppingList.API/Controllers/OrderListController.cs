using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shopping_List.Controllers
{
    public class OrderListController : Controller
    {
        // GET: OrderListController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderListController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderListController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderListController/Create
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
                return View();
            }
        }

        // GET: OrderListController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderListController/Edit/5
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

        // GET: OrderListController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderListController/Delete/5
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
