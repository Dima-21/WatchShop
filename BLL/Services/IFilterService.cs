using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IFilterService<T>
    {
        T GetItems();
        IEnumerable<Watch> GetFilteredGoods(T filter);
    }
}
