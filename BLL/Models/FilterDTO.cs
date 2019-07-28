using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    class FilterDTO
    {
        public IEnumerable<Material> Materials { get; set; }
        public IEnumerable<Manufacturer>  Manufacturers { get; set; }
        public IEnumerable<Glass> Glasses { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Wtype> Types { get; set; }
        public IEnumerable<Style> Styles { get; set; }
    }       
}
