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
    class FilterService : IFilterService<FilterDTO>
    {
        IRepository<Watch> repo{ get; set; }

        public IEnumerable<Watch> GetFilteredGoods(FilterDTO filter)
        {
            throw new NotImplementedException();
        }

        public FilterDTO GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
