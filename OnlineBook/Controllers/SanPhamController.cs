using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace OnlineBook.Controllers
{
    public class SanPhamController : Controller
    {
        public ActionResult Index()
        {

            var sanPhamDao = new SanPhamDao();
            ViewBag.Product = sanPhamDao.ListAll();
            return View();
        }   
    }       
}