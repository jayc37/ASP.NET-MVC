using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class SanPhamDao
    {
        OnlineBookDbcontext db = null;
        public SanPhamDao()
        {
            db = new OnlineBookDbcontext();
        }
        public List<SanPham> ListAll()
        {
            return db.SanPhams.Where(x => x.Status == true).OrderBy(x => x.CreatedDate).ToList();
        }
        public List<SanPham> ListNewProduct(int top)
        {
            return db.SanPhams.OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }
        public List<SanPham> ListHotProduct(int top)
        {
            return db.SanPhams.Where(x=> x.TopHot != null && x.TopHot < DateTime.Now).OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }
        public long Insert(SanPham entity)
        {
            db.SanPhams.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public IPagedList<SanPham> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<SanPham> model = db.SanPhams;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Name.Contains(searchString));
            }
            return model.OrderByDescending(x => x.Name).ToPagedList(page, pageSize);
        }
        public SanPham GetById(string tensanpham)
        {
            return db.SanPhams.SingleOrDefault(x => x.Name == tensanpham);
        }


        public bool Delete(int id)
        {
            try
            {
                var sanpham = db.SanPhams.Find(id);
                db.SanPhams.Remove(sanpham);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

