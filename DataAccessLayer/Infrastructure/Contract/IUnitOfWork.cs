using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure.Contract
{
    public interface IUnitOfWork
    {
        /// <summary>
     /// Return the database reference for this UOW
     /// </summary>
        DbContext Db { get; }
    }
}
