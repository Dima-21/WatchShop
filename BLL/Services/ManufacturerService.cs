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
    public class ManufacturerService : IService<ManufacturerDTO>
    {
        IRepository<Manufacturer> repo;
        public ManufacturerService(IRepository<Manufacturer> repo)
        {
            this.repo = repo;
        }
        public void Add(ManufacturerDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ManufacturerDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ManufacturerDTO> GetAll()
        {
            var manufacturers = Mapper.Map<IEnumerable<Manufacturer>, IEnumerable<ManufacturerDTO>>(repo.GetAll());
            return manufacturers;
        }
    }
}
