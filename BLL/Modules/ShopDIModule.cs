using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Services;
using DAL;
using DAL.Repositories;
using Ninject.Modules;

namespace BLL.Modules
{
    public class ShopDIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IService<ManufacturerDTO>>().To<ManufacturerService>();
            Bind<IRepository<Manufacturer>>().To<ManufacturerRepository>();
        }
    }
}
