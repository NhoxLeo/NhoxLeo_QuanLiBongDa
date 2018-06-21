using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBongDa.Form_Designs;

namespace QuanLyBongDa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_ClubResigtator_Click(object sender, EventArgs e)
        {
            ClubRegistationForm clubRegistationForm = new ClubRegistationForm();
            clubRegistationForm.ShowDialog();
        }

        private void button_PlayerRegistator_Click(object sender, EventArgs e)
        {
            PlayerRegistationForm playerRegistationForm = new PlayerRegistationForm();
            playerRegistationForm.ShowDialog();
        }

        private void button_ClubInfo_Click(object sender, EventArgs e)
        {
            ClubInfoForm clubInfoForm = new ClubInfoForm();
            clubInfoForm.ShowDialog();
        }

        private void button_ManageSchedule_Click(object sender, EventArgs e)
        {
            ScheduleManagerForm scheduleManagerForm = new ScheduleManagerForm();
            scheduleManagerForm.ShowDialog();
        }

        private void menu_BrowseSchedule_Click(object sender, EventArgs e)
        {
            ScheduleBrowserForm scheduleBrowserForm = new ScheduleBrowserForm();
            scheduleBrowserForm.ShowDialog();
        }

        private void button_ResultReport_Click(object sender, EventArgs e)
        {
            ResultReporterForm resultReporterForm = new ResultReporterForm();
            resultReporterForm.ShowDialog();
        }

        private void button_ScorerRecord_Click(object sender, EventArgs e)
        {
            ScorerRecordForm scorerRecordForm = new ScorerRecordForm();
            scorerRecordForm.ShowDialog();
        }

        private void button_BrowseResult_Click(object sender, EventArgs e)
        {
            ResultBrowserForm resultBrowserForm = new ResultBrowserForm();
            resultBrowserForm.ShowDialog();
        }

        private void button_leagueTable_Click(object sender, EventArgs e)
        {
            LeagueTableForm leagueTableForm = new LeagueTableForm();
            leagueTableForm.ShowDialog();
        }

        private void button_ScorerList_Click(object sender, EventArgs e)
        {
            ScorerListForm scorerListForm = new ScorerListForm();
            scorerListForm.ShowDialog();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void button_PlayerRegulation_Click(object sender, EventArgs e)
        {
            PlayerRegulationForm playerRegulationForm = new PlayerRegulationForm();
            playerRegulationForm.ShowDialog();
        }

        private void button_GoalRegulation_Click(object sender, EventArgs e)
        {
            GoalRegulationForm goalRegulationForm = new GoalRegulationForm();
            goalRegulationForm.ShowDialog();
        }
    }
}
