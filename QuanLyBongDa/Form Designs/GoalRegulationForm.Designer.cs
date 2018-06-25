namespace QuanLyBongDa.Form_Designs
{
    partial class GoalRegulationForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_maloai = new System.Windows.Forms.TextBox();
            this.txtMaQuyDinh = new System.Windows.Forms.TextBox();
            this.dataGridView_quydinh = new System.Windows.Forms.DataGridView();
            this.button_dongy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_thoidiem = new System.Windows.Forms.TextBox();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_hoa = new System.Windows.Forms.TextBox();
            this.txt_thua = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_loaibt = new System.Windows.Forms.TextBox();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.dataGridView_loaibt = new System.Windows.Forms.DataGridView();
            this.lOAIBANTHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAIVODICHBONGDADataSet = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.lOAIBANTHANGTableAdapter = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LOAIBANTHANGTableAdapter();
            this.qUYDINHBANTHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUYDINHBANTHANGTableAdapter = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.QUYDINHBANTHANGTableAdapter();
            this.thamsoTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.THAMSOTableAdapter();
            this.maLoaiBanThangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiBanThangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQuyDinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiDiemGhiBanToiDaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quydinh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loaibt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBANTHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAIVODICHBONGDADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUYDINHBANTHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1371, 628);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_maloai);
            this.panel1.Controls.Add(this.txtMaQuyDinh);
            this.panel1.Controls.Add(this.dataGridView_quydinh);
            this.panel1.Controls.Add(this.button_dongy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_thoidiem);
            this.panel1.Controls.Add(this.txt_thang);
            this.panel1.Controls.Add(this.txt_hoa);
            this.panel1.Controls.Add(this.txt_thua);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 622);
            this.panel1.TabIndex = 2;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(678, 105);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(100, 26);
            this.txt_maloai.TabIndex = 2;
            this.txt_maloai.Visible = false;
            // 
            // txtMaQuyDinh
            // 
            this.txtMaQuyDinh.Location = new System.Drawing.Point(678, 9);
            this.txtMaQuyDinh.Name = "txtMaQuyDinh";
            this.txtMaQuyDinh.Size = new System.Drawing.Size(100, 26);
            this.txtMaQuyDinh.TabIndex = 20;
            // 
            // dataGridView_quydinh
            // 
            this.dataGridView_quydinh.AutoGenerateColumns = false;
            this.dataGridView_quydinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_quydinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_quydinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maQuyDinhDataGridViewTextBoxColumn,
            this.thoiDiemGhiBanToiDaDataGridViewTextBoxColumn});
            this.dataGridView_quydinh.DataSource = this.qUYDINHBANTHANGBindingSource;
            this.dataGridView_quydinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_quydinh.Location = new System.Drawing.Point(0, 441);
            this.dataGridView_quydinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_quydinh.Name = "dataGridView_quydinh";
            this.dataGridView_quydinh.Size = new System.Drawing.Size(885, 181);
            this.dataGridView_quydinh.TabIndex = 19;
            // 
            // button_dongy
            // 
            this.button_dongy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_dongy.Location = new System.Drawing.Point(381, 369);
            this.button_dongy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_dongy.Name = "button_dongy";
            this.button_dongy.Size = new System.Drawing.Size(112, 54);
            this.button_dongy.TabIndex = 18;
            this.button_dongy.Text = "Đồng Ý";
            this.button_dongy.UseVisualStyleBackColor = true;
            this.button_dongy.Click += new System.EventHandler(this.button_dongy_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Điểm Thua:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thời diểm ghi bàn tối đa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Điểm Hòa:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điểm Thắng:";
            // 
            // txt_thoidiem
            // 
            this.txt_thoidiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thoidiem.Location = new System.Drawing.Point(321, 11);
            this.txt_thoidiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_thoidiem.Name = "txt_thoidiem";
            this.txt_thoidiem.Size = new System.Drawing.Size(335, 26);
            this.txt_thoidiem.TabIndex = 14;
            this.txt_thoidiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_thang
            // 
            this.txt_thang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thang.Location = new System.Drawing.Point(321, 102);
            this.txt_thang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(335, 26);
            this.txt_thang.TabIndex = 15;
            this.txt_thang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_hoa
            // 
            this.txt_hoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hoa.Location = new System.Drawing.Point(321, 193);
            this.txt_hoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hoa.Name = "txt_hoa";
            this.txt_hoa.Size = new System.Drawing.Size(335, 26);
            this.txt_hoa.TabIndex = 16;
            this.txt_hoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_thua
            // 
            this.txt_thua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_thua.Location = new System.Drawing.Point(321, 285);
            this.txt_thua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_thua.Name = "txt_thua";
            this.txt_thua.Size = new System.Drawing.Size(335, 26);
            this.txt_thua.TabIndex = 17;
            this.txt_thua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_loaibt);
            this.panel2.Controls.Add(this.button_sua);
            this.panel2.Controls.Add(this.button_them);
            this.panel2.Controls.Add(this.button_xoa);
            this.panel2.Controls.Add(this.button_huy);
            this.panel2.Controls.Add(this.button_ok);
            this.panel2.Controls.Add(this.dataGridView_loaibt);
            this.panel2.Location = new System.Drawing.Point(894, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 622);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại BT:";
            // 
            // txt_loaibt
            // 
            this.txt_loaibt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_loaibt.Location = new System.Drawing.Point(181, 383);
            this.txt_loaibt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_loaibt.Name = "txt_loaibt";
            this.txt_loaibt.Size = new System.Drawing.Size(270, 26);
            this.txt_loaibt.TabIndex = 7;
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sua.Location = new System.Drawing.Point(181, 457);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(112, 54);
            this.button_sua.TabIndex = 12;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_them.Location = new System.Drawing.Point(22, 457);
            this.button_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(112, 54);
            this.button_them.TabIndex = 9;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_xoa.Location = new System.Drawing.Point(339, 457);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(112, 54);
            this.button_xoa.TabIndex = 10;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_huy
            // 
            this.button_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_huy.Location = new System.Drawing.Point(257, 534);
            this.button_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(112, 54);
            this.button_huy.TabIndex = 13;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ok.Location = new System.Drawing.Point(103, 534);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(112, 54);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "Xác Nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // dataGridView_loaibt
            // 
            this.dataGridView_loaibt.AutoGenerateColumns = false;
            this.dataGridView_loaibt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_loaibt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_loaibt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiBanThangDataGridViewTextBoxColumn,
            this.tenLoaiBanThangDataGridViewTextBoxColumn});
            this.dataGridView_loaibt.DataSource = this.lOAIBANTHANGBindingSource;
            this.dataGridView_loaibt.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_loaibt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_loaibt.Name = "dataGridView_loaibt";
            this.dataGridView_loaibt.Size = new System.Drawing.Size(462, 361);
            this.dataGridView_loaibt.TabIndex = 1;
            // 
            // lOAIBANTHANGBindingSource
            // 
            this.lOAIBANTHANGBindingSource.AllowNew = true;
            this.lOAIBANTHANGBindingSource.DataMember = "LOAIBANTHANG";
            this.lOAIBANTHANGBindingSource.DataSource = this.gIAIVODICHBONGDADataSet;
            // 
            // gIAIVODICHBONGDADataSet
            // 
            this.gIAIVODICHBONGDADataSet.DataSetName = "GIAIVODICHBONGDADataSet";
            this.gIAIVODICHBONGDADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIBANTHANGTableAdapter
            // 
            this.lOAIBANTHANGTableAdapter.ClearBeforeFill = true;
            // 
            // qUYDINHBANTHANGBindingSource
            // 
            this.qUYDINHBANTHANGBindingSource.DataMember = "QUYDINHBANTHANG";
            this.qUYDINHBANTHANGBindingSource.DataSource = this.gIAIVODICHBONGDADataSet;
            // 
            // qUYDINHBANTHANGTableAdapter
            // 
            this.qUYDINHBANTHANGTableAdapter.ClearBeforeFill = true;
            // 
            // thamsoTableAdapter1
            // 
            this.thamsoTableAdapter1.ClearBeforeFill = true;
            // 
            // maLoaiBanThangDataGridViewTextBoxColumn
            // 
            this.maLoaiBanThangDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiBanThang";
            this.maLoaiBanThangDataGridViewTextBoxColumn.HeaderText = "MaLoaiBanThang";
            this.maLoaiBanThangDataGridViewTextBoxColumn.Name = "maLoaiBanThangDataGridViewTextBoxColumn";
            // 
            // tenLoaiBanThangDataGridViewTextBoxColumn
            // 
            this.tenLoaiBanThangDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiBanThang";
            this.tenLoaiBanThangDataGridViewTextBoxColumn.HeaderText = "TenLoaiBanThang";
            this.tenLoaiBanThangDataGridViewTextBoxColumn.Name = "tenLoaiBanThangDataGridViewTextBoxColumn";
            // 
            // maQuyDinhDataGridViewTextBoxColumn
            // 
            this.maQuyDinhDataGridViewTextBoxColumn.DataPropertyName = "MaQuyDinh";
            this.maQuyDinhDataGridViewTextBoxColumn.HeaderText = "MaQuyDinh";
            this.maQuyDinhDataGridViewTextBoxColumn.Name = "maQuyDinhDataGridViewTextBoxColumn";
            // 
            // thoiDiemGhiBanToiDaDataGridViewTextBoxColumn
            // 
            this.thoiDiemGhiBanToiDaDataGridViewTextBoxColumn.DataPropertyName = "ThoiDiemGhiBanToiDa";
            this.thoiDiemGhiBanToiDaDataGridViewTextBoxColumn.HeaderText = "ThoiDiemGhiBanToiDa";
            this.thoiDiemGhiBanToiDaDataGridViewTextBoxColumn.Name = "thoiDiemGhiBanToiDaDataGridViewTextBoxColumn";
            // 
            // GoalRegulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GoalRegulationForm";
            this.Text = "Quy dịnh bàn thắng";
            this.Load += new System.EventHandler(this.GoalRegulationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quydinh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loaibt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBANTHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAIVODICHBONGDADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUYDINHBANTHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_quydinh;
        private System.Windows.Forms.Button button_dongy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_thoidiem;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_hoa;
        private System.Windows.Forms.TextBox txt_thua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_loaibt;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.DataGridView dataGridView_loaibt;
        private System.Windows.Forms.BindingSource lOAIBANTHANGBindingSource;
        private GIAIVODICHBONGDADataSet gIAIVODICHBONGDADataSet;
        private GIAIVODICHBONGDADataSetTableAdapters.LOAIBANTHANGTableAdapter lOAIBANTHANGTableAdapter;
        private System.Windows.Forms.BindingSource qUYDINHBANTHANGBindingSource;
        private GIAIVODICHBONGDADataSetTableAdapters.QUYDINHBANTHANGTableAdapter qUYDINHBANTHANGTableAdapter;
        private System.Windows.Forms.TextBox txtMaQuyDinh;
        private System.Windows.Forms.TextBox txt_maloai;
        private GIAIVODICHBONGDADataSetTableAdapters.THAMSOTableAdapter thamsoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyDinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiDiemGhiBanToiDaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiBanThangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiBanThangDataGridViewTextBoxColumn;
    }
}