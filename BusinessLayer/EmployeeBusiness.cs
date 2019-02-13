using BusinessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Infrastructure.Contract;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusiness : IEmployeeBusiness
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly EmployeeRepository employeeRepository;
        private readonly DepartmentRepository departmentRepository;

        public EmployeeBusiness(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            employeeRepository = new EmployeeRepository(unitOfWork);
            departmentRepository = new DepartmentRepository(unitOfWork);
        }



        public string AddUpdateEmployee(EmployeeDomainModel employeeDomainModel)
        {

            string result = "";

            if (employeeDomainModel.EmployeeID > 0)
            {
                Employee employee = employeeRepository.SingleOrDefault(x => x.EmployeeID == employeeDomainModel.EmployeeID);

                if (employee != null)
                {
                    employee.DepartmentId = employeeDomainModel.DepartmentId;
                    employee.Address = employeeDomainModel.Address;
                    employee.Name = employeeDomainModel.Name;
                    employeeRepository.Update(employee);
                    result = "updated";
                }
            }
            else
            {
                Employee employee = new Employee();
                employee.DepartmentId = employeeDomainModel.DepartmentId;
                employee.Address = employeeDomainModel.Address;
                employee.Name = employeeDomainModel.Name;
                employee.IsDeleted = false;
                employee = employeeRepository.Insert(employee);
                
                result = "Inserted";
            }

            return result;
        }



        public List<EmployeeDomainModel> GetAllEmployee()
        {
            MVCDataBaseEntities dbContext = new MVCDataBaseEntities();

            List<EmployeeDomainModel> employeeDomainModels = new List<EmployeeDomainModel>();

            employeeDomainModels = employeeRepository.GetAll().Select(m => new EmployeeDomainModel { EmployeeID = m.EmployeeID, Name = m.Name }).ToList();

            //employeeDomainModels = dbContext.Employees.Select(m => new EmployeeDomainModel { EmployeeID = m.EmployeeID, Name = m.Name }).ToList();


            //employeeDomainModels.Add(new EmployeeDomainModel { EmployeeID = 1, Name = "Jose" });

            return employeeDomainModels;

        }

        public string getEmployeeName(int EmployeeID)
        {

            return $"Empleado con ID: { EmployeeID}";
        }
    }
}
