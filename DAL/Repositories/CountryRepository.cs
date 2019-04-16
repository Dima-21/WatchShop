using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CountryRepository : IRepository<Country>
    {
        ShopModel context = new ShopModel();
        ~CountryRepository()
        {
            context.Dispose();
        }
        public void Create(Country item)
        {
            context.Country.Add(item);
        }

        public void Delete(int id)
        {
            context.Country.Remove(Get(id));
        }

        public Country Get(int id)
        {
            return context.Country.Find(id);
        }

        public IEnumerable<Country> GetAll()
        {
            return context.Country;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Country item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified; 
        }
    }
}
