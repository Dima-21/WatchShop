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
    public class CountryService : IService<CountryDTO>
    {
        IRepository<Country> repo;
        public CountryService(IRepository<Country> repo)
        {
            this.repo = repo;
        }
        public void Add(CountryDTO item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CountryDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CountryDTO> GetAll()
        {
        
            var countries = Mapper.Map<IEnumerable<Country>, IEnumerable<CountryDTO>>(repo.GetAll());
            return countries;
        }
    }
}
