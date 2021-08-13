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
           // MakaraTest();
          //BarkodTest();
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
               Material="PP",
               MonthOfProduction=04,
               Producer="Haffner",
               PulleyType=7300,
               UniqueNumber=006,
               YearOfProduction=2022
            };

            BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());

           var x= barkodManager.Add(_barkod);
            Console.WriteLine(x.Message);

            // Console.WriteLine("GetAlla girdi"+ makaraManager.GetAll()); 
        }
        private static void BarcodePrintTest()
        {
            BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());
            //barkodManager.PrintBarcode();
            //barkodManager.Example2("20", "01", "7", "AB", "H","100");
             barkodManager.deneme();
          
            //foreach (var barcode in barkodManager.GetAll().Data)
            //{
            //    string xxx = barcode.YearOfProduction.ToString().Substring(2,2) + barcode.MonthOfProduction + barcode.PulleyType.ToString().Substring(0,1) + barcode.Material + barcode.Producer.Substring(0,1) + barcode.UniqueNumber + 1;
            //    Console.WriteLine(xxx.Trim());
            //}

        }
    }
}
