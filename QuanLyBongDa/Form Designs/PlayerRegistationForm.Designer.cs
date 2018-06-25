namespace QuanLyBongDa.Form_Designs
{
    partial class PlayerRegistationForm
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
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.playerType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nationalityTexBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clubComboBox = new System.Windows.Forms.ComboBox();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.cauthU_MUAGIAITableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHU_MUAGIAITableAdapter();
            this.loaicauthuTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LOAICAUTHUTableAdapter();
            this.cauthuTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.txt_madoi = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.txt_macauthu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noteTextBox);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Controls.Add(this.playerType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.playerName);
            this.panel1.Controls.Add(this.playerNameTextBox);
            this.panel1.Controls.Add(this.playerLabel);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 208);
            this.panel1.TabIndex = 0;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(140, 172);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(266, 26);
            this.noteTextBox.TabIndex = 8;
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(140, 127);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(266, 26);
            this.birthday.TabIndex = 7;
            // 
            // playerType
            // 
            this.playerType.FormattingEnabled = true;
            this.playerType.Location = new System.Drawing.Point(140, 79);
            this.playerType.Name = "playerType";
            this.playerType.Size = new System.Drawing.Size(266, 28);
            this.playerType.TabIndex = 6;
            this.playerType.SelectedIndexChanged += new System.EventHandler(this.playerType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại cầu thủ";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(12, 40);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(97, 20);
            this.playerName.TabIndex = 2;
            this.playerName.Text = "Tên cầu thủ:";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(140, 34);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(266, 26);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(160, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(65, 20);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Cầu thủ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nationalityTexBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.clubComboBox);
            this.panel2.Controls.Add(this.seasonComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(539, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 208);
            this.panel2.TabIndex = 9;
            // 
            // nationalityTexBox
            // 
            this.nationalityTexBox.Location = new System.Drawing.Point(140, 30);
            this.nationalityTexBox.Name = "nationalityTexBox";
            this.nationalityTexBox.Size = new System.Drawing.Size(264, 26);
            this.nationalityTexBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quốc Tịch";
            // 
            // clubComboBox
            // 
            this.clubComboBox.FormattingEnabled = true;
            this.clubComboBox.Location = new System.Drawing.Point(140, 95);
            this.clubComboBox.Name = "clubComboBox";
            this.clubComboBox.Size = new System.Drawing.Size(264, 28);
            this.clubComboBox.TabIndex = 12;
            this.clubComboBox.SelectedIndexChanged += new System.EventHandler(this.clubComboBox_SelectedIndexChanged);
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(140, 167);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(266, 28);
            this.seasonComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mùa giải";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(149, -2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(117, 29);
            this.title.TabIndex = 10;
            this.title.Text = "Hồ sơ đội bóng";
            // 
            // giaivodichbongdaDataSet1
            // 
            this.giaivodichbongdaDataSet1.DataSetName = "GIAIVODICHBONGDADataSet";
            this.giaivodichbongdaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cauthU_MUAGIAITableAdapter1
            // 
            this.cauthU_MUAGIAITableAdapter1.ClearBeforeFill = true;
            // 
            // loaicauthuTableAdapter1
            // 
            this.loaicauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // cauthuTableAdapter1
            // 
            this.cauthuTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(976, 220);
            this.dataGridView1.TabIndex = 12;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // txt_madoi
            // 
            this.txt_madoi.Location = new System.Drawing.Point(3, 294);
            this.txt_madoi.Name = "txt_madoi";
            this.txt_madoi.Size = new System.Drawing.Size(10, 26);
            this.txt_madoi.TabIndex = 14;
            // 
            // button_them
            // 
            this.button_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_them.Location = new System.Drawing.Point(27, 248);
            this.button_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(112, 54);
            this.button_them.TabIndex = 15;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sua.Location = new System.Drawing.Point(230, 248);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(112, 54);
            this.button_sua.TabIndex = 16;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_xoa.Location = new System.Drawing.Point(430, 248);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(112, 54);
            this.button_xoa.TabIndex = 17;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ok.Location = new System.Drawing.Point(841, 248);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(112, 54);
            this.button_ok.TabIndex = 18;
            this.button_ok.Text = "Xác Nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // txt_macauthu
            // 
            this.txt_macauthu.Location = new System.Drawing.Point(969, 294);
            this.txt_macauthu.Name = "txt_macauthu";
            this.txt_macauthu.Size = new System.Drawing.Size(10, 26);
            this.txt_macauthu.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chọn đội";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(631, 248);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(112, 54);
            this.btn_huy.TabIndex = 20;
            this.btn_huy.Text = "hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // PlayerRegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_macauthu);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.txt_madoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayerRegistationForm";
            this.Text = "Thêm cầu thủ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox playerType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.CAUTHU_MUAGIAITableAdapter cauthU_MUAGIAITableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.LOAICAUTHUTableAdapter loaicauthuTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter cauthuTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox clubComboBox;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private System.Windows.Forms.TextBox nationalityTexBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_madoi;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox txt_macauthu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_huy;
    }
}