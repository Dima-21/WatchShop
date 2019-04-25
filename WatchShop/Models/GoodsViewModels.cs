using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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

        [Required]
        [Display(Name = "Стиль")]
        public string Style { get; set; }

        [Required]
        [Display(Name = "Страна производства")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Тип механизма")]
        public string WType { get; set; }

        [Required]
        [Display(Name = "Стекло")]
        public string Glass { get; set; }

        [Required]
        [Display(Name = "Материал")]
        public string Material { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Максимальное количество фото - 10")]
        [Display(Name = "Фото")]
        public List<string> ImgPath { get; set; }
    }
}