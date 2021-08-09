using Bussiness.Abstract;
using Core.Barcode;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public void PrintBarcode()
        {
            string vPrinter = "";
            string command = null;
            
            List<string> barcodeLine = new List<string>();
           
            var x=  BarkodTasarım.Example1("20", "01", "7", "AB", "H");
            
            
           // dosya_yolu = AppDomain.CurrentDomain.BaseDirectory + "MyTest.txt";
            var path = @"C:\Users\Lenovo\Desktop\DenemePrint.txt";
            barcodeLine.Add("I8,1,001");

            barcodeLine.Add("O");

            barcodeLine.Add("q799");

            barcodeLine.Add("S4");

            barcodeLine.Add("D8");

            barcodeLine.Add("ZT");

            barcodeLine.Add("JF");

            barcodeLine.Add("N");

            barcodeLine.Add(("B150,860,3,1E,3,0,100,N," + Convert.ToChar(34) + x + Convert.ToChar(34)));
            barcodeLine.Add("A255,660,3,4,1,1,N," + Convert.ToChar(34) + x + Convert.ToChar(34));



            barcodeLine.Add("P1");
            File.AppendAllLines(path,barcodeLine);
            
            //Process.Start(@"cmd.exe ", @"/c C:\Deneme.jpeg");
            // command = @"cmd.exe" + @"/c C:\" + dosya_yolu.Trim() + " >";

            ProcessStartInfo MyProcess = new ProcessStartInfo(@"cmd.exe ",@"/c" + path);

            MyProcess.WindowStyle = ProcessWindowStyle.Hidden;



            Process.Start(MyProcess);



           System.Threading.Thread.Sleep(1000);


        }

        public IResult Update(Barkod barkod)
        {
            _barkodDal.Update(barkod);
            return new SuccessResult("Barkod Güncellendi");


        }
    }
}
