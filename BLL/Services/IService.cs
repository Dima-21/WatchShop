using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    interface IService<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
    }
}
