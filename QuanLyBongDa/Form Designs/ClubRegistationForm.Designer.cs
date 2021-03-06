﻿namespace QuanLyBongDa.Form_Designs
{
    partial class ClubRegistationForm
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
            this.clubLabel = new System.Windows.Forms.Label();
            this.clubNameTextBox = new System.Windows.Forms.TextBox();
            this.clubName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.homeStadiumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.seasonCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.capacityTextbox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_them = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ok = new System.Windows.Forms.Button();
            this.doibonG_MUAGIAITableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONG_MUAGIAITableAdapter();
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.sanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.txt_madoi = new System.Windows.Forms.TextBox();
            this.txt_masan = new System.Windows.Forms.TextBox();
            this.button_huy = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // clubLabel
            // 
            this.clubLabel.AutoSize = true;
            this.clubLabel.Location = new System.Drawing.Point(12, 9);
            this.clubLabel.Name = "clubLabel";
            this.clubLabel.Size = new System.Drawing.Size(112, 20);
            this.clubLabel.TabIndex = 0;
            this.clubLabel.Text = "Chọn đội bóng";
            // 
            // clubNameTextBox
            // 
            this.clubNameTextBox.Location = new System.Drawing.Point(137, 39);
            this.clubNameTextBox.Name = "clubNameTextBox";
            this.clubNameTextBox.Size = new System.Drawing.Size(296, 26);
            this.clubNameTextBox.TabIndex = 1;
            // 
            // clubName
            // 
            this.clubName.AutoSize = true;
            this.clubName.Location = new System.Drawing.Point(12, 45);
            this.clubName.Name = "clubName";
            this.clubName.Size = new System.Drawing.Size(101, 20);
            this.clubName.TabIndex = 2;
            this.clubName.Text = "Tên đội bóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sân nhà";
            // 
            // homeStadiumTextBox
            // 
            this.homeStadiumTextBox.Location = new System.Drawing.Point(137, 71);
            this.homeStadiumTextBox.Name = "homeStadiumTextBox";
            this.homeStadiumTextBox.Size = new System.Drawing.Size(296, 26);
            this.homeStadiumTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mùa giải";
            // 
            // seasonCombobox
            // 
            this.seasonCombobox.FormattingEnabled = true;
            this.seasonCombobox.Location = new System.Drawing.Point(137, 103);
            this.seasonCombobox.Name = "seasonCombobox";
            this.seasonCombobox.Size = new System.Drawing.Size(296, 28);
            this.seasonCombobox.TabIndex = 10;
            this.seasonCombobox.SelectedIndexChanged += new System.EventHandler(this.seasonCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sức chứa";
            // 
            // capacityTextbox
            // 
            this.capacityTextbox.Location = new System.Drawing.Point(137, 137);
            this.capacityTextbox.Name = "capacityTextbox";
            this.capacityTextbox.Size = new System.Drawing.Size(296, 26);
            this.capacityTextbox.TabIndex = 12;
            this.capacityTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacityTextbox_KeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 175);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(57, 20);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Địa chỉ";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(137, 169);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(296, 26);
            this.addressTextBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.capacityTextbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.seasonCombobox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.homeStadiumTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.clubName);
            this.panel2.Controls.Add(this.clubNameTextBox);
            this.panel2.Controls.Add(this.clubLabel);
            this.panel2.Location = new System.Drawing.Point(345, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 214);
            this.panel2.TabIndex = 13;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(16, 40);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(112, 56);
            this.button_them.TabIndex = 15;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.addClubButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(116, 20);
            this.title.TabIndex = 14;
            this.title.Text = "Hồ sơ đội bóng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 234);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 218);
            this.dataGridView1.TabIndex = 16;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(157, 40);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(113, 56);
            this.button_ok.TabIndex = 17;
            this.button_ok.Text = "Xác nhận";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // doibonG_MUAGIAITableAdapter1
            // 
            this.doibonG_MUAGIAITableAdapter1.ClearBeforeFill = true;
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
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // button_sua
            // 
            this.button_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sua.Location = new System.Drawing.Point(157, 155);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(113, 52);
            this.button_sua.TabIndex = 18;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_xoa.Location = new System.Drawing.Point(16, 155);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(112, 52);
            this.button_xoa.TabIndex = 19;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // txt_madoi
            // 
            this.txt_madoi.Location = new System.Drawing.Point(0, 215);
            this.txt_madoi.Name = "txt_madoi";
            this.txt_madoi.Size = new System.Drawing.Size(10, 26);
            this.txt_madoi.TabIndex = 20;
            // 
            // txt_masan
            // 
            this.txt_masan.Location = new System.Drawing.Point(0, 215);
            this.txt_masan.Name = "txt_masan";
            this.txt_masan.Size = new System.Drawing.Size(10, 26);
            this.txt_masan.TabIndex = 21;
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(89, 103);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(100, 44);
            this.button_huy.TabIndex = 22;
            this.button_huy.Text = "huy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // ClubRegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.txt_masan);
            this.Controls.Add(this.txt_madoi);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel2);
            this.Name = "ClubRegistationForm";
            this.Text = "Đăng kí đội bóng";
            this.Load += new System.EventHandler(this.ClubRegistationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clubLabel;
        private System.Windows.Forms.TextBox clubNameTextBox;
        private System.Windows.Forms.Label clubName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox homeStadiumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seasonCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacityTextbox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONG_MUAGIAITableAdapter doibonG_MUAGIAITableAdapter1;
        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.TextBox txt_madoi;
        private System.Windows.Forms.TextBox txt_masan;
        private System.Windows.Forms.Button button_huy;
    }
}