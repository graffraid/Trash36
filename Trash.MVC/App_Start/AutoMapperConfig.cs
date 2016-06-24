namespace Trash.MVC.App_Start
{
    using AutoMapper;

    using Trash.Domain.Entities;
    using Trash.Infrastructure.Models;

    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.CreateMap<VehicleBrand, VehicleBrandModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.Title, opt => opt.MapFrom(x => x.Title))
                .ForMember(x => x.LogoUrl, opt => opt.MapFrom(x => x.LogoUrl));
        }
    }
}