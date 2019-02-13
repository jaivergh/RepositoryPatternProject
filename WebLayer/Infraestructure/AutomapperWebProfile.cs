using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLayer.Models;

namespace WebLayer.Infraestructure
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<EmployeeViewModel, EmployeeDomainModel>();
            CreateMap<EmployeeDomainModel, EmployeeViewModel>();
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(m => m.AddProfile<AutomapperWebProfile>());
        }
    }
}