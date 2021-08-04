using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface IMakaraService
    {
        List<Makara> GetAll();
        void Add(Makara makara);
        void Delete(Makara makara);
        void Update(Makara makara);



    }
}
