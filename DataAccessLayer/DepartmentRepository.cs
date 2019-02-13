using DataAccessLayer.Infrastructure;
using DataAccessLayer.Infrastructure.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DepartmentRepository:BaseRepository<Department>
    {
        public DepartmentRepository(IUnitOfWork unitOfWork):base(unitOfWork)
        {

        }
    }
}
