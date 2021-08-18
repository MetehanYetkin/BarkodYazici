
namespace FormUI
{
    partial class QRCodePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodePage));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearOfProduction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthOfProduction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPulleyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.checkedComboBoxEdit5 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkedComboBoxEdit4 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkedComboBoxEdit3 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.checkedComboBoxEdit2 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Entities.Concrate.Barkod);
            this.gridControl1.Location = new System.Drawing.Point(3, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(643, 845);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colYearOfProduction,
            this.colMonthOfProduction,
            this.colPulleyType,
            this.colMaterial,
            this.colProducer,
            this.colUniqueNumber});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1623, 730, 252, 266);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorField = "Id";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            // 
            // colYearOfProduction
            // 
            this.colYearOfProduction.FieldName = "YearOfProduction";
            this.colYearOfProduction.Name = "colYearOfProduction";
            this.colYearOfProduction.Visible = true;
            this.colYearOfProduction.VisibleIndex = 2;
            this.colYearOfProduction.Width = 114;
            // 
            // colMonthOfProduction
            // 
            this.colMonthOfProduction.FieldName = "MonthOfProduction";
            this.colMonthOfProduction.Name = "colMonthOfProduction";
            this.colMonthOfProduction.Visible = true;
            this.colMonthOfProduction.VisibleIndex = 3;
            this.colMonthOfProduction.Width = 122;
            // 
            // colPulleyType
            // 
            this.colPulleyType.FieldName = "PulleyType";
            this.colPulleyType.Name = "colPulleyType";
            this.colPulleyType.Visible = true;
            this.colPulleyType.VisibleIndex = 4;
            this.colPulleyType.Width = 78;
            // 
            // colMaterial
            // 
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 5;
            // 
            // colProducer
            // 
            this.colProducer.FieldName = "Producer";
            this.colProducer.Name = "colProducer";
            this.colProducer.Visible = true;
            this.colProducer.VisibleIndex = 6;
            // 
            // colUniqueNumber
            // 
            this.colUniqueNumber.FieldName = "UniqueNumber";
            this.colUniqueNumber.Name = "colUniqueNumber";
            this.colUniqueNumber.Visible = true;
            this.colUniqueNumber.VisibleIndex = 7;
            this.colUniqueNumber.Width = 96;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(648, 1);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(300, 844);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(298, 800);
            this.xtraTabPage1.Text = "AddBarcode";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.checkedComboBoxEdit5);
            this.groupControl1.Controls.Add(this.checkedComboBoxEdit4);
            this.groupControl1.Controls.Add(this.checkedComboBoxEdit3);
            this.groupControl1.Controls.Add(this.checkedComboBoxEdit2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.checkedComboBoxEdit1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(296, 798);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(109, 691);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Selected Barcode ID";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(124, 433);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Print Selected";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(138, 452);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(109, 710);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(109, 773);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(138, 350);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Code";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(31, 363);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(54, 32);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(124, 369);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // checkedComboBoxEdit5
            // 
            this.checkedComboBoxEdit5.EditValue = "";
            this.checkedComboBoxEdit5.Location = new System.Drawing.Point(124, 294);
            this.checkedComboBoxEdit5.Name = "checkedComboBoxEdit5";
            this.checkedComboBoxEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit5.Properties.DropDownRows = 3;
            this.checkedComboBoxEdit5.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("D", "Dayı Plastik"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Y", "Yılmaz Plastik"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("H", "Haffner")});
            this.checkedComboBoxEdit5.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit5.TabIndex = 11;
            // 
            // checkedComboBoxEdit4
            // 
            this.checkedComboBoxEdit4.EditValue = "";
            this.checkedComboBoxEdit4.Location = new System.Drawing.Point(124, 217);
            this.checkedComboBoxEdit4.Name = "checkedComboBoxEdit4";
            this.checkedComboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit4.Properties.DropDownRows = 4;
            this.checkedComboBoxEdit4.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("ABS", "ABS"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("PP", "PP"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("PA", "PA"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("PS", "PS")});
            this.checkedComboBoxEdit4.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit4.TabIndex = 10;
            // 
            // checkedComboBoxEdit3
            // 
            this.checkedComboBoxEdit3.EditValue = "";
            this.checkedComboBoxEdit3.Location = new System.Drawing.Point(124, 148);
            this.checkedComboBoxEdit3.Name = "checkedComboBoxEdit3";
            this.checkedComboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit3.Properties.DropDownRows = 2;
            this.checkedComboBoxEdit3.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(7, "7300"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2, "2500")});
            this.checkedComboBoxEdit3.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit3.TabIndex = 9;
            // 
            // checkedComboBoxEdit2
            // 
            this.checkedComboBoxEdit2.EditValue = "";
            this.checkedComboBoxEdit2.Location = new System.Drawing.Point(124, 84);
            this.checkedComboBoxEdit2.Name = "checkedComboBoxEdit2";
            this.checkedComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit2.Properties.DropDownRows = 12;
            this.checkedComboBoxEdit2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("01", "01"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("02", "02"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("03", "03"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("04", "04"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("05", "05"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("06", "06"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("07", "07"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("08", "08"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("09", "09"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("10", "10"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("11", "11"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("12", "12")});
            this.checkedComboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit2.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 301);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Producer :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 224);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Material :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "PulleyType :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ProductionMonth :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "YearOfProduction :";
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.EditValue = "";
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(124, 30);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Properties.DropDownRows = 15;
            this.checkedComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2010, "2010"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2011, "2011"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2012, "2012"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2013, "2013"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2014, "2014"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2015, "2015"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2016, "2016"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2017, "2017"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2018, "2018"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2019, "2019"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2020, "2020"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2021, "2021"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2022, "2022"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(2023, "2023")});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit1.TabIndex = 7;
            this.checkedComboBoxEdit1.EditValueChanged += new System.EventHandler(this.checkedComboBoxEdit1_EditValueChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(298, 800);
            this.xtraTabPage2.Text = "DeleteBarcode";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(1, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(296, 496);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // QRCodePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 857);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "QRCodePage";
            this.Text = "QRCodePage";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit5;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit3;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colYearOfProduction;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthOfProduction;
        private DevExpress.XtraGrid.Columns.GridColumn colPulleyType;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colProducer;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueNumber;
    }
}