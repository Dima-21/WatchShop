using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class StyleRepository : IRepository<Style>
    {
        ShopModel context = new ShopModel();
        ~StyleRepository()
        {
            context.Dispose();
        }
        public void Create(Style item)
        {
            context.Style.Add(item);
        }

        public void Delete(int id)
        {
            context.Style.Remove(Get(id));
        }

        public Style Get(int id)
        {
            return context.Style.Find(id);
        }

        public IEnumerable<Style> GetAll()
        {
            return context.Style;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Style item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
