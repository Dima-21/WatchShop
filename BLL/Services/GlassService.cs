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
    class GlassService : IService<GlassDTO>
    {
        IRepository<Glass> repo;
        public GlassService(IRepository<Glass> repo)
        {
            this.repo = repo;
        }
        public void Add(GlassDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(GlassDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GlassDTO> GetAll()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Glass, GlassDTO>());
            var glasses = Mapper.Map<IEnumerable<Glass>, IEnumerable<GlassDTO>>(repo.GetAll());
            return glasses;
        }
    }
}
