using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GlassRepository : IRepository<Glass>
    {
        ShopModel context = new ShopModel();
        ~GlassRepository()
        {
            context.Dispose();
        }

        public void Create(Glass item)
        {
            context.Glass.Add(item);
        }

        public void Delete(int id)
        {
            context.Glass.Remove(Get(id));
        }

        public Glass Get(int id)
        {
            return context.Glass.Find(id);
        }

        public IEnumerable<Glass> GetAll()
        {
            return context.Glass;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Glass item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
