using System;
using System.Collections.Generic;
using System.Text;
using IronBarCode;
using System.Diagnostics;
namespace Core.Barcode
{
  public static class BarkodTasarım
    {
        public static string Example1(string üretimYili,string üretimAyi,string makaraTipi, string malzemesi,string üretici )
        {

            string barcodeNo = üretimYili + üretimAyi + makaraTipi +malzemesi+ üretici;
            GeneratedBarcode MyBarCode = BarcodeWriter.CreateBarcode(barcodeNo, BarcodeWriterEncoding.Code128);
            MyBarCode.AddBarcodeValueTextBelowBarcode();  
            MyBarCode.SaveAsJpeg(@"C:\Deneme.jpeg");
            Process.Start(@"cmd.exe ",@"/c C:\Deneme.jpeg");
            return(MyBarCode.ToString());












           // Process process = new Process();
            //ProcessStartInfo processStartInfo = new ProcessStartInfo();
            //process.StartInfo.FileName= "Deneme.jpeg";
           // process.StartInfo= processStartInfo;
           // process.Start();
           

        }

    }
}
