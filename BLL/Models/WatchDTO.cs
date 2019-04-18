using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class WatchDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public string FolderImg { get; set; }
        public int ManufacturerId { get; set; }
        public string Manufacturer { get; set; }
        public int StyleId { get; set; }
        public string Style { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }
        public int WTypeId { get; set; }
        public string WType { get; set; }
        public int GlassId { get; set; }
        public string Glass { get; set; }
        public int MaterialId { get; set; }
        public string Material { get; set; }

    }
}
