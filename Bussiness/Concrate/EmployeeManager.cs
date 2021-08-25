using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrate
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)

        {
            _employeeDal = employeeDal;
        }
        bool x = true;
        public bool CheckEmployee(Employee employee)
        {
            foreach (var check in _employeeDal.GetAll())
            {
                if (employee.name == check.name && employee.surname == check.surname && employee.password == check.password)
                {
                    x = true;

                }
                else x = false;
            }
            return x;
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll(), "Kullanıcılar Listelendi");
        }
    }
}
