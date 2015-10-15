using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Repo;
using Dapper.Contrib.Extensions;
using Catom.Sky.Services.Entity;


namespace Catom.Sky.Services.HrM
{
    public class EmployeeRepo : BaseRepository<Employee>
    {
        public EmployeeRepo(IUnitOfWork uw) : base(uw) { }

        // Extend crud methods here.
    }
}
