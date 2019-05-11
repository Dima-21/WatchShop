using AutoMapper;
using BLL.Models;
using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class WatchService : IService<WatchDTO>
    {
        IRepository<Watch> repo;
        public WatchService(IRepository<Watch> repo)
        {
            this.repo = repo;
        }

        public void Add(WatchDTO watchDTO)
        {
            var watch = Mapper.Map<WatchDTO, Watch>(watchDTO);
            watch.Country = null;
            watch.Glass = null;
            watch.Manufacturer = null;
            watch.Material = null;
            watch.Style = null;
            watch.Wtype = null;
            repo.Create(watch);
            repo.Save();
            string folderName = repo.GetAll().FirstOrDefault(x => x.model == watch.model).id.ToString();
            // Create Folder

            watchDTO.Img.Folder += "\\folderName";
            //var folder = ($"~/../Pictures/{folderName}");

            Directory.CreateDirectory(watchDTO.Img.Folder);

            watch.folder_img = folderName;
            repo.Update(watch);
            repo.Save();
            File.WriteAllBytes($@"{watchDTO.Img.Folder}\\main.{watchDTO.Img.TypeImg}", watchDTO.Img.Img);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
            repo.Save();
        }

        public void Edit(WatchDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WatchDTO> GetAll()
        {
            var watch = Mapper.Map<IEnumerable<Watch>, IEnumerable<WatchDTO>>(repo.GetAll());
            
            return watch;
        }
    }
}
