using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrate
{
    public class BarkodManager : IBarkodService
    {
        IBarkodDal _barkodDal ;

        public BarkodManager(IBarkodDal barkodDal)
        {
            _barkodDal = barkodDal;
        }

        public IResult Add(Barkod barkod)
        {
            _barkodDal.Add(barkod);
            return new SuccessResult("Barkod Eklendi");
        }

        public IResult Delete(Barkod barkod)
        {
            _barkodDal.Delete(barkod);
            return new SuccessResult("Barkod Silindi");

        }

        public IResult Update(Barkod barkod)
        {
            _barkodDal.Update(barkod);
            return new SuccessResult("Barkod Güncellendi");


        }
    }
}
