using BLL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class ManufacturerService : IService<ManufacturerDTO>
    {
        IRepository<ManufacturerDTO> repo;
        public ManufacturerService(IRepository<ManufacturerDTO> repo)
        {
            this.repo = repo;
        }
        public void Add(ManufacturerDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ManufacturerDTO> GetAll()
        {
            return repo
                  .GetAll()
                    .Select(x => new ManufacturerDTO
                    {
                        Id = x.Id,
                        Name = x.Name
                    });
        }
    }
}
