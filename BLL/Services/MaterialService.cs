using AutoMapper;
using BLL.Models;
using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class MaterialService : IService<MaterialDTO>
    {
        IRepository<Material> repo;
        public MaterialService(IRepository<Material> repo)
        {
            this.repo = repo;
        }
        public void Add(MaterialDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(MaterialDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaterialDTO> GetAll()
        {
            
            var materials = Mapper.Map<IEnumerable<Material>, IEnumerable<MaterialDTO>>(repo.GetAll());
            return materials;
        }
    }
}
