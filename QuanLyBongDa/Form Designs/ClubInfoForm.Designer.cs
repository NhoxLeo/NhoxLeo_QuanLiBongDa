namespace QuanLyBongDa.Form_Designs
{
    partial class ClubInfoForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listviewPlayer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_tendoi = new System.Windows.Forms.Label();
            this.txt_sannha = new System.Windows.Forms.Label();
            this.txt_san = new System.Windows.Forms.TextBox();
            this.link_thongtinsan = new System.Windows.Forms.LinkLabel();
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.doibonG_MUAGIAITableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.cauthuTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter();
            this.sanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.cauthU_MUAGIAITableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHU_MUAGIAITableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(238, 451);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // listviewPlayer
            // 
            this.listviewPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listviewPlayer.Location = new System.Drawing.Point(240, 121);
            this.listviewPlayer.Name = "listviewPlayer";
            this.listviewPlayer.Size = new System.Drawing.Size(559, 330);
            this.listviewPlayer.TabIndex = 2;
            this.listviewPlayer.UseCompatibleStateImageBehavior = false;
            this.listviewPlayer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cầu thủ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại cầu thủ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quốc tịch";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi bàn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label_tendoi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_sannha, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_san, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.link_thongtinsan, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(240, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 121);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label_tendoi
            // 
            this.label_tendoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tendoi.AutoSize = true;
            this.label_tendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tendoi.Location = new System.Drawing.Point(4, 50);
            this.label_tendoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tendoi.Name = "label_tendoi";
            this.label_tendoi.Size = new System.Drawing.Size(178, 20);
            this.label_tendoi.TabIndex = 0;
            this.label_tendoi.Text = "Tên Đội";
            this.label_tendoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_sannha
            // 
            this.txt_sannha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_sannha.AutoSize = true;
            this.txt_sannha.Location = new System.Drawing.Point(200, 50);
            this.txt_sannha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_sannha.Name = "txt_sannha";
            this.txt_sannha.Size = new System.Drawing.Size(75, 20);
            this.txt_sannha.TabIndex = 0;
            this.txt_sannha.Text = "Sân Nhà:";
            this.txt_sannha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_san
            // 
            this.txt_san.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_san.Location = new System.Drawing.Point(283, 47);
            this.txt_san.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_san.Name = "txt_san";
            this.txt_san.ReadOnly = true;
            this.txt_san.Size = new System.Drawing.Size(178, 26);
            this.txt_san.TabIndex = 0;
            // 
            // link_thongtinsan
            // 
            this.link_thongtinsan.ActiveLinkColor = System.Drawing.Color.Red;
            this.link_thongtinsan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.link_thongtinsan.AutoSize = true;
            this.link_thongtinsan.DisabledLinkColor = System.Drawing.Color.White;
            this.link_thongtinsan.LinkColor = System.Drawing.Color.Black;
            this.link_thongtinsan.Location = new System.Drawing.Point(469, 40);
            this.link_thongtinsan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_thongtinsan.Name = "link_thongtinsan";
            this.link_thongtinsan.Size = new System.Drawing.Size(79, 40);
            this.link_thongtinsan.TabIndex = 1;
            this.link_thongtinsan.TabStop = true;
            this.link_thongtinsan.Text = "Thông tin sân";
            this.link_thongtinsan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_thongtinsan_LinkClicked);
            // 
            // giaivodichbongdaDataSet1
            // 
            this.giaivodichbongdaDataSet1.DataSetName = "GIAIVODICHBONGDADataSet";
            this.giaivodichbongdaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // doibonG_MUAGIAITableAdapter1
            // 
            this.doibonG_MUAGIAITableAdapter1.ClearBeforeFill = true;
            // 
            // cauthuTableAdapter1
            // 
            this.cauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // cauthU_MUAGIAITableAdapter1
            // 
            this.cauthU_MUAGIAITableAdapter1.ClearBeforeFill = true;
            // 
            // ClubInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.listviewPlayer);
            this.Controls.Add(this.treeView1);
            this.Name = "ClubInfoForm";
            this.Text = "Thông tin đội bóng";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listviewPlayer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_tendoi;
        private System.Windows.Forms.Label txt_sannha;
        private System.Windows.Forms.TextBox txt_san;
        private System.Windows.Forms.LinkLabel link_thongtinsan;
        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.CAUTHU_MUAGIAITableAdapter cauthU_MUAGIAITableAdapter1;
    }
}