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
    public class WatchService : IService<WatchDTO>
    {
        IRepository<Watch> repo;
        public WatchService(IRepository<Watch> repo)
        {
            this.repo = repo;
        }
        public void Add(WatchDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(WatchDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WatchDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
