﻿using Bussiness.Abstract;
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
        IBarkodDal _barkodDal;

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

        public IDataResult<List<Barkod>> GetAll()
        {
            return new SuccessDataResult<List<Barkod>>(_barkodDal.GetAll(), "Barkodlar Listelendi");
        }

        public void deneme()
        {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
            
          // pd.PrintPage += Pd_PrintPage;

            pd.Print();

        }
        public void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {

            List<string> barcodeList = new List<string>();
            int clone = 0;

            int total = 15;
            int c = 0;

            int y = 33;
            int counter = 0;
            foreach (var item in GetAll().Data)
            {
                clone++;
            }
           
            foreach (var barcodes in GetAll().Data)
            {
                 

                string xxx = barcodes.YearOfProduction.ToString().Substring(2, 2) + barcodes.MonthOfProduction + barcodes.PulleyType.ToString().Substring(0, 1) + barcodes.Material + barcodes.Producer.Substring(0, 1) + barcodes.UniqueNumber;

                Console.WriteLine(xxx);
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(xxx, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);
                e.Graphics.DrawImage(qrCodeImage, (total), 33, 75, 75);
                qrCodeImage.Dispose();
                total += 95;
                counter++;
                barcodeList.Add(xxx);
                clone--;   
            

                if (total > 300)
                {

                    total = 15;
                    //y += 90;
                    e.HasMorePages = true;
                }

                else if (clone != 0)
                {
                   
                        e.HasMorePages = false;
                    continue;
                }
                else
                {

                    break;
                }














                //Bitmap qrCodeImage1 = qrCode.GetGraphic(5);
                //Bitmap qrCodeImage2 = qrCode.GetGraphic(5);
                //Bitmap qrCodeImage3 = qrCode.GetGraphic(5);
                //e.Graphics.DrawImage(qrCodeImage1, (110), 33, 75, 75);//Difference Between = x :95 
                //e.Graphics.DrawImage(qrCodeImage2, (205), 33, 75, 75);
                //e.Graphics.DrawImage(qrCodeImage3, (300), 33, 75, 75);
                //qrCodeImage1.Dispose();
                //qrCodeImage2.Dispose();
                //qrCodeImage3.Dispose();



            }
        }
           

        public void PrintBarcode()
        {
                List<string> barcodeLine = new List<string>();

                var x = BarkodTasarım.Example1("20", "01", "7", "AB", "H", "001");


                var path = @"C:\deneme2.prn";
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
                File.AppendAllLines(path, barcodeLine);
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
