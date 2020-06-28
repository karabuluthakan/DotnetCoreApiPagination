using Api.Entities;
using AutoMapper;

namespace Api.Dto.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityListDto>().ReverseMap();
            CreateMap<Country, CountryListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.RegionId))
                .ForMember(dest => dest.Alpha2Code, opt => opt.MapFrom(src => src.Alpha2Code))
                .ForMember(dest => dest.Alpha3Code, opt => opt.MapFrom(src => src.Alpha3Code))
                .ForMember(dest => dest.UnCode, opt => opt.MapFrom(src => src.UnCode));
            CreateMap<CountryListDto,Country>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.RegionId))
                .ForMember(dest => dest.Alpha2Code, opt => opt.MapFrom(src => src.Alpha2Code))
                .ForMember(dest => dest.Alpha3Code, opt => opt.MapFrom(src => src.Alpha3Code))
                .ForMember(dest => dest.UnCode, opt => opt.MapFrom(src => src.UnCode));
            CreateMap<Continental, ContinentalListDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                .ReverseMap();
            CreateMap<Region, RegionListDto>().ReverseMap();
        }
    }
}