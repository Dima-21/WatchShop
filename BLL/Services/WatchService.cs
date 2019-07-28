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
            string fullPath = $"{watchDTO.FolderImg}\\{folderName}";
            Directory.CreateDirectory(fullPath);
            //

            // Save path in DB
            string relativePath = $"~\\Pictures\\{folderName}";
            watch.folder_img = relativePath;
            repo.Update(watch);
            repo.Save();
            for (int i = 0; i < watchDTO.Img.Count; i++)
            {
                    File.WriteAllBytes($@"{fullPath}\\image{i}{watchDTO.Img[i].TypeImg}", watchDTO.Img[i].Img);
            }

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
