using Bussiness.Concrate;
using DataAccess.EntityFramework;
using DevExpress.XtraEditors.Controls;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing.Printing;
using QRCoder;
using DevExpress.Utils;

namespace FormUI
{
    public partial class QRCodePage : Form
    {
        public QRCodePage()
        {
            InitializeComponent();
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            sqlLoad();



        }
        BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());


        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        

        int x = 100;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

            string YearsOfProduction="";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    YearsOfProduction = item.ToString();
            }
            string MonthOfProduction="";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit2.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    MonthOfProduction = item.ToString();
            }
            string PulleyType="";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit3.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PulleyType = item.ToString();
            }
            string Material="";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit4.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    Material = item.ToString();
            }
            string Producer="";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit5.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    Producer = item.ToString();
            }



            Barkod _barkod;
            _barkod = new Barkod
            {
                Material = Material,
                MonthOfProduction = MonthOfProduction,
                Producer = Producer,
                PulleyType = Convert.ToInt32(PulleyType),
                UniqueNumber = x+=1,
                YearOfProduction = Convert.ToInt32(YearsOfProduction),
            };
            barkodManager.Add(_barkod);

            string code = YearsOfProduction.Substring(2, 2) + MonthOfProduction + PulleyType.Substring(0, 1) + Material + Producer.Substring(0, 1);
            textEdit1.Text = code;

            sqlLoad();
            return;


        }
        int cde = 0;
        List<string> selectRowId = new List<string>();

        private void gridControl1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < gridView1.GetSelectedRows().Count() ; i++)
            //{
            //    string Id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToString();
            //    textEdit2.Text = Id;
            //    selectRowId.Add(Id);
            //    foreach (var item in selectRowId)
            //    {
            //        //cde++;
            //        //MessageBox.Show(cde.ToString());

            //    }
            //}



            //for (int i = 0; i < gridView1.DataRowCount; i++)
            //{
            //    if (gridView1.IsRowSelected(i))
            //        textEdit3.Text=(gridView1.GetRowCellValue(i, gridView1.Columns.Where(c => c.VisibleIndex == 0).FirstOrDefault()).ToString());
            //}


            //string Id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToString();
            //textEdit2.Text = Id;
            //selectRowId.Add(Id);
            //int[] array1 = new int[] {Convert.ToInt32(Id)};
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    textEdit3.Text += array1[i] + "-";

            //}


            //gridView1.ClearSelection();



        }
        List<string> printBarcodes = new List<string>();

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string barcodeString = "";
            foreach (var item in selectRowId)
            {
               var barcode = barkodManager.GetById(Convert.ToInt32(item));
               barcodeString = barcode.Data.YearOfProduction.ToString().Substring(2, 2) + barcode.Data.MonthOfProduction.ToString() + barcode.Data.PulleyType.ToString().Substring(0,1) + barcode.Data.Material + barcode.Data.Producer.Substring(0, 1) + barcode.Data.UniqueNumber.ToString();
                printBarcodes.Add(barcodeString);

            }

            PrintQRCodeForm();




        }

        public void PrintQRCodeForm()
        {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
            pd.Print();
            

        }
        public void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int clone = 0;
            int total = 15;
            int counter = 0;

            foreach (var item in printBarcodes)
            {
                clone++;
            }

            foreach (string barcodes in printBarcodes)
            {
                //string xxx = $"{barcodes.YearOfProduction.ToString().Substring(2, 2)}{barcodes.MonthOfProduction}{barcodes.PulleyType.ToString().Substring(0, 1)}{barcodes.Material}{barcodes.Producer.Substring(0, 1)}";
                //Console.WriteLine(xxx);

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(barcodes, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(5);
                e.Graphics.DrawImage(qrCodeImage, (total), 33, 75, 75);
                qrCodeImage.Dispose();
                total += 95;
                counter++;
                //barcodeList.Add(barcodes);        
                clone--;


                if (total > 300)
                {

                    total = 15;
                    //y += 90;
                    e.HasMorePages = false;
                }

                else if (clone != 0)
                {

                    e.HasMorePages = true;
                    continue;
                }
                else break;
               
            }
           
        }
        

        private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
         


        }




        private void sqlLoad()
        {
            BarkodYazıcıContext dbContext = new BarkodYazıcıContext();

            dbContext.Barcodes.LoadAsync().ContinueWith(loadTask =>



            {
                gridControl1.DataSource = dbContext.Barcodes.Local.ToBindingList();

            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
    }
}
    

