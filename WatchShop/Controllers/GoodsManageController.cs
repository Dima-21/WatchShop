using AutoMapper;
using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.IO;
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
            return View(new AddGoodViewModel());
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

            // Images download to watchDTO
            var folder = Server.MapPath("~/Pictures");
            watchDTO.FolderImg = folder;

            foreach (var img in watchVM.Img)
            {
                ImgInfo imgInfo = new ImgInfo();
                imgInfo.Img = new byte[img.ContentLength];
                img.InputStream.Read(imgInfo.Img, 0, img.ContentLength);
                imgInfo.TypeImg = Path.GetExtension(img.FileName);
                watchDTO.Img.Add(imgInfo);
            }

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

        public string GetImage(int id)
        {
            string image;
            string path = Server.MapPath($"~\\Pictures\\{id}");
            bool isDirectory = System.IO.Directory.Exists(path);
            if (isDirectory)
            {
                image = Directory.EnumerateFiles(path).FirstOrDefault();
                path = $"Pictures/{id}/{Path.GetFileName(image)}";
            }
            else
                return null;

            return path;
        }

        public FileContentResult GetImages(params HttpPostedFileBase[] image)
        {
            byte[] img;
            if (image != null)
            {
                img = new byte[image[0].ContentLength];
                image[0].InputStream.Read(img, 0, image[0].ContentLength);
            }
            else
                return null;
         
            return File(img,image[0].ContentType);
        }


        // POST: GoodsManage/Delete/5

    }
}
