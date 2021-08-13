using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface IBarkodService
    {
        IResult Add(Barkod barkod);
        IResult Delete(Barkod barkod);
        IResult Update(Barkod barkod);
        void PrintBarcode();
        void deneme();
        IDataResult<List<Barkod>> GetAll();
    }
}
