using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLayer.Models;
using BusinessLayer.Interfaces;

namespace WebLayer.Controllers
{
    public class TestController : Controller
    {
        IEmployeeBusiness _employeeBusiness;

        public TestController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }

        // GET: Test
        public ActionResult Index()
        {
            string result = AddEditEmployee();
            string employeeName = _employeeBusiness.getEmployeeName(21);

            ViewBag.Employee = employeeName;


            List<EmployeeDomainModel> employeeDomainModels = _employeeBusiness.GetAllEmployee();

            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            ViewBag.EmployeeList = AutoMapper.Mapper.Map(employeeDomainModels, employeeViewModels);


            return View();
        }

        public string AddEditEmployee()
        {
            string result = "";
            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                EmployeeID = 1030,
                Address = "Comuna 13",
                Name = "Jose",
                DepartmentId = 1
            };

            EmployeeDomainModel employeeDomainModel = new EmployeeDomainModel();
            AutoMapper.Mapper.Map(employeeViewModel, employeeDomainModel);
            result = _employeeBusiness.AddUpdateEmployee(employeeDomainModel);
            return result;
        }
    }
}