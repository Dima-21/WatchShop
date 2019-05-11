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
    class WTypeService : IService<WTypeDTO>
    {
        IRepository<Wtype> repo;
        public WTypeService(IRepository<Wtype> repo)
        {
            this.repo = repo;
        }
        public void Add(WTypeDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(WTypeDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WTypeDTO> GetAll()
        {
 
            var types = Mapper.Map<IEnumerable<Wtype>, IEnumerable<WTypeDTO>>(repo.GetAll());
            return types;
        }
    }
}
