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
                cfg.CreateMap<Glass, GlassDTO>();
                cfg.CreateMap<Wtype, WTypeDTO>();
                cfg.CreateMap<Material, MaterialDTO>();
                cfg.CreateMap<Style, StyleDTO>();
                cfg.CreateMap<Watch, WatchDTO>()
                    .ForMember("Description", opt => opt.MapFrom(x => x.descript))
                    .ForMember("Country", opt => opt.MapFrom(x => x.Country.name))
                    .ForMember("Glass", opt => opt.MapFrom(x => x.Glass.name))
                    .ForMember("WType", opt => opt.MapFrom(x => x.Wtype.name))
                    .ForMember("Material", opt => opt.MapFrom(x => x.Material.name))
                    .ForMember("Style", opt => opt.MapFrom(x => x.Style.name))
                    .ForMember("Manufacturer", opt => opt.MapFrom(x => x.Manufacturer.name));
            });
        }
    }
}
