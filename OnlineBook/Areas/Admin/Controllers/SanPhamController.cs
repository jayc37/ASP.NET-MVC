using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBook.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var sanphamdao = new SanPhamDao();
            var model = sanphamdao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new SanPhamDao().Delete(id);
            return RedirectToAction("Index");
        }

        public void UploadCreateDir(HttpPostedFileWrapper upload)
        {
            var Pathfile = "/FILEs/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/Image/";
            var filename = Path.GetFileName(upload.FileName);
            bool exsits = System.IO.Directory.Exists(Server.MapPath(Pathfile));
            if (!exsits)
                System.IO.Directory.CreateDirectory(Server.MapPath(Pathfile));
            var path = Path.Combine(Server.MapPath(Pathfile), filename);
            upload.SaveAs(path);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SanPham spham, HttpPostedFileBase HINHANH)
        {

            var Pathfile = "/FILEs/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/Image/";
            var filename = Path.GetFileName(HINHANH.FileName);
            bool exsits = System.IO.Directory.Exists(Server.MapPath(Pathfile));
            if (!exsits)
                System.IO.Directory.CreateDirectory(Server.MapPath(Pathfile));
            var path = Path.Combine(Server.MapPath(Pathfile), filename);
            HINHANH.SaveAs(path);
            spham.Image = Pathfile + filename;
            var sanphamdao = new SanPhamDao();
            long id = sanphamdao.Insert(spham);

            ViewBag.ThemTC = "Thêm Thành Công";
            return RedirectToAction("Create");
        }

    }
}