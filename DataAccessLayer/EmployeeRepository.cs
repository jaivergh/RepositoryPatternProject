using DataAccessLayer.Infrastructure;
using DataAccessLayer.Infrastructure.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }


    }
}

