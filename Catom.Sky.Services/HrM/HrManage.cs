using System;
using System.Collections.Generic;
using Catom.Sky.Component.Data;
using Catom.Sky.Services.Entity;

namespace Catom.Sky.Services.HrM
{
    public class HrManage
    {
        private readonly EmployeeRepo _employeeRepo;
        private readonly SalaryRepo _salaryRepo;

        public HrManage(IUnitOfWork uw)
        {
            _employeeRepo = new EmployeeRepo(uw);
            _salaryRepo = new SalaryRepo(uw);
        }

        #region 1. Crud methods for Employee.
        public Employee GetEmployee(long id)
        {
            return _employeeRepo.Get(id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeRepo.Get();
        }


        #endregion
        
        #region 2. Crud methods for Salary.
        public ServiceResult GetSalary(long id)
        {
            try
            {
                var salary = _salaryRepo.Get(id);
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
                var salaryList = _salaryRepo.GetSalaryList(id);
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
                var salaryList = _salaryRepo.GetSalaryList(0, month);
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
                var salaryList = _salaryRepo.GetSalaryList(employeeId, month);
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
                var salaryList = _salaryRepo.GetEmployeeAndSalaryList(0, month);
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
                var salaryList = _salaryRepo.GetEmployeeAndSalaryList(employeeId, month);
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
