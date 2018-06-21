using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBongDa.GIAIVODICHBONGDADataSetTableAdapters;

namespace QuanLyBongDa.Form_Designs
{
    public partial class PlayerRegistationForm : Form
    {
        public PlayerRegistationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////LoadStatus("");
            //FilltextLoaiCauThu();
            //FrmChonDoi chondoi = new FrmChonDoi();
            //chondoi.ShowDialog();
            //txt_tendoi.Text = FrmChonDoi.tendoi;
            //madoi = FrmChonDoi.madoi;
            //mamua = FrmChonDoi.mamua;
            //LoadDataGV();
        }
        private void FilltextLoaiCauThu()
        {
            //this.lOAICAUTHUTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.LOAICAUTHU);
            //txt_loaicauthu.DataSource = quanLyGiaiVoDichDataSet.LOAICAUTHU;
            //txt_loaicauthu.DisplayMember = "LOAICT";
            //txt_loaicauthu.ValueMember = "MALOAICT";
            //txt_loaicauthu.Text = "";
        }
    }
}
