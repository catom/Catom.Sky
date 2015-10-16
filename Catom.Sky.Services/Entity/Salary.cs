using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Catom.Sky.Services.Entity
{

    #region 单表
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
    #endregion


    #region 多表
    public class EmployeeAndSalary
    {
        public long EmployeeId { set; get; }

        public string Name { set; get; }

        public string Sex { set; get; }

        public DateTime CreateTime { set; get; }

        public long SalaryId { set; get; }

        public decimal PreSalary { set; get; }

        public decimal NetSalary { set; get; }

        public string Month { set; get; }

        public DateTime GrantTime { set; get; }

    }
    #endregion


}
