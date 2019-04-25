using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatchShop.Controllers
{
    [Authorize(Roles ="Admin")]
    public class GoodsManageController : Controller
    {
        IService<WatchDTO> watchService;
        public GoodsManageController(IService<WatchDTO> watchService)
        {
            this.watchService = watchService;
        }
        // GET: GoodsManage
        public ActionResult Index()
        {
            return View(watchService);
        }

        // GET: GoodsManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GoodsManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoodsManage/Create
        [HttpPost]
        public ActionResult Create(WatchDTO watchDTO)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GoodsManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GoodsManage/Edit/5
        [HttpPost]
        public ActionResult Edit(WatchDTO watch)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GoodsManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GoodsManage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
