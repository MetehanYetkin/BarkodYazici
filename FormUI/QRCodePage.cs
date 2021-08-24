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
using DevExpress.BarCodes;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.Printing.Core;

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
        //Değişkenler 

        BarkodManager barkodManager = new BarkodManager(new EfBarkodDal());
        int x = 100;
        List<string> printBarcodes = new List<string>();
        Barkod _barkod;
        List<int> maxUniq = new List<int>();
        List<string> selectRowId = new List<string>();
        BarkodYazıcıContext dbContext = new BarkodYazıcıContext();
        private int numberOfItemsPrintSoFar = 0;



        private void simpleButton1_Click(object sender, EventArgs e)
        {


            string YearsOfProduction = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)

                    YearsOfProduction = item.ToString();
            }
            string MonthOfProduction = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit2.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    MonthOfProduction = item.ToString();
            }
            string PulleyType = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit3.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    PulleyType = item.ToString();
            }
            string Material = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit4.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    Material = item.ToString();
            }
            string Producer = "";
            foreach (CheckedListBoxItem item in checkedComboBoxEdit5.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    Producer = item.ToString();
            }
            string unique = "";

            string code = YearsOfProduction.Substring(2, 2) + MonthOfProduction + PulleyType.Substring(0, 1) + Material + Producer.Substring(0, 1);
            var number = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "UniqueNumber");




            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                string xde = gridView1.GetRowCellValue(i, "YearOfProduction").ToString();
                string xde1 = gridView1.GetRowCellValue(i, "MonthOfProduction").ToString();
                string xde2 = gridView1.GetRowCellValue(i, "PulleyType").ToString();
                string xde3 = gridView1.GetRowCellValue(i, "Material").ToString();
                string xde4 = gridView1.GetRowCellValue(i, "Producer").ToString();
                unique = gridView1.GetRowCellValue(i, "UniqueNumber").ToString();

                string de = xde.ToString().Substring(2, 2) + xde1 + xde2.ToString().Substring(0, 1) + xde3 + xde4.Substring(0, 1);
                if (code == de)
                {
                    maxUniq.Add(Convert.ToInt32(unique));
                }

            }
            if (maxUniq.Count == 0)
            {
                maxUniq.Add(99);
            }

            int CodeUNIQUE = maxUniq.Max() + 1;
            string codsee = YearsOfProduction.Substring(2, 2) + MonthOfProduction + PulleyType.Substring(0, 1) + Material + Producer.Substring(0, 1) + Convert.ToString(CodeUNIQUE);

            _barkod = new Barkod
            {
                Material = Material,
                MonthOfProduction = MonthOfProduction,
                Producer = Producer,
                PulleyType = Convert.ToInt32(PulleyType),
                UniqueNumber = maxUniq.Max() + 1,
                YearOfProduction = Convert.ToInt32(YearsOfProduction),
                BarcodeNo = codsee,
            };
            barkodManager.Add(_barkod);
            int CodeUNIQ = maxUniq.Max() + 1;
            string codse = YearsOfProduction.Substring(2, 2) + MonthOfProduction + PulleyType.Substring(0, 1) + Material + Producer.Substring(0, 1) + Convert.ToString(CodeUNIQ);
            textEdit1.Text = codse;
            sqlLoad();
            return;
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < gridView1.GetSelectedRows().Count() ; i++)
            //{
            //    string Id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToString();
            //    textEdit2.Text = Id;
            //    selectRowId.Add(Id);
            //    foreach (var item in selectRowId)

            //}



            //for (int i = 0; i < gridView1.DataRowCount; i++)
            //{
            //    if (gridView1.IsRowSelected(i))
            //        textEdit3.Text=(gridView1.GetRowCellValue(i, gridView1.Columns.Where(c => c.VisibleIndex == 0).FirstOrDefault()).ToString());
            //}

            //for (int i = 0; i < gridView1.DataRowCount; i++)
            //{
            //    if (gridView1.IsRowSelected(i))
            //    {

            //    }
            //}


            string Id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToString();

            textEdit2.Text = Id;
            selectRowId.Add(Id);
            int[] array1 = new int[] { Convert.ToInt32(Id) };
            for (int i = 0; i < array1.Length; i++)
            {
                //textEdit3.Text += array1[i] + "-";

            }


            //gridView1.ClearSelection();



        }


        private void simpleButton2_Click(object sender, EventArgs e)// yazdırma butonu
        {
            onlySelectedRow();
            //pd.Print();
            PrintQRCodeForm();
            // printBarcodeDev();
        }
        PaperSize ps = new PaperSize();
        

        public void PrintQRCodeForm()
        {



            PrintDocument pd = new PrintDocument();
            PrintDialog pde = new PrintDialog();

            pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
            ps.Height = pd.PrinterSettings.DefaultPageSettings.PaperSize.Height ;
            pd.DefaultPageSettings.Landscape = true;
            ps.Width = pd.PrinterSettings.DefaultPageSettings.PaperSize.Width ;

            pde.Document = pd;
            // pde.ShowDialog();            
            pd.Print();


        }

        QRCodeGenerator qrGenerator = new QRCodeGenerator();

        private Bitmap barcodeGenarator(string codeNumber) // barkod oluşturma
        {
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(codeNumber, QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5);
            return qrCodeImage;
        }

        int total = 15;
        int y = 33;
        int itemperpage = 0;
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)//son 4 lü sırayı 4 kez bastırıyor.
        {
            //e.HasMorePages = true;
            for (int i = numberOfItemsPrintSoFar; i < gridView1.DataRowCount; i++)
            {

                itemperpage++;
               
                if (itemperpage<4)
                {
                   
                    numberOfItemsPrintSoFar++;
                    if (numberOfItemsPrintSoFar <= gridView1.DataRowCount)
                    {
                        string xbarcode = gridView1.GetRowCellValue(i, "BarcodeNo").ToString();
                        e.Graphics.DrawImage(barcodeGenarator(xbarcode), (total), (y), 75, 75);
                        total += 95;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    itemperpage = 0;
                    e.HasMorePages = true;
                }
               // e.HasMorePages = (ps.Height > y);
                //e.HasMorePages = (ps.Width > total);

                //if (total>300)
                //{
                //    total = 15;
                //    e.HasMorePages = false;
                //}
                // if (total == 110)
                //{

                //    e.HasMorePages = true;

                //}
                //else if (total == 205)
                //{
                //    e.HasMorePages = true;
                //}
                //else if(total == 300)
                //{
                //    e.HasMorePages = true;
                //}

                //else
                //{
                //    e.HasMorePages = false;
                //    total = 15;

                //}

            }


        }


       


        private void onlySelectedRow()
        {
            ArrayList rows = new ArrayList();
            GridColumn ıdColumn = gridView1.Columns["Id"];
            string barcodeString = "";
            // Add the selected rows to the list.

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    string Idee = gridView1.GetRowCellValue(i, "Id").ToString();
                    rows.Add(Idee);
                }
            }
            foreach (var item2 in rows)
            {
                var barcode = barkodManager.GetById(Convert.ToInt32(item2));
                barcodeString = barcode.Data.YearOfProduction.ToString().Substring(2, 2) + barcode.Data.MonthOfProduction.ToString() + barcode.Data.PulleyType.ToString().Substring(0, 1) + barcode.Data.Material + barcode.Data.Producer.Substring(0, 1) + barcode.Data.UniqueNumber.ToString();
                printBarcodes.Add(barcodeString);
                textEdit3.Text += item2 + "-";

            }
        }



        public void printBarcodeDev()
        {

            List<BarCode> bms = new List<BarCode>();
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                string xbarcode = gridView1.GetRowCellValue(i, "BarcodeNo").ToString();

                BarCode barCode = new BarCode();

                barCode.Symbology = Symbology.QRCode;
                barCode.CodeText = xbarcode;
                barCode.BackColor = Color.White;
                barCode.ForeColor = Color.Black;
                barCode.RotationAngle = 0;
                barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
                //   barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte;
                barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
                barCode.Options.QRCode.ShowCodeText = false;
                barCode.DpiX = 35;
                barCode.DpiY = 40;
                barCode.Module = 3f;


                barCode.Print();
            }

        }

        private void sqlLoad()
        {

            dbContext.Barcodes.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Barcodes.Local.ToBindingList();

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {

        }
        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
        private void simpl_Click(object sender, EventArgs e)
        {
        }

        private void QRCodePage_Load(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

       
    
}
    

