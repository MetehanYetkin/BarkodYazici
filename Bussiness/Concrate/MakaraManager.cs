using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrate
{
    public class MakaraManager : IMakaraService
    {
        IMakaraDal _makaraDal;
        public MakaraManager(IMakaraDal makaraDal)
        {
            _makaraDal = makaraDal;
        }
        public IResult Add(Makara makara)
        {
            _makaraDal.Add(makara);
           return new SuccessResult("Makara Eklendi");
        }

        public IResult Delete(Makara makara)
        {
            _makaraDal.Delete(makara);
            return new SuccessResult("Makara Silindi");

        }

        public IDataResult<List<Makara>> GetAll()
        {
            return new SuccessDataResult<List<Makara>>(_makaraDal.GetAll(),"Makaralar Listelendi");
        }

        public IResult Update(Makara makara)
        {
            _makaraDal.Update(makara);
            return new SuccessResult("Makara Güncellendi");
        }
    }
}
