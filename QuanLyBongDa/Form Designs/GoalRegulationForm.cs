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
    public partial class GoalRegulationForm : Form
    {
        public GoalRegulationForm()
        {
            InitializeComponent();
            DataBinding_loaict();
            DataBinding_quydinh();
            this.qUYDINHBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHBANTHANG);
            this.lOAIBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAIBANTHANG);
        }
        private bool them;
        private bool sua;
        private bool xoa;
        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    button_ok.Enabled = true;
                    button_sua.Enabled = false;
                    button_xoa.Enabled = false;
                    them = true;
                    xoa = false;
                    sua = false;
                    break;
                case "sua":
                    button_ok.Enabled = true;
                    button_them.Enabled = false;
                    button_xoa.Enabled = false;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    button_ok.Enabled = true;
                    button_them.Enabled = false;
                    button_sua.Enabled = false;
                    xoa = true;
                    them = false;
                    sua = false;
                    break;
                default:
                    button_ok.Enabled = false;
                    them = sua = xoa = false;
                    button_ok.Enabled = true;
                    button_them.Enabled = true;
                    button_sua.Enabled = true;
                    button_xoa.Enabled = true;
                    break;
            }
        }
        private void GoalRegulationForm_Load(object sender, EventArgs e)
        {
            //this.qUYDINHBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHBANTHANG);
            //this.lOAIBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAIBANTHANG);
        }
        private void DataBinding_loaict()
        {
            //this.qUYDINHBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHBANTHANG);
            //this.lOAIBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAIBANTHANG);
            //dataGridView_loaibt.DataSource = this.gIAIVODICHBONGDADataSet.LOAIBANTHANG;
            txt_maloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", dataGridView_loaibt.DataSource, "MaLoaiBanThang");
            txt_loaibt.DataBindings.Clear();
            txt_loaibt.DataBindings.Add("Text", dataGridView_loaibt.DataSource, "TenLoaiBanThang");
        }
        private void DataBinding_quydinh()
        {
            //this.qUYDINHBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHBANTHANG);
            //this.lOAIBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAIBANTHANG);
            //dataGridView_quydinh.DataSource = gIAIVODICHBONGDADataSet.QUYDINHBANTHANG;
            txtMaQuyDinh.DataBindings.Clear();
            txtMaQuyDinh.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "MaQuyDinh");
            txt_thoidiem.DataBindings.Clear();
            txt_thoidiem.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "ThoiDiemGhiBanToiDa");
            //txt_thang.DataBindings.Clear();
            //txt_thang.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "THANG");
            //txt_hoa.DataBindings.Clear();
            //txt_hoa.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "HOA");
            //txt_thua.DataBindings.Clear();
            //txt_thua.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "THUA");
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            txt_loaibt.Text = "";
        }
        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {

                if (them)
                {
                    string t = txt_loaibt.Text.Trim();
                    string v = SinhMaTuDong();
                    this.lOAIBANTHANGTableAdapter.Insert(v, t);
                }
                //else if (sua)
                //{
                //    this.lOAIBANTHANGTableAdapter.UpdateByMaBT(txt_loaibt.Text.Trim(), txt_maloai.Text.Trim());
                //}
                //else if (xoa)
                //{
                //    this.lOAIBANTHANGTableAdapter.DeleteByMaBT(txt_maloai.Text.Trim());
                //}
                this.lOAIBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAIBANTHANG);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
        }
        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("");
            txt_loaibt.Text = "";
        }
        private void button_dongy_Click(object sender, EventArgs e)
        {
            int thoidiem = int.Parse(txt_thoidiem.Text.Trim());
            int maquydinh = int.Parse(txtMaQuyDinh.Text.Trim());
            //int thang = int.Parse(txt_thang.Text.Trim());
            //int hoa = int.Parse(txt_hoa.Text.Trim());
            //int thua = int.Parse(txt_thua.Text.Trim());
            this.qUYDINHBANTHANGTableAdapter.UpdateByMaQuyDinh(thoidiem,maquydinh,maquydinh);
            this.qUYDINHBANTHANGTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHBANTHANG);
        }
        private string SinhMaTuDong()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaLoaiBanThangMax().ToString();
                if (numbermax != "")
                {
                    int temp = int.Parse(numbermax) + 1;
                    code = "000" + temp;
                    code = "LBT" + code.Substring(code.Length - 3);
                }
                else
                {
                    code = "LBT001";
                }
                return code;
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
