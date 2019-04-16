using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MaterialRepository : IRepository<Material>
    {
        ShopModel context = new ShopModel();
        ~MaterialRepository()
        {
            context.Dispose();
        }
        public void Create(Material item)
        {
            context.Material.Add(item);
        }

        public void Delete(int id)
        {
            context.Material.Remove(Get(id));
        }

        public Material Get(int id)
        {
            return context.Material.Find(id);
        }

        public IEnumerable<Material> GetAll()
        {
            return context.Material;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Material item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
