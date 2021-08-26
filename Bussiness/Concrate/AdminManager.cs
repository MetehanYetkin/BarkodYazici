using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrate
{
    public class AdminManager : IAdminService

    {


        IAdminDal _adminDal;
        IEmployeeDal _employeeDal;
        public AdminManager(IAdminDal adminDal , IEmployeeDal employeeDal)
        {
            _adminDal = adminDal;
            _employeeDal = employeeDal;
        }
     
        public IResult Add(Admins admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult("Admin Eklendi");
        }

        public IResult AddEmployee(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult("Employee Eklendi");
        }
        bool x = true;
        public bool CheckAdmin(Admins admins)
        {
           
                foreach (var check in _adminDal.GetAll())
                {
                    if (admins.Name == check.Name && admins.Surname == check.Surname && admins.Password == check.Password)
                    {
                        x = true;

                    }
                    else x = false;
                }
                return x;
            }
        

        public IResult Delete(Admins admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult("Admin Silindi");
        }

        public IResult DeleteEmployee(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult("employee Silindi");
        }

        public IResult Update(Admins admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult("Admin Güncellendi");
        }

        public IResult UpdateEmployee(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult("employee Güncellendi");
        }
    }
}
