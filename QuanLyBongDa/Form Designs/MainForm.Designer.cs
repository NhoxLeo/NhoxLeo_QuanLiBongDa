namespace QuanLyBongDa
{
    partial class MainForm
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
            this.menuQLBD = new System.Windows.Forms.MenuStrip();
            this.menu_SeasonManager = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ClubResigtator = new System.Windows.Forms.ToolStripMenuItem();
            this.button_PlayerRegistator = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ClubInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Calendar = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ManageSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BrowseSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Result = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ResultReport = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ScorerRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.button_BrowseResult = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Regulation = new System.Windows.Forms.ToolStripMenuItem();
            this.button_PlayerRegulation = new System.Windows.Forms.ToolStripMenuItem();
            this.button_GoalRegulation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQLBD
            // 
            this.menuQLBD.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuQLBD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_SeasonManager,
            this.menu_Calendar,
            this.menu_Result,
            this.menu_Report,
            this.menu_Regulation});
            this.menuQLBD.Location = new System.Drawing.Point(0, 0);
            this.menuQLBD.Name = "menuQLBD";
            this.menuQLBD.Size = new System.Drawing.Size(800, 33);
            this.menuQLBD.TabIndex = 0;
            this.menuQLBD.Text = "menuStrip1";
            // 
            // menu_SeasonManager
            // 
            this.menu_SeasonManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_ClubResigtator,
            this.button_PlayerRegistator,
            this.button_ClubInfo});
            this.menu_SeasonManager.Name = "menu_SeasonManager";
            this.menu_SeasonManager.Size = new System.Drawing.Size(118, 29);
            this.menu_SeasonManager.Text = "Quản lý giải";
            // 
            // button_ClubResigtator
            // 
            this.button_ClubResigtator.Name = "button_ClubResigtator";
            this.button_ClubResigtator.Size = new System.Drawing.Size(252, 30);
            this.button_ClubResigtator.Text = "Đăng ký đội bóng";
            this.button_ClubResigtator.Click += new System.EventHandler(this.button_ClubResigtator_Click);
            // 
            // button_PlayerRegistator
            // 
            this.button_PlayerRegistator.Name = "button_PlayerRegistator";
            this.button_PlayerRegistator.Size = new System.Drawing.Size(252, 30);
            this.button_PlayerRegistator.Text = "Thêm cầu thủ";
            this.button_PlayerRegistator.Click += new System.EventHandler(this.button_PlayerRegistator_Click);
            // 
            // button_ClubInfo
            // 
            this.button_ClubInfo.Name = "button_ClubInfo";
            this.button_ClubInfo.Size = new System.Drawing.Size(252, 30);
            this.button_ClubInfo.Text = "Thông tin đội bóng";
            this.button_ClubInfo.Click += new System.EventHandler(this.button_ClubInfo_Click);
            // 
            // menu_Calendar
            // 
            this.menu_Calendar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_ManageSchedule,
            this.menu_BrowseSchedule});
            this.menu_Calendar.Name = "menu_Calendar";
            this.menu_Calendar.Size = new System.Drawing.Size(114, 29);
            this.menu_Calendar.Text = "Lịch thi đấu";
            // 
            // button_ManageSchedule
            // 
            this.button_ManageSchedule.Name = "button_ManageSchedule";
            this.button_ManageSchedule.Size = new System.Drawing.Size(252, 30);
            this.button_ManageSchedule.Text = "Lập lịch thi đấu";
            this.button_ManageSchedule.Click += new System.EventHandler(this.button_ManageSchedule_Click);
            // 
            // menu_BrowseSchedule
            // 
            this.menu_BrowseSchedule.Name = "menu_BrowseSchedule";
            this.menu_BrowseSchedule.Size = new System.Drawing.Size(252, 30);
            this.menu_BrowseSchedule.Text = "Xem lịch thi đấu";
            this.menu_BrowseSchedule.Click += new System.EventHandler(this.menu_BrowseSchedule_Click);
            // 
            // menu_Result
            // 
            this.menu_Result.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_ResultReport,
            this.button_ScorerRecord,
            this.button_BrowseResult});
            this.menu_Result.Name = "menu_Result";
            this.menu_Result.Size = new System.Drawing.Size(144, 29);
            this.menu_Result.Text = "Kết quả thi đấu";
            // 
            // button_ResultReport
            // 
            this.button_ResultReport.Name = "button_ResultReport";
            this.button_ResultReport.Size = new System.Drawing.Size(268, 30);
            this.button_ResultReport.Text = "Ghi nhận kết quả";
            this.button_ResultReport.Click += new System.EventHandler(this.button_ResultReport_Click);
            // 
            // button_ScorerRecord
            // 
            this.button_ScorerRecord.Name = "button_ScorerRecord";
            this.button_ScorerRecord.Size = new System.Drawing.Size(268, 30);
            this.button_ScorerRecord.Text = "Thêm cầu thủ ghi bàn";
            this.button_ScorerRecord.Click += new System.EventHandler(this.button_ScorerRecord_Click);
            // 
            // button_BrowseResult
            // 
            this.button_BrowseResult.Name = "button_BrowseResult";
            this.button_BrowseResult.Size = new System.Drawing.Size(268, 30);
            this.button_BrowseResult.Text = "Xem kết quả trận đấu";
            this.button_BrowseResult.Click += new System.EventHandler(this.button_BrowseResult_Click);
            // 
            // menu_Report
            // 
            this.menu_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_Search});
            this.menu_Report.Name = "menu_Report";
            this.menu_Report.Size = new System.Drawing.Size(160, 29);
            this.menu_Report.Text = "Tra cứu - Báo cáo";
            // 
            // button_Search
            // 
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(252, 30);
            this.button_Search.Text = "Tra Cứu";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // menu_Regulation
            // 
            this.menu_Regulation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_PlayerRegulation,
            this.button_GoalRegulation});
            this.menu_Regulation.Name = "menu_Regulation";
            this.menu_Regulation.Size = new System.Drawing.Size(130, 29);
            this.menu_Regulation.Text = "Quy định giải";
            // 
            // button_PlayerRegulation
            // 
            this.button_PlayerRegulation.Name = "button_PlayerRegulation";
            this.button_PlayerRegulation.Size = new System.Drawing.Size(255, 30);
            this.button_PlayerRegulation.Text = "Quy định cầu thủ";
            this.button_PlayerRegulation.Click += new System.EventHandler(this.button_PlayerRegulation_Click);
            // 
            // button_GoalRegulation
            // 
            this.button_GoalRegulation.Name = "button_GoalRegulation";
            this.button_GoalRegulation.Size = new System.Drawing.Size(255, 30);
            this.button_GoalRegulation.Text = "Quy định bàn thắng";
            this.button_GoalRegulation.Click += new System.EventHandler(this.button_GoalRegulation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuQLBD);
            this.MainMenuStrip = this.menuQLBD;
            this.Name = "MainForm";
            this.Text = "Quản lý bóng đá";
            this.menuQLBD.ResumeLayout(false);
            this.menuQLBD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQLBD;
        private System.Windows.Forms.ToolStripMenuItem menu_SeasonManager;
        private System.Windows.Forms.ToolStripMenuItem menu_Calendar;
        private System.Windows.Forms.ToolStripMenuItem menu_Result;
        private System.Windows.Forms.ToolStripMenuItem menu_Report;
        private System.Windows.Forms.ToolStripMenuItem menu_Regulation;
        private System.Windows.Forms.ToolStripMenuItem button_ClubResigtator;
        private System.Windows.Forms.ToolStripMenuItem button_PlayerRegistator;
        private System.Windows.Forms.ToolStripMenuItem button_ClubInfo;
        private System.Windows.Forms.ToolStripMenuItem button_ManageSchedule;
        private System.Windows.Forms.ToolStripMenuItem menu_BrowseSchedule;
        private System.Windows.Forms.ToolStripMenuItem button_ResultReport;
        private System.Windows.Forms.ToolStripMenuItem button_ScorerRecord;
        private System.Windows.Forms.ToolStripMenuItem button_BrowseResult;
        private System.Windows.Forms.ToolStripMenuItem button_Search;
        private System.Windows.Forms.ToolStripMenuItem button_PlayerRegulation;
        private System.Windows.Forms.ToolStripMenuItem button_GoalRegulation;
    }
}

