using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatchShop.Models
{
    public class AddGoodViewModel
    {
        [Required]
        [Display(Name = "Модель")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Вес")]
        public int Weight { get; set; }

        [Required]
        [Display(Name = "Производитель")]
        public string Manufacturer { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ManufacturerId { get; set; }

        [Required]
        [Display(Name = "Стиль")]
        public string Style { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int StyleId { get; set; }

        [Required]
        [Display(Name = "Страна производства")]
        public string Country { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "Тип механизма")]
        public string WType { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int WTypeId { get; set; }

        [Required]
        [Display(Name = "Стекло")]
        public string Glass { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int GlassId { get; set; }

        [Required]
        [Display(Name = "Материал")]
        public string Material { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int MaterialId { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        //[MaxLength(10, ErrorMessage = "Максимальное количество фото - 10")]
        [Display(Name = "Фото")]
        public HttpPostedFileBase Img { get; set; }
    }
}