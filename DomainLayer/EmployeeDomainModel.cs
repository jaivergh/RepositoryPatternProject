using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class EmployeeDomainModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
