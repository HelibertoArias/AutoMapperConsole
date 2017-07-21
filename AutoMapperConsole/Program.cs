using AutoMapper;
using AutoMapperConsole.Entity;
using AutoMapperConsole.Maps;
using AutoMapperConsole.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Load once
            AutoMapperConfiguration.Configure();

            //Mapping one item
            Camera item = HelperList.GetList().First();

            CameraVM itemVM = Mapper.Map<Camera, CameraVM>(item);

            //Mapping Collections

            List<Camera> items = HelperList.GetList();

            List<CameraVM> itemsVM = Mapper.Map<List<Camera>, List<CameraVM>>(items);
        }
    }
}