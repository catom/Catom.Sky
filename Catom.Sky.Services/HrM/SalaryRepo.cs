using System.Collections.Generic;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Data.Query;
using Catom.Sky.Component.Data.Repo;
using Catom.Sky.Services.Entity;

namespace Catom.Sky.Services.HrM
{
    public class SalaryRepo : BaseRepository<Salary>
    {
        private readonly QueryManager _queryManager;

        public SalaryRepo(IUnitOfWork uw) : base(uw) {
            _queryManager = new QueryManager(uw);
        }

        #region Extend your crud methods here.
        /// <summary>
        ///  以按员工ID、发放月份为组合条件，查找薪资。
        /// </summary>
        /// <param name="employeeId">员工ID，0表示不作为查询条件</param>
        /// <param name="month">发放月份，空表示不作为查询条件</param>
        /// <returns></returns>
        public IEnumerable<Salary> GetSalaryList(long employeeId = 0, string month = "")
        {
            var baseSql = @"select * from salary ";
            var where = " where 1=1 ";

            var param = new Dictionary<string, object>();
            if (employeeId != 0)
            {
                where += @" and employeeId = @employeeId";
                param.Add("@employeeId", employeeId);
            }
            if (month != "")
            {
                where += @" and month = @month";
                param.Add("@month", month);
            }

            var sql = baseSql + where;
            var list = _queryManager.GetList<Salary>(sql, param);
            return list;
        }

        /// <summary>
        ///  员工、薪资关联查询。
        /// </summary>
        /// <param name="employeeId">员工工资</param>
        /// <param name="month">所发月份</param>
        /// <returns></returns>
        public IEnumerable<EmployeeAndSalary> GetEmployeeAndSalaryList(long employeeId = 0, string month = "")
        {
            var baseSql = @"select * from employee e join salary s on e.id = s.employeeId ";
            var where = " where 1=1 ";

            var param = new Dictionary<string, object>();
            if (employeeId != 0)
            {
                where += @" and e.Id = @employeeId";
                param.Add("@employeeId", employeeId);
            }
            if (month != "")
            {
                where += @" and s.month = @month";
                param.Add("@month", month);
            }

            var sql = baseSql  + where;
            return _queryManager.GetList<EmployeeAndSalary>(sql, param);
        }


        #endregion
    }
}
