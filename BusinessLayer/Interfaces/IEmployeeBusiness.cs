using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IEmployeeBusiness
    {
        string getEmployeeName(int EmployeeID);
        List<EmployeeDomainModel> GetAllEmployee();
        string AddUpdateEmployee(EmployeeDomainModel employeeDomainModel);
    }
}
