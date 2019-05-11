using AutoMapper;
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
    [Authorize(Roles = "Admin")]
    public class GoodsManageController : Controller
    {
        IService<WatchDTO> watchService;
        IService<CountryDTO> countryService;
        IService<GlassDTO> glassService;
        IService<ManufacturerDTO> manufService;
        IService<MaterialDTO> materialService;
        IService<StyleDTO> styleService;
        IService<WTypeDTO> wtypeService;
        public GoodsManageController(IService<WatchDTO> watchService,
                                     IService<CountryDTO> countryService,
                                     IService<GlassDTO> glassService,
                                     IService<ManufacturerDTO> manufService,
                                     IService<MaterialDTO> materialService,
                                     IService<StyleDTO> styleService,
                                     IService<WTypeDTO> wtypeService)
        {
            this.watchService = watchService;
            this.countryService = countryService;
            this.glassService = glassService;
            this.manufService = manufService;
            this.materialService = materialService;
            this.styleService = styleService;
            this.wtypeService = wtypeService;
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
            ViewBag.Countries = new SelectList(countryService.GetAll(), "id", "name");
            ViewBag.Glasses = new SelectList(glassService.GetAll(), "id", "name");
            ViewBag.Manufacturers = new SelectList(manufService.GetAll(), "id", "name");
            ViewBag.Materials = new SelectList(materialService.GetAll(), "id", "name");
            ViewBag.Styles = new SelectList(styleService.GetAll(), "id", "name");
            ViewBag.Types = new SelectList(wtypeService.GetAll(), "id", "name");
            return View();
        }

        // POST: GoodsManage/Create
        [HttpPost]
        public ActionResult Create(AddGoodViewModel watchVM)
        {

            WatchDTO watchDTO = new WatchDTO();
            watchDTO.Country = watchVM.Country;
            watchDTO.Description = watchVM.Description;
            watchDTO.Glass = watchVM.Glass;
            watchDTO.Manufacturer = watchVM.Manufacturer;
            watchDTO.Material = watchVM.Material;
            watchDTO.Model = watchVM.Model;
            watchDTO.Price = watchVM.Price;
            watchDTO.Style = watchVM.Style;
            watchDTO.Weight = watchVM.Weight;
            watchDTO.WType = watchVM.WType;
            watchDTO.CountryId = watchVM.CountryId;
            watchDTO.StyleId = watchVM.StyleId;
            watchDTO.WTypeId = watchVM.WTypeId;
            watchDTO.GlassId = watchVM.GlassId;
            watchDTO.ManufacturerId = watchVM.ManufacturerId;
            watchDTO.MaterialId = watchVM.MaterialId;
         

            // 
            //item.Img = watchVM.ImgPath[0].InputStream.WriteByte();
            //foreach (var img in watchVM.Img)
            //{
            //    watchDTO.ImgFolder.Add(new ImgInfo());
            //    watchDTO.ImgFolder.Last().Img = new byte[img.ContentLength];
            //    img.InputStream.Read(watchDTO.ImgFolder.Last().Img, 0, img.ContentLength);
            //    watchDTO.ImgFolder.Last().TypeImg = img.FileName.Substring(img.FileName.IndexOf('.'));
            //}

            //foreach (var watch in watchVM.ImgPath)
            //{
            //    item.Img
            //}

           var folder = Server.MapPath("~/Pictures");
            ImgInfo img = new ImgInfo();
            img.Folder = folder;
            img.Img = new byte[watchVM.Img.ContentLength];
            watchVM.Img.InputStream.Read(img.Img, 0, watchVM.Img.ContentLength);
            img.TypeImg = watchVM.Img.FileName.Substring(watchVM.Img.FileName.IndexOf('.'));

            watchDTO.Img = img;
            watchService.Add(watchDTO);

            return RedirectToAction("Index");

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
            watchService.Delete(id);

            return RedirectToAction("Index");
        }

        // POST: GoodsManage/Delete/5
     
    }
}
