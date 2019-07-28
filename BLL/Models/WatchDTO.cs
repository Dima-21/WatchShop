using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class WatchDTO
    {
       
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Модель")]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Вес, г")]
        public int Weight { get; set; }

  

        [ScaffoldColumn(false)]
        public int ManufacturerId { get; set; }

        [Required]
        [Display(Name = "Производитель")]
        public string Manufacturer { get; set; }

        [ScaffoldColumn(false)]
        public int StyleId { get; set; }

        [Display(Name = "Стиль")]
        public string Style { get; set; }

        [ScaffoldColumn(false)]
        public int CountryId { get; set; }

        [Display(Name = "Страна")]
        public string Country { get; set; }

        [ScaffoldColumn(false)]
        public int WTypeId { get; set; }

        [Display(Name = "Механизм")]
        public string WType { get; set; }

        [ScaffoldColumn(false)]
        public int GlassId { get; set; }

        [Display(Name = "Стекло")]
        public string Glass { get; set; }

        [ScaffoldColumn(false)]
        public int MaterialId { get; set; }

        [Display(Name = "Материал")]
        public string Material { get; set; }

        [Display(Name = "Фото")]
        public List<ImgInfo> Img { get; set; }

        public string FolderImg { get; set; }

        public WatchDTO()
        {
            Img = new List<ImgInfo>();
        }

    }
}
