using AutoMapper;
using AutoMapperConsole.Maps.Profiles;

namespace AutoMapperConsole.Maps
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //Add your profiles here
                cfg.AddProfile<CameraProfile>();
            });
        }
    }
}