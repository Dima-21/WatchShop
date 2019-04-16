using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ManufacturerRepository : IRepository<Manufacturer>
    {
        ShopModel context = new ShopModel();
        ~ManufacturerRepository()
        {
            context.Dispose();
        }
        public void Create(Manufacturer item)
        {
            context.Manufacturer.Add(item);
        }

        public void Delete(int id)
        {
            context.Manufacturer.Remove(Get(id));
        }

        public Manufacturer Get(int id)
        {
            return context.Manufacturer.Find(id);
        }

        public IEnumerable<Manufacturer> GetAll()
        {
            return context.Manufacturer;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Manufacturer item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
