using AutoMapper;
using AutoMapperConsole.Entity;
using AutoMapperConsole.ViewModel;

namespace AutoMapperConsole.Maps.Profiles
{
    public class CameraProfile : Profile
    {
        public CameraProfile()
        {
            var map = CreateMap<Camera, CameraVM>();

            //Add custom mappings

            map.BeforeMap((src, dest) => dest.IdPreCalculated = src.Id * 10);

            //-Model
            //-Description

            map.ForMember(dest => dest.Manufacturer,
                              opts => opts.MapFrom(src => src.Company.Name));

            //Add custom mappings after
            map.AfterMap((src, dest) => dest.PropertyCalculated = CameraVM.Calculate(src.Model));
        }
    }
}