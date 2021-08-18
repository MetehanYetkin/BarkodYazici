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
        void PrintQRCode();
        IDataResult<List<Barkod>> GetAll();
        IDataResult<Barkod> GetById(int barcodeId);
        void getString(string code);
    }
}
