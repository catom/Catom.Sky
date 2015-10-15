using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catom.Sky.Web.Models
{
    #region Salary Model.
    public class SalaryRequestFilter : RequestFilter
    {
        public long Id { set; get; }

        public long EmployeeId { set; get; }

        public string Month { set; get; }
    }

    public class SalaryRequest : BaseRequest<SalaryRequestFilter>
    {
    }

    public class SalaryModel
    {
        public long Id { set; get; }

        public long EmployeeId { set; get; }

        public decimal? PreSalary { set; get; }

        public decimal? NetSalary { set; get; }

        public string Month { set; get; }

        public DateTime GrantDate { set; get; }
    }
    #endregion
}