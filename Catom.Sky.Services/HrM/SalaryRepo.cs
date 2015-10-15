using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catom.Sky.Component.Repo;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Data.Query;
using Dapper.Contrib.Extensions;
using Catom.Sky.Services.Entity;

namespace Catom.Sky.Services.HrM
{
    public class SalaryRepo : BaseRepository<Salary>
    {
        private QueryManager queryManager;

        public SalaryRepo(IUnitOfWork uw) : base(uw) {
            this.queryManager = new QueryManager(uw);
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
            var param = new Dictionary<string, object>();

            var where = " where 1=1 ";
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

            var sql = @"select * from salary " + where;
            return queryManager.GetList<Salary>(sql, param);
        }


        #endregion
    }
}
