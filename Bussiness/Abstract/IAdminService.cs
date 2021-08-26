using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface IAdminService
    {
        IResult Add(Admins admin);
        IResult Delete(Admins admin);
        IResult Update(Admins admin);
        IResult AddEmployee(Employee employee);
        IResult DeleteEmployee(Employee employee);
        IResult UpdateEmployee(Employee employee);
        bool CheckAdmin(Admins admins);



    }
}
