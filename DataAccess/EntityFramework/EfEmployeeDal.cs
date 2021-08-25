using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
    

   public class EfEmployeeDal: EfEntityRepositoryBase<Employee, BarkodYazıcıContext>, IEmployeeDal
    {
    }
}
