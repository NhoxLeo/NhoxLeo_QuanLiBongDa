namespace QuanLyBongDa.Form_Designs
{
    partial class ResultReporterForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_thoiluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_banthangdoi2 = new System.Windows.Forms.TextBox();
            this.txt_banthangdoi1 = new System.Windows.Forms.TextBox();
            this.txt_doi1 = new System.Windows.Forms.TextBox();
            this.txt_doi2 = new System.Windows.Forms.TextBox();
            this.txt_vongthidau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_them = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_matrandau = new System.Windows.Forms.TextBox();
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.trandauTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.luotTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter();
            this.sanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter();
            this.tRANDAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_muagiai = new System.Windows.Forms.TextBox();
            this.seasonCombobox = new System.Windows.Forms.ComboBox();
            this.fixtureCombobox = new System.Windows.Forms.ComboBox();
            this.team1Combobox = new System.Windows.Forms.ComboBox();
            this.team2Combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANDAUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Thời lượng";
            // 
            // txt_thoiluong
            // 
            this.txt_thoiluong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_thoiluong.Location = new System.Drawing.Point(511, 16);
            this.txt_thoiluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_thoiluong.Name = "txt_thoiluong";
            this.txt_thoiluong.Size = new System.Drawing.Size(231, 26);
            this.txt_thoiluong.TabIndex = 74;
            this.txt_thoiluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tỷ Số";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_banthangdoi2
            // 
            this.txt_banthangdoi2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_banthangdoi2.Location = new System.Drawing.Point(466, 112);
            this.txt_banthangdoi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_banthangdoi2.Name = "txt_banthangdoi2";
            this.txt_banthangdoi2.Size = new System.Drawing.Size(65, 26);
            this.txt_banthangdoi2.TabIndex = 73;
            this.txt_banthangdoi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_banthangdoi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_banthangdoi2_KeyPress);
            // 
            // txt_banthangdoi1
            // 
            this.txt_banthangdoi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_banthangdoi1.Location = new System.Drawing.Point(316, 112);
            this.txt_banthangdoi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_banthangdoi1.Name = "txt_banthangdoi1";
            this.txt_banthangdoi1.Size = new System.Drawing.Size(64, 26);
            this.txt_banthangdoi1.TabIndex = 72;
            this.txt_banthangdoi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_banthangdoi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_banthangdoi1_KeyPress);
            // 
            // txt_doi1
            // 
            this.txt_doi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_doi1.Location = new System.Drawing.Point(77, 112);
            this.txt_doi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_doi1.Name = "txt_doi1";
            this.txt_doi1.ReadOnly = true;
            this.txt_doi1.Size = new System.Drawing.Size(231, 26);
            this.txt_doi1.TabIndex = 69;
            // 
            // txt_doi2
            // 
            this.txt_doi2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_doi2.Location = new System.Drawing.Point(539, 112);
            this.txt_doi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_doi2.Name = "txt_doi2";
            this.txt_doi2.ReadOnly = true;
            this.txt_doi2.Size = new System.Drawing.Size(231, 26);
            this.txt_doi2.TabIndex = 70;
            // 
            // txt_vongthidau
            // 
            this.txt_vongthidau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_vongthidau.Location = new System.Drawing.Point(183, 50);
            this.txt_vongthidau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vongthidau.Name = "txt_vongthidau";
            this.txt_vongthidau.ReadOnly = true;
            this.txt_vongthidau.Size = new System.Drawing.Size(231, 26);
            this.txt_vongthidau.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(98, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Mùa Giải:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(99, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Vòng Đấu";
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_them.Location = new System.Drawing.Point(155, 159);
            this.button_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(112, 54);
            this.button_them.TabIndex = 61;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_sua.Location = new System.Drawing.Point(284, 159);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(112, 54);
            this.button_sua.TabIndex = 62;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_ok.Location = new System.Drawing.Point(447, 159);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(112, 54);
            this.button_ok.TabIndex = 63;
            this.button_ok.Text = "Xác Nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_huy
            // 
            this.button_huy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_huy.Location = new System.Drawing.Point(576, 159);
            this.button_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(112, 54);
            this.button_huy.TabIndex = 64;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 210);
            this.dataGridView1.TabIndex = 76;
            // 
            // txt_matrandau
            // 
            this.txt_matrandau.Location = new System.Drawing.Point(27, 159);
            this.txt_matrandau.Name = "txt_matrandau";
            this.txt_matrandau.Size = new System.Drawing.Size(100, 26);
            this.txt_matrandau.TabIndex = 77;
            this.txt_matrandau.Visible = false;
            // 
            // giaivodichbongdaDataSet1
            // 
            this.giaivodichbongdaDataSet1.DataSetName = "GIAIVODICHBONGDADataSet";
            this.giaivodichbongdaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // trandauTableAdapter1
            // 
            this.trandauTableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // luotTableAdapter1
            // 
            this.luotTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // tRANDAUBindingSource
            // 
            this.tRANDAUBindingSource.DataMember = "TRANDAU";
            this.tRANDAUBindingSource.DataSource = this.giaivodichbongdaDataSet1;
            // 
            // txt_muagiai
            // 
            this.txt_muagiai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_muagiai.Location = new System.Drawing.Point(182, 14);
            this.txt_muagiai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_muagiai.Name = "txt_muagiai";
            this.txt_muagiai.ReadOnly = true;
            this.txt_muagiai.Size = new System.Drawing.Size(231, 26);
            this.txt_muagiai.TabIndex = 68;
            // 
            // seasonCombobox
            // 
            this.seasonCombobox.FormattingEnabled = true;
            this.seasonCombobox.Location = new System.Drawing.Point(183, 13);
            this.seasonCombobox.Name = "seasonCombobox";
            this.seasonCombobox.Size = new System.Drawing.Size(230, 28);
            this.seasonCombobox.TabIndex = 78;
            this.seasonCombobox.Visible = false;
            // 
            // fixtureCombobox
            // 
            this.fixtureCombobox.FormattingEnabled = true;
            this.fixtureCombobox.Location = new System.Drawing.Point(183, 50);
            this.fixtureCombobox.Name = "fixtureCombobox";
            this.fixtureCombobox.Size = new System.Drawing.Size(230, 28);
            this.fixtureCombobox.TabIndex = 79;
            this.fixtureCombobox.Visible = false;
            // 
            // team1Combobox
            // 
            this.team1Combobox.FormattingEnabled = true;
            this.team1Combobox.Location = new System.Drawing.Point(77, 112);
            this.team1Combobox.Name = "team1Combobox";
            this.team1Combobox.Size = new System.Drawing.Size(230, 28);
            this.team1Combobox.TabIndex = 80;
            this.team1Combobox.Visible = false;
            // 
            // team2Combobox
            // 
            this.team2Combobox.FormattingEnabled = true;
            this.team2Combobox.Location = new System.Drawing.Point(539, 112);
            this.team2Combobox.Name = "team2Combobox";
            this.team2Combobox.Size = new System.Drawing.Size(230, 28);
            this.team2Combobox.TabIndex = 81;
            this.team2Combobox.Visible = false;
            // 
            // ResultReporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 433);
            this.Controls.Add(this.team2Combobox);
            this.Controls.Add(this.team1Combobox);
            this.Controls.Add(this.fixtureCombobox);
            this.Controls.Add(this.seasonCombobox);
            this.Controls.Add(this.txt_matrandau);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_thoiluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_banthangdoi2);
            this.Controls.Add(this.txt_banthangdoi1);
            this.Controls.Add(this.txt_doi1);
            this.Controls.Add(this.txt_doi2);
            this.Controls.Add(this.txt_muagiai);
            this.Controls.Add(this.txt_vongthidau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_huy);
            this.Name = "ResultReporterForm";
            this.Text = "Ghi nhận kết quả";
            this.Load += new System.EventHandler(this.ResultReporterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANDAUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter trandauTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter luotTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_thoiluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_banthangdoi2;
        private System.Windows.Forms.TextBox txt_banthangdoi1;
        private System.Windows.Forms.TextBox txt_doi1;
        private System.Windows.Forms.TextBox txt_doi2;
        private System.Windows.Forms.TextBox txt_vongthidau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_matrandau;
        private System.Windows.Forms.BindingSource tRANDAUBindingSource;
        private System.Windows.Forms.TextBox txt_muagiai;
        private System.Windows.Forms.ComboBox seasonCombobox;
        private System.Windows.Forms.ComboBox fixtureCombobox;
        private System.Windows.Forms.ComboBox team1Combobox;
        private System.Windows.Forms.ComboBox team2Combobox;
    }
}