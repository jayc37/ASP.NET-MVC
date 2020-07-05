using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBook.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var menudao = new MenuDao();
            var model = menudao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        // GET: Admin/Menu
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Menu menu)
        {
            var menudao = new MenuDao();
            long id = menudao.Insert(menu);
            return View();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);
            return RedirectToAction("Index");
        }
    }
}