using System;
using System.Collections.Generic;
using System.Text;
using IronBarCode;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;

namespace Core.Barcode
{
  public static class BarkodTasarım
    {
        public static string Example1(string üretimYili,string üretimAyi,string makaraTipi, string malzemesi,string üretici, string no )
        {

            string barcodeNo = üretimYili + üretimAyi + makaraTipi +malzemesi+ üretici+no;
            GeneratedBarcode MyBarCode = BarcodeWriter.CreateBarcode(barcodeNo, BarcodeWriterEncoding.Code128);
            MyBarCode.AddBarcodeValueTextBelowBarcode();  
            
           // MyBarCode.SaveAsJpeg(@"C:\Deneme.jpeg");
           // Process.Start(@"cmd.exe ",@"/c C:\Deneme.jpeg");
            return(MyBarCode.ToString());
        }
        public static void QrCodeDesign()
        { 
           // string barcodeNo = "1233213";
            string MyValue = "1234213";
            System.Drawing.Bitmap BarcodeBmp = IronBarCode.BarcodeWriter.CreateBarcode(MyValue, BarcodeEncoding.QRCode).ResizeTo(300, 200).SetMargins(100).ToBitmap();
            BarcodeBmp.Save("BarcodeBmp.bmp");
            System.Diagnostics.Process.Start(@"cmd.exe ",@"/c C:\BarcodeBmp.bmp");
            //PrintDocument pDoc = new PrintDocument();
            //pDoc.PrintPage(MyBarCode.SaveAsImage(@"C:\Deneme3.jpeg"));
            //pDoc.Print();

        }
       
        


    }
}
