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
        void Example2(string üretimYili, string üretimAyi, string makaraTipi, string malzemesi, string üretici, string no);
        void deneme();
    }
}
