using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Catom.Sky.Services.Entity
{
    public class Salary
    {
        [PrimaryKey]
        public long Id { set; get; }
        public long EmployeeId { set; get; }
        public decimal? PreSalary { set; get; }

        [Computable]
        public decimal? NetSalary { set; get; }

        public string Month { set; get; }
        public DateTime GrantDate { set; get; }
    }
}
