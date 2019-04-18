using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Delete(int id);
        void Edit(T item);
    }
}
