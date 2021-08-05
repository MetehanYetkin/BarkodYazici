using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface IMakaraService
    {
       IDataResult<List<Makara>> GetAll();
        IResult Add(Makara makara);
        IResult Delete(Makara makara);
        IResult Update(Makara makara);



    }
}
