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
    public partial class ScorerRecordForm : Form
    {
        public ScorerRecordForm()
        {
            InitializeComponent();
            LoadDataGV();
            chon = false;
            Status(null);
        }
        #region Properties
        private bool chon;
        private bool them;
        private bool sua;
        private bool xoa;

        private string thoiluong;
        private string madoi1;
        private string madoi2;
        private string macauthu;
        private string matrandau;
        private string maloaibt;
        private string mabanthang;

        private QueriesTableAdapter queries = new QueriesTableAdapter();
        #endregion
        #region Load Status - Databinding
        private void Status(string stt)
        {
            switch (stt)
            {
                case "chon":
                    button_sua.Enabled = true;
                    button_xoa.Enabled = true;
                    button_them.Enabled = true;
                    chon = true;
                    break;
                case "them":
                    txt_tencauthu.Enabled = true;
                    txt_thoidiem.Enabled = true;
                    txt_loaibanthang.Enabled = true;
                    button_huy.Enabled = true;
                    button_ok.Enabled = true;
                    them = true;
                    xoa = false;
                    sua = false;
                    break;
                case "sua":
                    txt_tencauthu.Enabled = true;
                    txt_thoidiem.Enabled = true;
                    txt_loaibanthang.Enabled = true;
                    button_huy.Enabled = true;
                    button_ok.Enabled = true;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    txt_tencauthu.Enabled = false;
                    txt_thoidiem.Enabled = false;
                    txt_loaibanthang.Enabled = false;
                    button_huy.Enabled = true;
                    button_ok.Enabled = true;
                    xoa = true;
                    sua = false;
                    them = false;
                    break;
                case "huy":
                    txt_tencauthu.Enabled = false;
                    txt_thoidiem.Enabled = false;
                    txt_loaibanthang.Enabled = false;
                    break;
                default:
                    txt_tencauthu.Enabled = false;
                    txt_thoidiem.Enabled = false;
                    txt_loaibanthang.Enabled = false;
                    button_ok.Enabled = false;
                    button_sua.Enabled = false;
                    button_xoa.Enabled = false;
                    button_them.Enabled = true;
                    button_huy.Enabled = false;
                    break;
            }
        }
        private void Databinding()
        {
            txt_tencauthu.DataBindings.Clear();
            txt_tencauthu.DataBindings.Add("Text", dataGridView1.DataSource, "TenCauThu");

            txt_thoidiem.DataBindings.Clear();
            txt_thoidiem.DataBindings.Add("Text", dataGridView1.DataSource, "ThoiDiem");

            txt_loaibanthang.DataBindings.Clear();
            txt_loaibanthang.DataBindings.Add("Text", dataGridView1.DataSource, "TenLoaiBanThang");

            txt_mabanthang.DataBindings.Clear();
            txt_mabanthang.DataBindings.Add("Text", dataGridView1.DataSource, "MaBanThang");
        }
        #endregion
        #region Load datagridview
        private void LoadDataGV()
        {
            DataTable mainTable = newDataTable();
            this.cauthughibanTableAdapter1.FillByMaTranDau(this.giaivodichbongdaDataSet1.CAUTHUGHIBAN, matrandau);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHUGHIBAN.Rows)
            {
                string mabanthang = row["MaBanThang"].ToString();
                string matd = row["MaTranDau"].ToString();
                string mact = row["MaCauThu"].ToString();
                string thoidiem = row["ThoiDiem"].ToString();
                string maloaibt = row["MaLoaiBanThang"].ToString();
                mainTable.Rows.Add(newRows(mabanthang, mact, thoidiem, maloaibt));
            }
            dataGridView1.DataSource = mainTable;
        }
        private DataTable newDataTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MaBanThang", typeof(string));
            tb.Columns.Add("TenCauThu", typeof(string));
            tb.Columns.Add("ThoiDiem", typeof(string));
            tb.Columns.Add("TenLoaiBanThang", typeof(string));
            return tb;
        }

        private Object[] newRows(string mabanthang, string macauthu, string thoidiem, string maloaibt)
        {
            string[] tem = new string[4];
            tem[0] = mabanthang;
            tem[1] = LayTenCauThu(macauthu);
            tem[2] = thoidiem;
            tem[3] = LayLoaiBanThang(maloaibt);
            return tem;
        }

        private string LayTenCauThu(string macauthu)
        {
            string tencauthu = "";
            this.cauthuTableAdapter1.FillBy_MaCauthu(this.giaivodichbongdaDataSet1.CAUTHU, macauthu);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU)
            {
                tencauthu = row["TenCauThu"].ToString();
            }
            return tencauthu;
        }
        private string LayLoaiBanThang(string maloaibanthang)
        {
            string loaibanthang = "";
            this.loaibanthangTableAdapter1.FillByMaLoaiBanThang(this.giaivodichbongdaDataSet1.LOAIBANTHANG, maloaibanthang);
            foreach (DataRow row in giaivodichbongdaDataSet1.LOAIBANTHANG.Rows)
            {
                loaibanthang = row["TenLoaiBanThang"].ToString();
            }
            return loaibanthang;
        }
        private string[] LayMaDoi(string matrandau)
        {
            string[] temp = new string[2];
            //if (FrmChonKetQua.ok)
            //{
            //    this.trandauTableAdapter1.FillByMaTranDau(this.giaivodichbongdaDataSet1.TRANDAU, matrandau);
            //    foreach (DataRow row in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
            //    {
            //        temp[0] = row["MaDoi1"].ToString();
            //        temp[1] = row["MaDoi2"].ToString();
            //    }
            //}
            return temp;
        }
        #endregion
        private string SinhMaTuDong()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaBanThangMax().ToString();
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
        private void FilltextCauThu(string mamua, string madoi1, string madoi2)
        {
            this.cauthuTableAdapter1.FillBy_Mamua_Madoi1_Madoi2(this.giaivodichbongdaDataSet1.CAUTHU, madoi1, madoi2, mamua);
            DataTable tb = this.giaivodichbongdaDataSet1.CAUTHU.Copy();
            txt_tencauthu.DataSource = tb;
            txt_tencauthu.DisplayMember = "TenCauThu";
            txt_tencauthu.ValueMember = "MaCauThu";
            txt_tencauthu.Text = "";
        }
        private void FilltextLoaiBanThang()
        {
            this.loaibanthangTableAdapter1.Fill(this.giaivodichbongdaDataSet1.LOAIBANTHANG);
            txt_loaibanthang.DataSource = this.giaivodichbongdaDataSet1.LOAIBANTHANG;
            txt_loaibanthang.DisplayMember = "TenLoaiBanThang";
            txt_loaibanthang.ValueMember = "MaLoaiBanThang";
            txt_loaibanthang.Text = "";
        }


        private void button_trandau_Click(object sender, System.EventArgs e)
        {
            //FrmChonKetQua chonKetQua = new FrmChonKetQua();
            //chonKetQua.ShowDialog();
            //if (FrmChonKetQua.ok)
            //{
            //    txt_doi1.Text = FrmChonKetQua.tendoi1;
            //    txt_doi2.Text = FrmChonKetQua.tendoi2;
            //    txt_banthangdoi1.Text = FrmChonKetQua.sobanthangdoi1;
            //    txt_banthangdoi2.Text = FrmChonKetQua.sobanthangdoi2;
            //    thoiluong = FrmChonKetQua.thoiluong;
            //    matrandau = FrmChonKetQua.matrandau;
            //    string[] madoitemp = LayMaDoi(matrandau);
            //    madoi1 = madoitemp[0];
            //    madoi2 = madoitemp[1];
            //    LoadDataGV();
            //    Status("chon");
            //    FilltextCauThu(FrmChonKetQua.mamua, madoi1, madoi2);
            //    FilltextLoaiBanThang();
            //}
        }
        private void button_them_Click(object sender, System.EventArgs e)
        {
            Status("them");
        }
        private void button_sua_Click(object sender, EventArgs e)
        {
            //Status("sua");
            //if (FrmChonKetQua.ok)
            //{
            //    FilltextCauThu(FrmChonKetQua.mamua, madoi1, madoi2);
            //    FilltextLoaiBanThang();

            //}
            //Databinding();

        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            //Status("xoa");
            //if (FrmChonKetQua.ok)
            //{
            //    FilltextCauThu(FrmChonKetQua.mamua, madoi1, madoi2);
            //    FilltextLoaiBanThang();

            //}
            //Databinding();

        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            //if (chon && them)
            //{
            //    if (txt_thoidiem.Text == "")
            //    {
            //        MessageBox.Show("Nhập thời điểm ghi bàn");
            //        return;
            //    }

            //    if (int.Parse(queries.GetThoiLuongTranDau(matrandau).ToString()) < int.Parse(txt_thoidiem.Text.Trim()))
            //    {
            //        MessageBox.Show("Thời điểm ghi bàn ko chính xác: 0 < thời điểm < " +
            //                        queries.GetThoiLuongTranDau(matrandau) + "");
            //        return;
            //    }

            //    if (txt_tencauthu.Text == "")
            //    {
            //        MessageBox.Show("Chọn cầu thủ");
            //        return;
            //    }

            //    if (txt_loaibanthang.Text.Trim() == "")
            //    {
            //        MessageBox.Show("Chọn loại bàn thắng");
            //        return;
            //    }


            //    mabanthang = SinhMaTuDong();
            //    this.chitiettrandauTableAdapter.Insert(mabanthang, matrandau, macauthu, int.Parse(txt_thoidiem.Text.Trim()), maloaibt);
            //    MessageBox.Show("Thao tác thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (chon && sua)
            //{
            //    if (txt_thoidiem.Text == "")
            //    {
            //        MessageBox.Show("Nhập thời điểm ghi bàn");
            //        return;
            //    }

            //    if (int.Parse(queries.GetThoiLuongTranDau(matrandau).ToString()) < int.Parse(txt_thoidiem.Text.Trim()))
            //    {
            //        MessageBox.Show("Thời điểm ghi bàn ko chính xác: 0 < thời điểm < " +
            //                        queries.GetThoiLuongTranDau(matrandau) + "");
            //        return;
            //    }

            //    if (txt_tencauthu.Text == "")
            //    {
            //        MessageBox.Show("Chọn cầu thủ");
            //        return;
            //    }

            //    if (txt_loaibanthang.Text.Trim() == "")
            //    {
            //        MessageBox.Show("Chọn loại bàn thắng");
            //        return;
            //    }
            //    mabanthang = txt_mabanthang.Text.Trim();
            //    this.chitiettrandauTableAdapter.UpdateByMaBT(matrandau, macauthu, int.Parse(txt_thoidiem.Text.Trim()),
            //        maloaibt, mabanthang);
            //    MessageBox.Show("Thao tác thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (chon && xoa && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    mabanthang = txt_mabanthang.Text.Trim();
            //    this.chitiettrandauTableAdapter.DeleteByMaBT(mabanthang);

            //}
            //if (FrmChonKetQua.ok)
            //    FilltextCauThu(FrmChonKetQua.mamua, madoi1, madoi2);
            //LoadDataGV();
            //FilltextLoaiBanThang();
        }
        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("huy");

        }

        private void txt_tencauthu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {

                string temp = txt_tencauthu.SelectedValue.ToString();
                int kq = int.Parse(temp.Substring(2)) / 1;
                macauthu = txt_tencauthu.SelectedValue.ToString();


            }
            catch (Exception)
            {

            }
        }
        private void txt_loaibanthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                string temp = txt_loaibanthang.SelectedValue.ToString();
                int kq = int.Parse(temp.Substring(3)) / 1;
                maloaibt = txt_loaibanthang.SelectedValue.ToString();


            }
            catch (Exception)
            {

            }
        }
        private void txt_thoidiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
