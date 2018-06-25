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
    public partial class ResultReporterForm : Form
    {
        public ResultReporterForm()
        {
            InitializeComponent();
            LoadDataGV();
            Status(null);
            Databiding();
        }
        #region properties
        private bool them;
        private bool sua;
        public static string tenmua;
        public static string tenvongdau;
        public static string matrandau;
        public static string tendoi1;
        public static string tendoi2;
        public static DateTime thoigian;
        public static string tensan;
        public static string madoi1;
        public static string madoi2;
        public static string masan;
        public static string mamua;
        public static string mavongdau;
        public static string sobanthangdoi1;
        public static string sobanthangdoi2;
        public static string thoiluong;
        #endregion
        #region status - cleartext - databinding

        private void ClearText()
        {
            txt_banthangdoi1.Text = txt_banthangdoi2.Text = txt_thoiluong.Text = "";
        }
        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    txt_banthangdoi1.Enabled = true;
                    txt_banthangdoi2.Enabled = true;
                    txt_thoiluong.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    them = true;
                    sua = false;
                    team1Combobox.Enabled = true;
                    team1Combobox.Visible = true;
                    team2Combobox.Enabled = true;
                    team2Combobox.Visible = true;
                    seasonCombobox.Enabled = true;
                    seasonCombobox.Visible = true;
                    fixtureCombobox.Enabled = true;
                    fixtureCombobox.Visible = true;
                    break;
                case "sua":
                    txt_banthangdoi1.Enabled = true;
                    txt_banthangdoi2.Enabled = true;
                    txt_thoiluong.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    sua = true;
                    them = false;
                    break;
                case "xoa":
                    txt_banthangdoi1.Enabled = false;
                    txt_banthangdoi2.Enabled = false;
                    txt_thoiluong.Enabled = false;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    them = false;
                    sua = false;
                    break;
                case "huy":
                    txt_banthangdoi1.Enabled = false;
                    txt_banthangdoi2.Enabled = false;
                    txt_thoiluong.Enabled = false;
                    button_ok.Enabled = false;
                    button_huy.Enabled = false;
                    them = sua = false;
                    ClearText();
                    team1Combobox.Enabled = false;
                    team1Combobox.Visible = false;
                    team2Combobox.Enabled = false;
                    team2Combobox.Visible = false;
                    seasonCombobox.Enabled = false;
                    seasonCombobox.Visible = false;
                    fixtureCombobox.Enabled = false;
                    fixtureCombobox.Visible = false;
                    break;
                default:
                    txt_banthangdoi1.Enabled = false;
                    txt_banthangdoi2.Enabled = false;
                    txt_thoiluong.Enabled = false;
                    button_ok.Enabled = false;
                    button_huy.Enabled = false;
                    them = sua = false;
                    ClearText();
                    break;
            }
        }
        private void Databiding()
        {
            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MuaGiai");
            txt_doi1.DataBindings.Clear();
            txt_doi1.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi1");
            txt_doi2.DataBindings.Clear();
            txt_doi2.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi2");
            txt_vongthidau.DataBindings.Clear();
            txt_vongthidau.DataBindings.Add("Text", dataGridView1.DataSource, "MaLuot");
            txt_muagiai.DataBindings.Clear();
            txt_muagiai.DataBindings.Add("Text", dataGridView1.DataSource, "MuaGiai");
            txt_matrandau.DataBindings.Clear();
            txt_matrandau.DataBindings.Add("Text", dataGridView1.DataSource, "MaTranDau");
            txt_banthangdoi1.DataBindings.Clear();
            txt_banthangdoi1.DataBindings.Add("Text", dataGridView1.DataSource, "SoBanThangDoi1");
            txt_banthangdoi2.DataBindings.Clear();
            txt_banthangdoi2.DataBindings.Add("Text", dataGridView1.DataSource, "SoBanThangDoi2");
            txt_thoiluong.DataBindings.Clear();
            txt_thoiluong.DataBindings.Add("Text", dataGridView1.DataSource, "ThoiLuong");
        }

        #endregion

        #region load datagridview

        private void LoadDataGV()
        {
            this.trandauTableAdapter1.Fill(this.giaivodichbongdaDataSet1.TRANDAU);
            DataTable table = newTable();
            foreach (DataRow row in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
            {
                if (row["SoBanThangDoi1"].ToString() != "")
                {
                    matrandau = row["MaTranDau"].ToString();
                    madoi1 = row["MaDoi1"].ToString();
                    madoi2 = row["MaDoi2"].ToString();
                    thoigian = Convert.ToDateTime(row["NgayGio"].ToString());
                    masan = row["MaSan"].ToString();
                    mavongdau = row["MaLuot"].ToString();
                    sobanthangdoi1 = row["SoBanThangDoi1"].ToString();
                    sobanthangdoi2 = row["SoBanThangDoi2"].ToString();
                    thoiluong = row["ThoiLuong"].ToString();
                    table.Rows.Add(newRow(matrandau, madoi1, madoi2, mavongdau, sobanthangdoi1, sobanthangdoi2, thoiluong));
                }
            }
            dataGridView1.DataSource = table;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }
        private DataTable newTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaTranDau", typeof(string));
            table.Columns.Add("TenDoi1", typeof(string));
            table.Columns.Add("TenDoi2", typeof(string));
            table.Columns.Add("MaLuot", typeof(string));
            table.Columns.Add("MuaGiai", typeof(string));
            table.Columns.Add("SoBanThangDoi1", typeof(string));
            table.Columns.Add("SoBanThangDoi2", typeof(string));
            table.Columns.Add("ThoiLuong", typeof(string));
            return table;
        }
        private Object[] newRow(string matd, string madoi1, string madoi2, string maluot, string sbtdoi1, string sbtdoi2, string thoiluong)
        {
            string[] row = new string[8];
            row[0] = matd;
            row[1] = LayTenDoi(madoi1);
            row[2] = LayTenDoi(madoi2);
            row[3] = LayTenVongDau(maluot);
            row[4] = LayTenMua(maluot);
            row[5] = sbtdoi1;
            row[6] = sbtdoi2;
            row[7] = thoiluong;
            return row;
        }
        private string LayTenDoi(string madoi)
        {
            string tendoi = "";
            this.doibongTableAdapter1.FillByMadoi(this.giaivodichbongdaDataSet1.DOIBONG, madoi);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.DOIBONG.Rows)
            {
                tendoi = r["TenDoi"].ToString();
            }
            return tendoi;
        }
        private string LayTenVongDau(string maluot)
        {
            string tenvong = "";
            this.luotTableAdapter1.FillByMaLuot(this.giaivodichbongdaDataSet1.LUOT, maluot);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.LUOT.Rows)
            {
                tenvong = r["TenLuot"].ToString();
            }
            return tenvong;
        }
        private string LayTenMua(string maluot)
        {
            string tenmua = "";
            string mamua = "";
            this.luotTableAdapter1.FillByMaLuot(this.giaivodichbongdaDataSet1.LUOT, maluot);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.LUOT.Rows)
            {
                mamua = r["MaMua"].ToString();
            }
            this.muagiaiTableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.MUAGIAI, mamua);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.MUAGIAI.Rows)
            {
                tenmua = r["TenMua"].ToString();
            }
            return tenmua;
        }
        private void FillTExtMuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
            seasonCombobox.DataSource = giaivodichbongdaDataSet1.MUAGIAI;
            seasonCombobox.DisplayMember = "TenMua";
            seasonCombobox.ValueMember = "MaMua";
            //MessageBox.Show(seasonCombobox.ValueMember);
        }
        private void ChonDoi()
        {
            //ResultsForm chondoi = new ResultsForm();
            //chondoi.ShowDialog();
            //matrandau = ResultsForm.matrandau;
            //tenmua = ResultsForm.tenmua;
            //tenvongdau = ResultsForm.tenvongdau;
            //tendoi1 = ResultsForm.doi1;
            //tendoi2 = ResultsForm.doi2;
            //thoigian = ResultsForm.thoigian;
            //tensan = ResultsForm.tensan;


            //comboBox1.Text = tenmua;
            //txt_vongthidau.Text = tenvongdau;
            //txt_doi1.Text = tendoi1;
            //txt_doi2.Text = tendoi2;
        }
        #endregion
        private void button_them_Click(object sender, EventArgs e)
        {
            ChonDoi();
            //if (ResultsForm.ok)
            Status("them");
            ClearText();
            Databiding();
            FillTExtMuaGiai();
        }
        private void button_sua_Click(object sender, EventArgs e)
        {
            Status("sua");
            Databiding();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (them || sua)
                {
                    sobanthangdoi1 = txt_banthangdoi1.Text.Trim();
                    sobanthangdoi2 = txt_banthangdoi2.Text.Trim();
                    thoiluong = txt_thoiluong.Text.Trim();
                    this.trandauTableAdapter1.Update_Kq(int.Parse(sobanthangdoi1), int.Parse(sobanthangdoi2),int.Parse(thoiluong), matrandau, matrandau);
                    MessageBox.Show("Tao tác thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadDataGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("huy");
            Databiding();
        }
        private void ResultReporterForm_Load(object sender, EventArgs e)
        {

        }
        private void txt_banthangdoi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_banthangdoi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
