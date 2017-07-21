using AutoMapperConsole.Entity;
using System.Collections.Generic;

namespace AutoMapperConsole
{
    public class HelperList
    {
        public static List<Camera> GetList()
        {
            return new List<Camera>()
            {
                new Camera() { Id=1,
                               Description="Nikon D5300 DSLR Camera with 18-55mm Lens (Black)",
                               Company= new Company() { Id=100, Name="Nikon" },
                               Model="D5300"
                }
                ,  new Camera() { Id=2,
                               Description="Nikon D3300 DSLR Camera with 70-300mm Lens (Red)",
                               Company= new Company() { Id=100, Name="Nikon" },
                               Model="D3300"
                }
            };
        }
    }
}