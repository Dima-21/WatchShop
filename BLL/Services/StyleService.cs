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
    class StyleService : IService<StyleDTO>
    {
        IRepository<Style> repo;
        public StyleService(IRepository<Style> repo)
        {
            this.repo = repo;
        }
        public void Add(StyleDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(StyleDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StyleDTO> GetAll()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Style, StyleDTO>());
            var styles = Mapper.Map<IEnumerable<Style>, IEnumerable<StyleDTO>>(repo.GetAll());
            return styles;
        }
    }
}
