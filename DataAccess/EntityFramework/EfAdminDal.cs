using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EntityFramework
{
   public class EfAdminDal : EfEntityRepositoryBase<Admins, BarkodYazıcıContext>, IAdminDal
    {
    }
}
