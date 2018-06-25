namespace QuanLyBongDa.Form_Designs
{
    partial class ScheduleManagerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_them = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.stadiumComboBox = new System.Windows.Forms.ComboBox();
            this.team2 = new System.Windows.Forms.ComboBox();
            this.team1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refereeComboBox = new System.Windows.Forms.ComboBox();
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.doibonG_MUAGIAITableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.sanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter();
            this.trandauTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter();
            this.tRANDAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trongtaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.TRONGTAITableAdapter();
            this.luotTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANDAUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refereeComboBox);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.stadiumComboBox);
            this.panel1.Controls.Add(this.team2);
            this.panel1.Controls.Add(this.team1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.seasonComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 446);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(582, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(791, 220);
            this.dataGridView1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.button_them, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_sua, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_xoa, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_ok, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_huy, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 149);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 72);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_them.Location = new System.Drawing.Point(23, 9);
            this.button_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(112, 54);
            this.button_them.TabIndex = 0;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sua.Location = new System.Drawing.Point(181, 9);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(112, 54);
            this.button_sua.TabIndex = 1;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_xoa.Location = new System.Drawing.Point(339, 9);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(112, 54);
            this.button_xoa.TabIndex = 2;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ok.Location = new System.Drawing.Point(497, 9);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(112, 54);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "Xác Nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_huy
            // 
            this.button_huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_huy.Location = new System.Drawing.Point(657, 9);
            this.button_huy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(112, 54);
            this.button_huy.TabIndex = 4;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            // 
            // stadiumComboBox
            // 
            this.stadiumComboBox.FormattingEnabled = true;
            this.stadiumComboBox.Location = new System.Drawing.Point(582, 73);
            this.stadiumComboBox.Name = "stadiumComboBox";
            this.stadiumComboBox.Size = new System.Drawing.Size(209, 28);
            this.stadiumComboBox.TabIndex = 7;
            this.stadiumComboBox.Text = "Sân";
            // 
            // team2
            // 
            this.team2.FormattingEnabled = true;
            this.team2.Location = new System.Drawing.Point(10, 111);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(221, 28);
            this.team2.TabIndex = 5;
            this.team2.Text = "Đội 2";
            // 
            // team1
            // 
            this.team1.FormattingEnabled = true;
            this.team1.Location = new System.Drawing.Point(10, 77);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(221, 28);
            this.team1.TabIndex = 4;
            this.team1.Text = "Đội 1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38"});
            this.comboBox2.Location = new System.Drawing.Point(10, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Vòng đấu";
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(10, 9);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(221, 28);
            this.seasonComboBox.TabIndex = 1;
            this.seasonComboBox.Text = "Mùa giải";
            this.seasonComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian:";
            // 
            // refereeComboBox
            // 
            this.refereeComboBox.FormattingEnabled = true;
            this.refereeComboBox.Location = new System.Drawing.Point(582, 108);
            this.refereeComboBox.Name = "refereeComboBox";
            this.refereeComboBox.Size = new System.Drawing.Size(209, 28);
            this.refereeComboBox.TabIndex = 11;
            this.refereeComboBox.Text = "Trọng tài";
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
            // doibonG_MUAGIAITableAdapter1
            // 
            this.doibonG_MUAGIAITableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // trandauTableAdapter1
            // 
            this.trandauTableAdapter1.ClearBeforeFill = true;
            // 
            // tRANDAUBindingSource
            // 
            this.tRANDAUBindingSource.DataMember = "TRANDAU";
            this.tRANDAUBindingSource.DataSource = this.giaivodichbongdaDataSet1;
            // 
            // trongtaiTableAdapter1
            // 
            this.trongtaiTableAdapter1.ClearBeforeFill = true;
            // 
            // luotTableAdapter1
            // 
            this.luotTableAdapter1.ClearBeforeFill = true;
            // 
            // ScheduleManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleManagerForm";
            this.Text = "Lập lịch thi đấu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANDAUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox team2;
        private System.Windows.Forms.ComboBox team1;
        private System.Windows.Forms.ComboBox stadiumComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter trandauTableAdapter1;
        private System.Windows.Forms.BindingSource tRANDAUBindingSource;
        private GIAIVODICHBONGDADataSetTableAdapters.TRONGTAITableAdapter trongtaiTableAdapter1;
        private System.Windows.Forms.ComboBox refereeComboBox;
        private GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter luotTableAdapter1;
    }
}