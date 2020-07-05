using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
   public class MenuDao
    {
        OnlineBookDbcontext db = null;
        public MenuDao()
        {
            db = new OnlineBookDbcontext();
        }
        public List<Menu> ListbyGroupId(int groupId)
        {
            return db.Menus.Where(x => x.TypeID == groupId && x.Status == true).OrderBy(x=>x.DisplayOrder).ToList();
        }
        public long Insert(Menu entity)
        {
            db.Menus.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public IPagedList<Menu> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<Menu> model = db.Menus;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.Text.Contains(searchString));
            }
            return model.OrderByDescending(x => x.Text).ToPagedList(page, pageSize);
        }
        public Menu GetById(string tenmenu)
        {
            return db.Menus.SingleOrDefault(x => x.Text == tenmenu);
        }

    }
}