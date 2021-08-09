using Bussiness.Concrate;
using Core.Barcode;
using DataAccess.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MakaraTest();
            BarkodTest();
            BarcodePrintTest();
           // Console.WriteLine("Example 1 - Render a Simple Barcode");
           // BarkodTasarım.Example1("20", "01", "7", "AB", "H");
        }
        private static void MakaraTest() 
        {
            Makara _makara;
            _makara =   new Makara { BarkodNo = "20017ABD001" ,MakaraTipi=7,MaxKullanimAdedi=10
            ,KullanimAdedi=3,KullanimDisi=false};

            MakaraManager makaraManager = new MakaraManager(new EfMakaraDal());

            makaraManager.Add(_makara);
            
           // Console.WriteLine("GetAlla girdi"+ makaraManager.GetAll()); 
        }
        private static void BarkodTest()
        {
            Barkod _barkod;
            _barkod = new Barkod
            {
                UretimYili=20,
                UretimAyi=01,
                MakaraTipi=7,
                Malzemesi="AB",
                Uretici="D"
            };

            BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());

            barkodManager.Add(_barkod);

            // Console.WriteLine("GetAlla girdi"+ makaraManager.GetAll()); 
        }
        private static void BarcodePrintTest()
        {
            BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());
            barkodManager.PrintBarcode();
        }
    }
}
