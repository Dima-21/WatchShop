using AutoMapper;
using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Manufacturer, ManufacturerDTO>();
                cfg.CreateMap<Country, CountryDTO>();
                cfg.CreateMap<Watch, WatchDTO>()
                    .ForMember("Model", opt => opt.MapFrom(x => x.model))
                    .ForMember("Manufacturer", opt => opt.MapFrom(x => x.Manufacturer.name));
            });
        }
    }
}
