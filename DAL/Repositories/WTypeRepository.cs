using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class WTypeRepository : IRepository<Wtype>
    {
        ShopModel context = new ShopModel();
        ~WTypeRepository()
        {
            context.Dispose();
        }
        public void Create(Wtype item)
        {
            context.Wtype.Add(item);
        }

        public void Delete(int id)
        {
            context.Wtype.Remove(Get(id));
        }

        public Wtype Get(int id)
        {
            return context.Wtype.Find(id);
        }

        public IEnumerable<Wtype> GetAll()
        {
            return context.Wtype;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Wtype item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
