using Bussiness.Abstract;
using Core.Barcode;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using IronBarCode;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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
            
            
            List<string> barcodeLine = new List<string>();
           
            var x=  BarkodTasarım.Example1("20", "01", "7", "AB", "H", "001");
            
            
            var path =  @"C:\deneme2.prn";
            barcodeLine.Add("I8,1,001");

            barcodeLine.Add("O");
            
            barcodeLine.Add("q799");

            barcodeLine.Add("S4");

            barcodeLine.Add("D8");

            barcodeLine.Add("ZT");

            barcodeLine.Add("JF");

            barcodeLine.Add("N");

            barcodeLine.Add(("B150,725,0,1E,3,0,100,N," + Convert.ToChar(34) + x + Convert.ToChar(34)));
            barcodeLine.Add(("A300,575,0,4,1,1,N," + Convert.ToChar(34) + x + Convert.ToChar(34)));
            barcodeLine.Add("P1");
            File.AppendAllLines(path,barcodeLine);

     


            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = @"C:";
             startInfo.FileName = "cmd.exe";
             startInfo.Arguments = "/c print /D:\\\\10.1.248.28\\sewoo \\deneme2.prn";
             startInfo.UseShellExecute = false;
             startInfo.RedirectStandardOutput = true;
             process.StartInfo = startInfo;
             process.Start();
             process.WaitForExit();

        
        }
        public void Example2(string üretimYili, string üretimAyi, string makaraTipi, string malzemesi, string üretici, string no)
        {

            List<string> qrBarcodeLine = new List<string>();

            var x = BarkodTasarım.Example1("20", "01", "7", "AB", "H", "001");


            var path = @"C:\Deneme.prn";
            qrBarcodeLine.Add("I8,E");
            
            qrBarcodeLine.Add("q832");
            qrBarcodeLine.Add("S5");
            qrBarcodeLine.Add("OD");
            qrBarcodeLine.Add("JB");
            qrBarcodeLine.Add("WN");
            qrBarcodeLine.Add("D7");
            qrBarcodeLine.Add("Q2438,25");
            qrBarcodeLine.Add("rN");
            qrBarcodeLine.Add("N");
            qrBarcodeLine.Add("GX184,32,81,197,1593," + Convert.ToChar(34) + x + Convert.ToChar(34));
            //qrBarcodeLine.Add("B310,173,2,4,1,1,N,"+ Convert.ToChar(34) + x + Convert.ToChar(34));
            qrBarcodeLine.Add("P1");



            

          
            File.AppendAllLines(path, qrBarcodeLine);

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = @"C:";
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c print /D:\\\\10.1.248.28\\sewoo \\Deneme.prn";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

        }
       

        public IResult Update(Barkod barkod)
        {
            _barkodDal.Update(barkod);
            return new SuccessResult("Barkod Güncellendi");


        }

    

        public void deneme()
        {

            

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.Print();

        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode("2009ADK2319", QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);
                Bitmap qrCodeImage1 = qrCode.GetGraphic(10);
                Bitmap qrCodeImage2 = qrCode.GetGraphic(10);
                Bitmap qrCodeImage3 = qrCode.GetGraphic(10);
                e.Graphics.DrawImage(qrCodeImage, (10), 10, 75, 75);
                e.Graphics.DrawImage(qrCodeImage1, (105), 10, 75, 75);
                e.Graphics.DrawImage(qrCodeImage2, (200), 10, 75, 75);
                e.Graphics.DrawImage(qrCodeImage3, (295), 10, 75, 75);
                qrCodeImage.Dispose();
            qrCodeImage1.Dispose();
            qrCodeImage2.Dispose();
            qrCodeImage3.Dispose();


            

        }
    }
}
//var x = BarkodTasarım.Example1("20", "01", "7", "AB", "H", "001");


//var path = @"C:\Deneme.prn";
//qrBarcodeLine.Add("N");

//qrBarcodeLine.Add("q406");

//qrBarcodeLine.Add("B31,80,0,1,3,7,58,B," + Convert.ToChar(34) + x + Convert.ToChar(34));

//qrBarcodeLine.Add("P1");
//qrBarcodeLine.Add("M");
//qrBarcodeLine.Add("N");
