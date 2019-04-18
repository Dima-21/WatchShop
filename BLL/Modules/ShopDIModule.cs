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
            Bind<IService<CountryDTO>>().To<CountryService>();
            Bind<IService<StyleDTO>>().To<StyleService>();
            Bind<IService<GlassDTO>>().To<GlassService>();
            Bind<IService<MaterialDTO>>().To<MaterialService>();
            Bind<IService<WTypeDTO>>().To<WTypeService>();
            Bind<IService<WatchDTO>>().To<WatchService>();
            Bind<IService<ManufacturerDTO>>().To<ManufacturerService>();
            Bind<IRepository<Manufacturer>>().To<ManufacturerRepository>();
            Bind<IRepository<Country>>().To<CountryRepository>();
            Bind<IRepository<Style>>().To<StyleRepository>();
            Bind<IRepository<Glass>>().To<GlassRepository>();
            Bind<IRepository<Material>>().To<MaterialRepository>();
            Bind<IRepository<Watch>>().To<WatchRepository>();
            Bind<IRepository<Wtype>>().To<WTypeRepository>();
        }
    }
}
