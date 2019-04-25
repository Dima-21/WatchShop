using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class HomeController : Controller            
    {
        IService<WatchDTO> watchService;
        public HomeController(IService<WatchDTO> watchService)
        {
            this.watchService = watchService;
        }
        public ActionResult Index()
        {
            ViewBag.Watch = watchService.GetAll().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult AddGood(AddGoodViewModel addGoodVM)
        {

            return View();
        }


    }
}