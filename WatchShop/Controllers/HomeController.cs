using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatchShop.Controllers
{
    public class HomeController : Controller            
    {
        IService<ManufacturerDTO> manufactService;
        IService<CountryDTO> countryService;
        public HomeController(IService<ManufacturerDTO> manufactService, IService<CountryDTO> countryService)
        {
            this.manufactService = manufactService;
            this.countryService = countryService;
        }
        public ActionResult Index()
        {
            ViewBag.ManufList =  manufactService.GetAll().ToList();
            ViewBag.Countries = countryService.GetAll().ToList();
            return View();
        }

  
    }
}