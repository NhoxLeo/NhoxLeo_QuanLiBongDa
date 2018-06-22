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
            //Status("ok");
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
                AddRows(ref tb, doi[0], doi[1], mua, san[0], san[1], san[2]);
            }
            dataGridView1.DataSource = tb; foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
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
                    //button_ok.Enabled = true;
                    //button_sua.Enabled = false;
                    //button_xoa.Enabled = false;
                    them = true;
                    xoa = false;
                    sua = false;
                    break;
                case "sua":
                    //button_ok.Enabled = true;
                    //button_them.Enabled = false;
                    //button_xoa.Enabled = false;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    //button_ok.Enabled = true;
                    //button_them.Enabled = false;
                    //button_sua.Enabled = false;
                    xoa = true;
                    them = false;
                    sua = false;
                    break;
                default:
                    //button_ok.Enabled = false;
                    them = sua = xoa = false;
                    //button_ok.Enabled = true;
                    //button_them.Enabled = true;
                    //button_sua.Enabled = true;
                    //button_xoa.Enabled = true;
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
            //txt_madoi.DataBindings.Clear();
            //txt_madoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaDoi");

            clubNameTextBox.DataBindings.Clear();
            clubNameTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "TenDoi");

            seasonCombobox.DataBindings.Clear();
            seasonCombobox.DataBindings.Add("Text", dataGridView1.DataSource, "TenMua");

            homeStadiumTextBox.DataBindings.Clear();
            homeStadiumTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "TenSan");

            //capacityTextbox.DataBindings.Clear();
            //capacityTextbox.DataBindings.Add("Text", dataGridView1.DataSource, "SucChua");

            addressTextBox.DataBindings.Clear();
            addressTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");

            //txt_masan.DataBindings.Clear();
            //txt_masan.DataBindings.Add("Text", dataGridView1.DataSource, "MaSan");
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
                //san[3] = r["SucChua"].ToString();
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
        private void AddRows(ref DataTable tb, string madoi, string tendoi, string tenmua, string masan, string tensan, string diachi)
        {
            tb.Rows.Add(madoi, tendoi, tenmua, masan, tensan, diachi);
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
            tb.Columns.Add("MaDoi", typeof(string));
            tb.Columns.Add("TenDoi", typeof(string));
            tb.Columns.Add("TENMUA", typeof(string));
            tb.Columns.Add("MaSan", typeof(string));
            tb.Columns.Add("TenSan", typeof(string));
            tb.Columns.Add("DiaChi", typeof(string));
            //tb.Columns.Add("SucChua", typeof(string));
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
            //FilltextMuaGiai();
            LoadDataGV();
            ClearText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.doibongTableAdapter1.Insert(clubNameTextBox.Text, clubNameTextBox.Text,new DateTime());//insert doi
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
                    this.sanTableAdapter1.Insert(masan, sannha, diachi);// insert san
                    this.doibonG_MUAGIAITableAdapter1.Insert(mamua, madoi, masan);//insert doibong_muagiai
                    MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }

                //else if (sua)
                //{
                //    madoi = txt_madoi.Text.Trim();
                //    masan = txt_masan.Text.Trim();

                //    if (txt_tendoi.Text == "")
                //    {
                //        MessageBox.Show("Nhập tên đội");
                //        return;
                //    }

                //    if (txt_tensan.Text == "")
                //    {
                //        MessageBox.Show("Nhập tên sân");
                //        return;
                //    }

                //    if (txt_succhua.Text == "")
                //    {
                //        MessageBox.Show("Nhập sức chưa");
                //        return;
                //    }

                //    if (txt_diachi.Text == "")
                //    {
                //        MessageBox.Show("Nhập địa chỉ sân");
                //        return;
                //    }

                //    this.doibongTableAdapter.UpdateByMaDoi(txt_tendoi.Text.Trim(), madoi);

                //    this.dOIBONG_MUAGIAITableAdapter.FillByMaDoiMaMua(this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI, madoi, mamua);

                //    this.sanTableAdapter.UpdateByMaSan(txt_tensan.Text.Trim(), txt_diachi.Text.Trim(), int.Parse(txt_succhua.Text.Trim()), masan);

                //    this.dOIBONG_MUAGIAITableAdapter.UpdateBy_Madoi_Masan(mamua, madoi, masan);
                //    MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (xoa)
                //{
                //    madoi = txt_madoi.Text.Trim();
                //    if (txt_muagiai.SelectedValue != null && MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //    {
                //        masan = txt_masan.Text.Trim();
                //        mamua = txt_muagiai.SelectedValue.ToString();
                //        this.dOIBONG_MUAGIAITableAdapter.DeleteBy_MaMua_MaDoi(mamua, madoi);
                //        this.doibongTableAdapter.DeleteByMaDoi(madoi);
                //        this.sanTableAdapter.DeleteByMaSan(masan);
                //    }
                //    ClearText();
                //    DataBinding();
                //}
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
    }
}
