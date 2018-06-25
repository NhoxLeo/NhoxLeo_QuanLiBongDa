namespace QuanLyBongDa.Form_Designs
{
    partial class ResultBrowserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_sobanthangdoi1 = new System.Windows.Forms.TextBox();
            this.txt_sobanthangdoi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doi1 = new System.Windows.Forms.TextBox();
            this.txt_doi2 = new System.Windows.Forms.TextBox();
            this.txt_san = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.trandauTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter();
            this.sanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter();
            this.luotTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter();
            this.cauthuTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.loaibanthangTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LOAIBANTHANGTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.cauthughibanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHUGHIBANTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 558);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 558);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(366, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mùa Giải - Trận Đấu";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(4, 24);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView.Name = "treeView";
            this.treeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(358, 529);
            this.treeView.TabIndex = 2;
            this.treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(839, 558);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 529);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 148);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16686F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.58749F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60834F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.23986F));
            this.tableLayoutPanel2.Controls.Add(this.txt_sobanthangdoi1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_sobanthangdoi2, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_doi1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_doi2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_san, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.25807F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.87097F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(823, 148);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txt_sobanthangdoi1
            // 
            this.txt_sobanthangdoi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sobanthangdoi1.Location = new System.Drawing.Point(330, 109);
            this.txt_sobanthangdoi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sobanthangdoi1.Name = "txt_sobanthangdoi1";
            this.txt_sobanthangdoi1.ReadOnly = true;
            this.txt_sobanthangdoi1.Size = new System.Drawing.Size(91, 26);
            this.txt_sobanthangdoi1.TabIndex = 5;
            this.txt_sobanthangdoi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sobanthangdoi2
            // 
            this.txt_sobanthangdoi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sobanthangdoi2.Location = new System.Drawing.Point(429, 109);
            this.txt_sobanthangdoi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sobanthangdoi2.Name = "txt_sobanthangdoi2";
            this.txt_sobanthangdoi2.ReadOnly = true;
            this.txt_sobanthangdoi2.Size = new System.Drawing.Size(86, 26);
            this.txt_sobanthangdoi2.TabIndex = 6;
            this.txt_sobanthangdoi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đôi 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đội 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sân:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_doi1
            // 
            this.txt_doi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_doi1.Location = new System.Drawing.Point(126, 12);
            this.txt_doi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_doi1.Name = "txt_doi1";
            this.txt_doi1.ReadOnly = true;
            this.txt_doi1.Size = new System.Drawing.Size(196, 26);
            this.txt_doi1.TabIndex = 1;
            // 
            // txt_doi2
            // 
            this.txt_doi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_doi2.Location = new System.Drawing.Point(523, 12);
            this.txt_doi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_doi2.Name = "txt_doi2";
            this.txt_doi2.ReadOnly = true;
            this.txt_doi2.Size = new System.Drawing.Size(201, 26);
            this.txt_doi2.TabIndex = 2;
            // 
            // txt_san
            // 
            this.txt_san.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_san.Location = new System.Drawing.Point(523, 60);
            this.txt_san.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_san.Name = "txt_san";
            this.txt_san.ReadOnly = true;
            this.txt_san.Size = new System.Drawing.Size(201, 26);
            this.txt_san.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime.CustomFormat = "HH:mm - dd/MM/yyyy ";
            this.dateTime.Enabled = false;
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(126, 60);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(196, 26);
            this.dateTime.TabIndex = 3;
            this.dateTime.Value = new System.DateTime(2014, 11, 11, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thời Gian:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(4, 163);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(823, 361);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Cầu Thủ";
            this.columnHeader2.Width = 245;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại Bàn Thắng";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời Điểm";
            this.columnHeader4.Width = 176;
            // 
            // giaivodichbongdaDataSet1
            // 
            this.giaivodichbongdaDataSet1.DataSetName = "GIAIVODICHBONGDADataSet";
            this.giaivodichbongdaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trandauTableAdapter1
            // 
            this.trandauTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // luotTableAdapter1
            // 
            this.luotTableAdapter1.ClearBeforeFill = true;
            // 
            // cauthuTableAdapter1
            // 
            this.cauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // loaibanthangTableAdapter1
            // 
            this.loaibanthangTableAdapter1.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // cauthughibanTableAdapter1
            // 
            this.cauthughibanTableAdapter1.ClearBeforeFill = true;
            // 
            // ResultBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 558);
            this.Controls.Add(this.panel1);
            this.Name = "ResultBrowserForm";
            this.Text = "Xem kết quả trận đấu";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_sobanthangdoi1;
        private System.Windows.Forms.TextBox txt_sobanthangdoi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_doi1;
        private System.Windows.Forms.TextBox txt_doi2;
        private System.Windows.Forms.TextBox txt_san;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter trandauTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter luotTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.LOAIBANTHANGTableAdapter loaibanthangTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.CAUTHUGHIBANTableAdapter cauthughibanTableAdapter1;
    }
}