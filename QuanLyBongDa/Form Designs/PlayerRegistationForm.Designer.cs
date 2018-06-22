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
            this.chooseClubButton = new System.Windows.Forms.Button();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.cauthU_MUAGIAITableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHU_MUAGIAITableAdapter();
            this.loaicauthuTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LOAICAUTHUTableAdapter();
            this.cauthuTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.CAUTHUTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.clubComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nationalityTexBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(145, 12);
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
            this.panel2.Controls.Add(this.nationalityTexBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.clubComboBox);
            this.panel2.Controls.Add(this.chooseClubButton);
            this.panel2.Controls.Add(this.seasonComboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(565, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 208);
            this.panel2.TabIndex = 9;
            // 
            // chooseClubButton
            // 
            this.chooseClubButton.Location = new System.Drawing.Point(16, 77);
            this.chooseClubButton.Name = "chooseClubButton";
            this.chooseClubButton.Size = new System.Drawing.Size(93, 26);
            this.chooseClubButton.TabIndex = 11;
            this.chooseClubButton.Text = "Chọn đội";
            this.chooseClubButton.UseVisualStyleBackColor = true;
            this.chooseClubButton.Click += new System.EventHandler(this.button1_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 26);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sân nhà";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(-1, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 65);
            this.title.TabIndex = 10;
            this.title.Text = "Hồ sơ đội bóng";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(3, 139);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(136, 81);
            this.addPlayerButton.TabIndex = 11;
            this.addPlayerButton.Text = "Thêm cầu thủ";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 226);
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
            // clubComboBox
            // 
            this.clubComboBox.FormattingEnabled = true;
            this.clubComboBox.Location = new System.Drawing.Point(140, 77);
            this.clubComboBox.Name = "clubComboBox";
            this.clubComboBox.Size = new System.Drawing.Size(264, 28);
            this.clubComboBox.TabIndex = 12;
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
            // nationalityTexBox
            // 
            this.nationalityTexBox.Location = new System.Drawing.Point(140, 30);
            this.nationalityTexBox.Name = "nationalityTexBox";
            this.nationalityTexBox.Size = new System.Drawing.Size(264, 26);
            this.nationalityTexBox.TabIndex = 14;
            // 
            // PlayerRegistationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.title);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button chooseClubButton;
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
    }
}