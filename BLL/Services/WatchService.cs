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
        public void Add(WatchDTO item)
        {
            var watch = Mapper.Map<WatchDTO, Watch>(item);
            repo.Create(watch);
            repo.Save();
            string folder_name = repo.GetAll().FirstOrDefault(x => x.model == watch.model).id.ToString();
            // Create Folder
            Directory.CreateDirectory($"../WatchShop/Pictures/{folder_name}");
            var path_pictures = item.Img.Split(',').ToList();

            watch.folder_img = folder_name;
            repo.Update(watch);
            repo.Save();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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
