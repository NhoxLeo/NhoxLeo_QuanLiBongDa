namespace QuanLyBongDa.Form_Designs
{
    partial class ScheduleBrowserForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.seasonCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Team1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Team2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stadium = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fixture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Season = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaivodichbongdaDataSet1 = new QuanLyBongDa.GIAIVODICHBONGDADataSet();
            this.luotTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter();
            this.muagiaiTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter();
            this.trandauTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter();
            this.sanTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter();
            this.doibongTableAdapter1 = new QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 501);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.47619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.52381F));
            this.tableLayoutPanel1.Controls.Add(this.seasonCombobox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 103);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // seasonCombobox
            // 
            this.seasonCombobox.FormattingEnabled = true;
            this.seasonCombobox.Location = new System.Drawing.Point(183, 3);
            this.seasonCombobox.Name = "seasonCombobox";
            this.seasonCombobox.Size = new System.Drawing.Size(339, 28);
            this.seasonCombobox.TabIndex = 2;
            this.seasonCombobox.SelectedIndexChanged += new System.EventHandler(this.seasonCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mùa Giải: ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Team1,
            this.Team2,
            this.Date,
            this.Stadium,
            this.Fixture,
            this.Season});
            this.listView1.Location = new System.Drawing.Point(537, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 498);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "STT";
            // 
            // Team1
            // 
            this.Team1.Text = "Đội 1";
            // 
            // Team2
            // 
            this.Team2.Text = "Đội 2";
            // 
            // Date
            // 
            this.Date.Text = "Thời gian";
            // 
            // Stadium
            // 
            this.Stadium.Text = "Sân";
            // 
            // Fixture
            // 
            this.Fixture.Text = "Vòng đấu";
            // 
            // Season
            // 
            this.Season.Text = "Mùa giải";
            // 
            // giaivodichbongdaDataSet1
            // 
            this.giaivodichbongdaDataSet1.DataSetName = "GIAIVODICHBONGDADataSet";
            this.giaivodichbongdaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luotTableAdapter1
            // 
            this.luotTableAdapter1.ClearBeforeFill = true;
            // 
            // muagiaiTableAdapter1
            // 
            this.muagiaiTableAdapter1.ClearBeforeFill = true;
            // 
            // trandauTableAdapter1
            // 
            this.trandauTableAdapter1.ClearBeforeFill = true;
            // 
            // sanTableAdapter1
            // 
            this.sanTableAdapter1.ClearBeforeFill = true;
            // 
            // doibongTableAdapter1
            // 
            this.doibongTableAdapter1.ClearBeforeFill = true;
            // 
            // ScheduleBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 496);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleBrowserForm";
            this.Text = "Xem lịch thi đấu";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giaivodichbongdaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox seasonCombobox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Team1;
        private System.Windows.Forms.ColumnHeader Team2;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Stadium;
        private System.Windows.Forms.ColumnHeader Fixture;
        private System.Windows.Forms.ColumnHeader Season;
        private GIAIVODICHBONGDADataSet giaivodichbongdaDataSet1;
        private GIAIVODICHBONGDADataSetTableAdapters.LUOTTableAdapter luotTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.MUAGIAITableAdapter muagiaiTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.TRANDAUTableAdapter trandauTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.SANTableAdapter sanTableAdapter1;
        private GIAIVODICHBONGDADataSetTableAdapters.DOIBONGTableAdapter doibongTableAdapter1;
    }
}