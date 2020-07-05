using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;

namespace OnlineBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var sanPhamDao = new SanPhamDao();
            ViewBag.NewProducts = sanPhamDao.ListNewProduct(4);
            ViewBag.ListHotProducts = sanPhamDao.ListHotProduct(4);
            return View();
        }

        [ChildActionOnly]
        public ActionResult MainMenu()

        {
            var model = new MenuDao().ListbyGroupId(1);
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult MenuTop()

        {
            var model = new MenuDao().ListbyGroupId(2);
            return PartialView(model);
        }
    }
}

