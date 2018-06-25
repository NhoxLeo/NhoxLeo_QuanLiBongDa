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
    public partial class PlayerRegulationForm : Form
    {
        public PlayerRegulationForm()
        {
            InitializeComponent();
            //this._Mypanel = panel1;
            this.lOAICAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAICAUTHU);
            this.qUYDINHCAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHCAUTHU);
            DataBinding_quydinhchung();
            DataBinding_cauthu();
        }
        private bool them;
        private bool sua;
        private bool xoa;
        private void PlayerRegulationForm_Load(object sender, EventArgs e)
        {

        }
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
        private void DataBinding_quydinhchung()
        {
            //this.lOAICAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAICAUTHU);
            //this.qUYDINHCAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHCAUTHU);
            //dataGridView_quydinh.DataSource = gIAIVODICHBONGDADataSet.QUYDINHCAUTHU;
            txt_maqd.DataBindings.Clear();
            txt_maqd.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "MaQuyDinh");
            txt_tuoitoithieu.DataBindings.Clear();
            txt_tuoitoithieu.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "TuoiToiThieu");
            txt_tuoitoida.DataBindings.Clear();
            txt_tuoitoida.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "TuoiToiDa");
            txt_socauthutoithieu.DataBindings.Clear();
            txt_socauthutoithieu.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "SoCauThuToiThieu");
            txt_socauthutoida.DataBindings.Clear(); txt_socauthutoida.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "SoCauThuToiDa");
            txt_cauthunuocngoai.DataBindings.Clear();
            txt_cauthunuocngoai.DataBindings.Add("Text", dataGridView_quydinh.DataSource, "SoCauThuNuocNgoaiToiDa");
        }
        private void DataBinding_cauthu()
        {
            this.lOAICAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAICAUTHU);
            this.qUYDINHCAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHCAUTHU);
            dataGridView_loaict.DataSource = gIAIVODICHBONGDADataSet.LOAICAUTHU;
            txt_maloai.DataBindings.Clear();
            txt_maloai.DataBindings.Add("Text", dataGridView_loaict.DataSource, "MaLoaiCauThu");
            txt_loaicauthu.DataBindings.Clear();
            txt_loaicauthu.DataBindings.Add("Text", dataGridView_loaict.DataSource, "TenLoaiCauThu");
        }
        private string SinhMaTuDong()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaLoaiCauThuMax().ToString();
                if (numbermax != "")
                {
                    int temp = int.Parse(numbermax) + 1;
                    code = "000" + temp;
                    code = "LCT" + code.Substring(code.Length - 3);
                }
                else
                {
                    code = "LCT001";
                }
                return code;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        private void button_quydinhchung_Click(object sender, EventArgs e)
        {
            int tuoitoithieu = int.Parse(txt_tuoitoithieu.Text.Trim());
            int tuoitoida = int.Parse(txt_tuoitoida.Text.Trim());
            int socttoithieu = int.Parse(txt_socauthutoithieu.Text.Trim());
            int socttoida = int.Parse(txt_socauthutoida.Text.Trim());
            int soctnuocngoai = int.Parse(txt_cauthunuocngoai.Text.Trim());
            this.qUYDINHCAUTHUTableAdapter.UpdateByMaQuyDinh(tuoitoithieu, tuoitoida, socttoithieu, socttoida, soctnuocngoai,int.Parse(txt_maqd.Text.Trim()), int.Parse(txt_maqd.Text.Trim()));
            this.qUYDINHCAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.QUYDINHCAUTHU);
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            txt_loaicauthu.Text = "";
        }
        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (them)
            {
                this.lOAICAUTHUTableAdapter.Insert(SinhMaTuDong(), txt_loaicauthu.Text.Trim());
            }
            else if (sua)
            {
                this.lOAICAUTHUTableAdapter.UpdateByMaLoaiCT(txt_loaicauthu.Text.Trim(), txt_maloai.Text.Trim(), txt_maloai.Text.Trim());
            }
            else if (xoa)
            {
                this.lOAICAUTHUTableAdapter.DeleteByMaLoaiCT(txt_maloai.Text.Trim());
            }
            this.lOAICAUTHUTableAdapter.Fill(this.gIAIVODICHBONGDADataSet.LOAICAUTHU);
        }
        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("");
            txt_loaicauthu.Text = "";
        }
        private void txt_tuoitoithieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_tuoitoida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_socauthutoithieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_socauthutoida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_cauthunuocngoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
