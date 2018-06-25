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
    public partial class ClubRegistationForm : Form
    {
        public ClubRegistationForm()
        {
            InitializeComponent();
            Status("ok");
            LoadDataGV();
            FilltextMuaGiai();
        }
        private void LoadDataGV()
        {
            DataTable tb = createTable();
            this.doibonG_MUAGIAITableAdapter1.Fill(this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI.Rows)
            {
                string[] doi = LayDoi(row["MaDoi"].ToString());
                string[] san = LaySan(row["MaSan"].ToString());
                string mua = LayMua(row["MaMua"].ToString());
                AddRows(ref tb, doi[0], doi[1], mua, san[0], san[1], san[2],san[3]);
            }
            dataGridView1.DataSource = tb;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
            //doibonG_MUAGIAITableAdapter1.Fill(giaivodichbongdaDataSet1.DOIBONG_MUAGIAI);
            //dataGridView1.DataSource = giaivodichbongdaDataSet1.DOIBONG_MUAGIAI;
        }
        #region Properties
        private bool them;
        private bool sua;
        private bool xoa;
        private string madoi;
        private string tendoi;
        private string sannha;
        private string mamua;
        private string tenmua;
        private string masan;
        #endregion
        #region load status - clear text - Databinding
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

        private void ClearText()
        {
            clubNameTextBox.Text = "";
            homeStadiumTextBox.Text = "";
            seasonCombobox.Text = "";
            addressTextBox.Text = "";
            capacityTextbox.Text = "";
        }

        private void DataBinding()
        {
            //doibonG_MUAGIAITableAdapter1.Fill(giaivodichbongdaDataSet1.DOIBONG_MUAGIAI);
            //dataGridView1.DataSource = giaivodichbongdaDataSet1.DOIBONG_MUAGIAI;
            txt_madoi.DataBindings.Clear();
            txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "Mã Đội");
            clubNameTextBox.DataBindings.Clear();
            clubNameTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "Tên Đội");
            seasonCombobox.DataBindings.Clear();
            seasonCombobox.DataBindings.Add("Text", dataGridView1.DataSource, "Tên Mùa");
            homeStadiumTextBox.DataBindings.Clear();
            homeStadiumTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "Tên Sân");
            capacityTextbox.DataBindings.Clear();
            capacityTextbox.DataBindings.Add("Text", dataGridView1.DataSource, "Sức Chứa");
            addressTextBox.DataBindings.Clear();
            addressTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "Địa Chỉ");
            txt_masan.DataBindings.Clear();
            txt_masan.DataBindings.Add("Text", dataGridView1.DataSource, "Mã Sân");
        }

        #endregion
        private string[] LayDoi(string madoi)
        {
            string[] doi = new string[2];
            this.doibongTableAdapter1.FillByMadoi(this.giaivodichbongdaDataSet1.DOIBONG, madoi);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.DOIBONG.Rows)
            {
                doi[0] = r["MaDoi"].ToString();
                doi[1] = r["TenDoi"].ToString();
            }
            return doi;
        }
        private string[] LaySan(string masan)
        {
            string[] san = new string[4];
            this.sanTableAdapter1.FillByMaSan(this.giaivodichbongdaDataSet1.SAN, masan);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.SAN.Rows)
            {
                san[0] = r["MaSan"].ToString();
                san[1] = r["TenSan"].ToString();
                san[2] = r["DiaChi"].ToString();
                san[3] = r["SucChua"].ToString();
            }
            return san;
        }
        private string LayMua(string mamua)
        {
            this.muagiaiTableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.MUAGIAI, mamua);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.MUAGIAI.Rows)
            {
                return row["TenMua"].ToString();
            }
            return null;
        }
        private void AddRows(ref DataTable tb, string madoi, string tendoi, string tenmua, string masan, string tensan, string diachi,string succhua)
        {
            tb.Rows.Add(madoi, tendoi, tenmua, masan, tensan, diachi,succhua);
        }
        private void FilltextMuaGiai()
        {
            try
            {
                this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
                seasonCombobox.DataSource = giaivodichbongdaDataSet1.MUAGIAI;
                seasonCombobox.DisplayMember = "TenMua";
                seasonCombobox.ValueMember = "MaMua";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataTable createTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã Đội", typeof(string));
            tb.Columns.Add("Tên Đội", typeof(string));
            tb.Columns.Add("Tên Mùa", typeof(string));
            tb.Columns.Add("Mã Sân", typeof(string));
            tb.Columns.Add("Tên Sân", typeof(string));
            tb.Columns.Add("Địa Chỉ", typeof(string));
            tb.Columns.Add("Sức Chứa", typeof(string));
            return tb;
        }
        private string SinhMaTuDong_Doi()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaDoiMax().ToString();
                if (numbermax != "")
                {
                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "DB" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "DB0001";
                }
                return code;

            }
            catch (Exception)
            {
            }
            return null;
        }
        private string SinhMaTuDong_San()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaSanMax().ToString();
                if (numbermax != "")
                {
                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "SA" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "SA0001";
                }
                return code;
            }
            catch (Exception)
            {
            }
            return null;
        }
        private void addClubButton_Click(object sender, EventArgs e)
        {

            Status("them");
            FilltextMuaGiai();
            ClearText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.doibongTableAdapter1.Insert(clubNameTextBox.Text, clubNameTextBox.Text, new DateTime());//insert doi
            //this.sanTableAdapter1.Insert(homeStadiumTextBox.Text, homeStadiumTextBox.Text, addressTextBox.Text);// insert san
            //this.doibonG_MUAGIAITableAdapter1.Insert(seasonCombobox.Text, clubNameTextBox.Text, homeStadiumTextBox.Text);//insert doibong_muagiai
            //MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ClearText();
            try
            {
                if (them)
                {
                    madoi = SinhMaTuDong_Doi();
                    tendoi = clubNameTextBox.Text.Trim();
                    sannha = homeStadiumTextBox.Text.Trim();
                    masan = SinhMaTuDong_San();
                    string diachi = addressTextBox.Text.Trim();
                    string succhua = capacityTextbox.Text.Trim();
                    if (clubNameTextBox.Text == "")
                    {
                        MessageBox.Show("Nhập tên đội");
                        return;
                    }
                    if (homeStadiumTextBox.Text == "")
                    {
                        MessageBox.Show("Nhập tên sân");
                        return;
                    }
                    if (capacityTextbox.Text == "")
                    {
                        MessageBox.Show("Nhập sức chưa");
                        return;
                    }
                    if (addressTextBox.Text == "")
                    {
                        MessageBox.Show("Nhập địa chỉ sân");
                        return;
                    }
                    this.doibongTableAdapter1.Insert(madoi, tendoi,DateTime.Now);//insert doi
                    this.sanTableAdapter1.Insert(masan, sannha, diachi,int.Parse(succhua));// insert san
                    this.doibonG_MUAGIAITableAdapter1.Insert(mamua, madoi, masan);//insert doibong_muagiai
                    MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }

                else if (sua)
                {
                    madoi = txt_madoi.Text.Trim();
                    masan = txt_masan.Text.Trim();
                    mamua = seasonCombobox.SelectedValue.ToString();
                    if (clubNameTextBox.Text == "")
                    {
                        MessageBox.Show("Nhập tên đội");
                        return;
                    }
                    if (homeStadiumTextBox.Text == "")
                    {
                        MessageBox.Show("Nhập tên sân");
                        return;
                    }
                    if (capacityTextbox.Text == "")
                    {
                        MessageBox.Show("Nhập sức chưa");
                        return;
                    }
                    if (addressTextBox.Text == "")
                    {
                        MessageBox.Show("Nhập địa chỉ sân");
                        return;
                    }
                    this.doibongTableAdapter1.UpdateByMaDoi(clubNameTextBox.Text.Trim(), madoi,madoi);
                    this.doibonG_MUAGIAITableAdapter1.FillByMaDoiMaMua(this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI, madoi, mamua);
                    this.sanTableAdapter1.UpdateByMaSan(homeStadiumTextBox.Text.Trim(), addressTextBox.Text.Trim(), masan, masan);
                    this.doibonG_MUAGIAITableAdapter1.UpdateBy_Madoi_Masan(mamua, madoi, masan,madoi);
                    MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (xoa)
                {
                    madoi = txt_madoi.Text.Trim();
                    if (seasonCombobox.SelectedValue != null && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        masan = txt_masan.Text.Trim();
                        mamua = seasonCombobox.SelectedValue.ToString();
                        this.doibonG_MUAGIAITableAdapter1.DeleteBy_MaMua_MaDoi(mamua, madoi);
                        this.doibongTableAdapter1.DeleteByMaDoi(madoi);
                        this.sanTableAdapter1.DeleteByMaSan(masan);
                    }
                    ClearText();
                    DataBinding();
                }
                LoadDataGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void seasonCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seasonCombobox.Text != "")
            {
                mamua = seasonCombobox.SelectedValue.ToString();
            }
        }
        private void capacityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            FilltextMuaGiai();
            Status("sua");
            DataBinding();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            Status("xoa");
            ClearText();
            FilltextMuaGiai();
            DataBinding();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            Status("ok");
            ClearText();
        }

        private void ClubRegistationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
