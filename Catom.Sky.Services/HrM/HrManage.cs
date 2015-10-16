using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catom.Sky.Component.Repo;
using Catom.Sky.Component.Data;
using Dapper.Contrib.Extensions;
using Catom.Sky.Services.Entity;

namespace Catom.Sky.Services.HrM
{
    public class HrManage
    {
        private EmployeeRepo employeeRepo;
        private SalaryRepo salaryRepo;

        public HrManage(IUnitOfWork uw)
        {
            this.employeeRepo = new EmployeeRepo(uw);
            this.salaryRepo = new SalaryRepo(uw);
        }

        #region 1. Crud methods for Employee.
        public Employee GetEmployee(long id)
        {
            return employeeRepo.Get(id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeeRepo.GetSome();
        }


        #endregion
        
        #region 2. Crud methods for Salary.
        public ServiceResult GetSalary(long id)
        {
            try
            {
                var salary = salaryRepo.Get(id);
                if (salary.Id != id)
                {
                    return new ServiceResult(false, "未获取到相关数据");
                }
                return new ServiceResult(true, "获取成功") { Data = salary };
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }

        // 按员工ID 查找所有薪资。
        public ServiceResult GetlSalaryList(long id)
        {
            try
            {
                var salaryList = salaryRepo.GetSalaryList(id);
                if (salaryList == null)
                {
                    return new ServiceResult(false, "未获取到相关数据");
                }
                return new ServiceResult(true, "获取成功") { Data = salaryList };
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }

        // 按发放月份查找所有员工的薪资。
        public ServiceResult GetSalaryList(string month)
        {
            try
            {
                var salaryList = salaryRepo.GetSalaryList(0, month);
                if (salaryList == null)
                {
                    return new ServiceResult(false, "未获取到相关数据");
                }
                return new ServiceResult(true, "获取成功") { Data = salaryList };
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }

        // 按员工ID 和 发放月份组合查找。
        public ServiceResult GetSalaryList(long employeeId, string month)
        {
            try
            {
                var salaryList = salaryRepo.GetSalaryList(employeeId, month);
                if (salaryList == null)
                {
                    return new ServiceResult(false, "未获取到相关数据");
                }
                return new ServiceResult(true, "获取成功") { Data = salaryList };
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }

        // 
        public ServiceResult GetEmployeeAndSalary(string month)
        {
            try
            {
                var salaryList = salaryRepo.GetEmployeeAndSalaryList(0, month);
                if (salaryList == null)
                {
                    return new ServiceResult(false, "未获取到相关数据");
                }
                return new ServiceResult(true, "获取成功") { Data = salaryList };
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }
        // 按员工ID 和发放月份组合，关联查找。
        public ServiceResult GetEmployeeAndSalary(long employeeId, string month)
        {
            try
            {
                var salaryList = salaryRepo.GetEmployeeAndSalaryList(employeeId, month);
                if (salaryList == null)
                {
                    return new ServiceResult(false, "未获取到相关数据");
                }
                return new ServiceResult(true, "获取成功") { Data = salaryList };
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }

        #endregion

    }
}
