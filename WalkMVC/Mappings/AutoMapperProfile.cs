using AutoMapper;
using WalkMVC.Models;
using WalkMVC.Models.Dto;

namespace WalkMVC.Mappings
{   // class for mapping
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Region, AddRegionDto>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
        }
    }
}
