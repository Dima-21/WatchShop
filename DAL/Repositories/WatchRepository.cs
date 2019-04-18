using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class WatchRepository : IRepository<Watch>
    {
        ShopModel context = new ShopModel();
        ~WatchRepository()
        {
            context.Dispose();
        }
        public void Create(Watch item)
        {
            context.Watch.Add(item);
        }

        public void Delete(int id)
        {
            context.Watch.Remove(Get(id));
        }

        public Watch Get(int id)
        {
            return context.Watch.Find(id);
        }

        public IEnumerable<Watch> GetAll()
        {
            return context.Watch;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Watch item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
