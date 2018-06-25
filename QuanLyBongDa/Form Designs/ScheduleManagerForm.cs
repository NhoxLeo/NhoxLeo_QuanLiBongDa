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
    public partial class ScheduleManagerForm : Form
    {
        public ScheduleManagerForm()
        {
            InitializeComponent();
            Status(null);
            LoadDateGV();
            //tbSan = CreateTable();
        }
        #region Properties
        private bool them;
        private bool sua;
        private bool xoa;
        private string mavongdau;
        private string matrandau;
        private string madoi1;
        private string madoi2;
        private string mamua;
        private DateTime thoigian;
        private string masan;
        private string matrongtai;
        private DataTable tbSan = new DataTable();
        #endregion
        #region Status-ClearText
        private void ClearText()
        {
            //txt_muagiai.Text = "";
            //txt_vongdau.Text = "";
            //txt_doi1.Text = "";
            //txt_doi2.Text = "";
            //txt_san.Text = "";
            //dateTime.Value = DateTime.Now;
        }
        private void Status(string stt)
        {
            switch (stt)
            {
                case "them":
                    //txt_muagiai.Enabled = true;
                    //txt_vongdau.Enabled = true;
                    //txt_doi1.Enabled = true;
                    //txt_doi2.Enabled = true;
                    //txt_san.Enabled = true;
                    //dateTime.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    them = true;
                    xoa = false;
                    sua = false;
                    break;
                case "sua":
                    //txt_muagiai.Enabled = true;
                    //txt_vongdau.Enabled = true;
                    //txt_doi1.Enabled = true;
                    //txt_doi2.Enabled = true;
                    //txt_san.Enabled = true;
                    //dateTime.Enabled = true;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    sua = true;
                    them = false;
                    xoa = false;
                    break;
                case "xoa":
                    //txt_muagiai.Enabled = false;
                    //txt_vongdau.Enabled = false;
                    //txt_doi1.Enabled = false;
                    //txt_doi2.Enabled = false;
                    //txt_san.Enabled = false;
                    //dateTime.Enabled = false;
                    button_ok.Enabled = true;
                    button_huy.Enabled = true;
                    xoa = true;
                    them = false;
                    sua = false;
                    break;
                default:
                    //txt_muagiai.Enabled = false;
                    //txt_vongdau.Enabled = false;
                    //txt_doi1.Enabled = false;
                    //txt_doi2.Enabled = false;
                    //txt_san.Enabled = false;
                    //dateTime.Enabled = false;
                    button_ok.Enabled = false;
                    button_huy.Enabled = false;
                    them = sua = xoa = false;
                    ClearText();
                    break;
            }
        }
        #endregion
        #region DataBind
        private void LoadDateGV()
        {
            this.trongtaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.TRONGTAI);
            this.trandauTableAdapter1.Fill(this.giaivodichbongdaDataSet1.TRANDAU);
            this.luotTableAdapter1.Fill(this.giaivodichbongdaDataSet1.LUOT);
            DataTable table = newTable();
            foreach (DataRow row in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
            {
                matrandau = row["MaTranDau"].ToString();
                madoi1 = row["MaDoi1"].ToString();
                madoi2 = row["MaDoi2"].ToString();
                thoigian = Convert.ToDateTime(row["NgayGio"].ToString());
                masan = row["MaSan"].ToString();
                table.Rows.Add(newRow(matrandau, madoi1, madoi2, thoigian, masan, mavongdau));
            }
            foreach (DataRow row in this.giaivodichbongdaDataSet1.TRONGTAI.Rows)
            {
                matrongtai = row["MaTrongTai"].ToString();
            }
            foreach (DataRow row in this.giaivodichbongdaDataSet1.LUOT.Rows)
            {
                mavongdau = row["MaLuot"].ToString();
            }
            dataGridView1.DataSource = table;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }
        private string SinhMaTuDong()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaTranDauMax().ToString();
                if (numbermax != "")
                {
                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "TD" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "TD0001";
                }
                return code;
            }
            catch (Exception)
            {
            }
            return null;
        }
        #endregion
        private DataTable newTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaTranDau", typeof(string));
            table.Columns.Add("MaDoi1", typeof(string));
            table.Columns.Add("MaDoi2", typeof(string));
            table.Columns.Add("NgayGio", typeof(string));
            table.Columns.Add("MaSan", typeof(string));
            table.Columns.Add("VongDau", typeof(string));
            table.Columns.Add("MaMua", typeof(string));
            return table;
        }
        private Object[] newRow(string matd, string madoi1, string madoi2, DateTime ngaygio, string masan, string mavong)
        {
            string[] row = new string[7];
            row[0] = matd;
            row[1] = LayTenDoi(madoi1);
            row[2] = LayTenDoi(madoi2);
            row[3] = ngaygio.ToString("HH:mm MM/dd/yyyy");
            row[4] = LayTenSan(masan);
            //row[5] = LayTenVongDau(mavong);
            //row[6] = LayTenMua(mavong);
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
        private string LayTenSan(string masan)
        {
            string tensan = "";
            this.sanTableAdapter1.FillByMaSan(this.giaivodichbongdaDataSet1.SAN, masan);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.SAN.Rows)
            {
                tensan = r["TenSan"].ToString();
            }
            return tensan;
        }
        private string[] GetInfo_San(string _mamua)
        {
            string[] temp = new string[2];
            this.sanTableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.SAN, _mamua);
            stadiumComboBox.DataSource = this.giaivodichbongdaDataSet1.SAN;
            foreach (DataRow dataRow in this.giaivodichbongdaDataSet1.SAN.Rows)
            {
                temp[0] = dataRow["TenSan"].ToString();
                temp[1] = dataRow["MaSan"].ToString();
                //stadiumComboBox.DisplayMember = dataRow["TenSan"].ToString();
                //stadiumComboBox.ValueMember = dataRow["MaSan"].ToString();
                stadiumComboBox.DisplayMember = "TenSan";
                stadiumComboBox.ValueMember = "MaSan";
            }
            return temp;
        }
        private void GetInfo_TrongTai(string _mamua)
        {
            string[] temp = new string[2];
            this.trongtaiTableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.TRONGTAI, _mamua);
            refereeComboBox.DataSource = this.giaivodichbongdaDataSet1.TRONGTAI;
            foreach (DataRow dataRow in this.giaivodichbongdaDataSet1.TRONGTAI.Rows)
            {
                refereeComboBox.DisplayMember = "TenTrongTai";
                refereeComboBox.ValueMember = "MaTrongTai";
            }
        }
        private string LayTenVongDau(string mavong)
        {
            string tenvong = "";
            //this.vongdauTableAdapter.FillByMaVong(this.quanLyGiaiVoDichDataSet.VONGDAU, mavong);
            //foreach (DataRow r in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            //{
            //    tenvong = r["TENVONG"].ToString();
            //}
            return tenvong;
        }
        private string LayTenMua(string mavong)
        {
            string tenmua = "";
            string mamua = "";
            //this.vongdauTableAdapter.FillByMaVong(this.quanLyGiaiVoDichDataSet.VONGDAU, mavong);
            //foreach (DataRow r in this.quanLyGiaiVoDichDataSet.VONGDAU.Rows)
            //{
            //    mamua = r["MAMUA"].ToString();
            //}
            this.muagiaiTableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.MUAGIAI, mamua);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.MUAGIAI.Rows)
            {
                tenmua = r["TenMua"].ToString();
            }
            return tenmua;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seasonComboBox.SelectedValue != null)
            {
                mamua = seasonComboBox.SelectedValue.ToString();
                string[] _sanInfo = GetInfo_San(mamua);
                GetInfo_TrongTai(mamua);
                this.doibongTableAdapter1.FillBy_Mamua(this.giaivodichbongdaDataSet1.DOIBONG, mamua);
                DataTable tb1 = this.giaivodichbongdaDataSet1.DOIBONG.Copy();
                DataTable tb2 = this.giaivodichbongdaDataSet1.DOIBONG.Copy();
                //Filltext_vongdau(seasonComboBox.SelectedValue.ToString());
                Filltext_Tendoi(ref team1, tb1);
                Filltext_Tendoi(ref team2, tb2);
            }
        }
        private void Filltext_vongdau(string _mamua)
        {
            //try
            //{
            //    this.vongdauTableAdapter.FillByMaMua(this.giaivodichbongdaDataSet1.VONGDAU, _mamua);
            //    seasonComboBox.DataSource = this.giaivodichbongdaDataSet1.VONGDAU;
            //    seasonComboBox.DisplayMember = "TENVONG";
            //    seasonComboBox.ValueMember = "MAVONG";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void Filltext_Tendoi(ref ComboBox cbox, DataTable table)
        {
            try
            {
                cbox.DataSource = table;
                cbox.DisplayMember = "TenDoi";
                cbox.ValueMember = "MaDoi";
                cbox.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Filltext_Muagiai()
        {
            try
            {
                this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
                seasonComboBox.DataSource = this.giaivodichbongdaDataSet1.MUAGIAI;
                seasonComboBox.DisplayMember = "TenMua";
                seasonComboBox.ValueMember = "MaMua";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button_them_Click(object sender, EventArgs e)
        {
            Status("them");
            Filltext_Muagiai();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (them)
                {
                    matrandau = SinhMaTuDong();
                    madoi1 = team1.SelectedValue.ToString();
                    madoi2 = team2.SelectedValue.ToString();
                    thoigian = Convert.ToDateTime(dateTimePicker1.Value.ToString("MM-dd-yyyy HH:mm"));
                    masan = stadiumComboBox.SelectedValue.ToString();
                    matrongtai = refereeComboBox.SelectedValue.ToString();
                    //mavongdau = txt_vongdau.SelectedValue.ToString();
                    this.trandauTableAdapter1.Insert(matrandau, mamua, madoi1, madoi2, masan, matrongtai,null, null, null, Convert.ToDateTime(dateTimePicker1.Value.ToString("MM-dd-yyyy")),mavongdau,90);
                    MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (sua)
                {
                    matrandau = SinhMaTuDong();
                    madoi1 = team1.SelectedValue.ToString();
                    madoi2 = team2.SelectedValue.ToString();
                    thoigian = Convert.ToDateTime(dateTimePicker1.Value.ToString("MM-dd-yyyy HH:mm"));
                    masan = stadiumComboBox.SelectedValue.ToString();
                    //matrandau = txt_matrandau.Text.Trim();
                    //madoi1 = txt_doi1.SelectedValue.ToString();
                    //madoi2 = txt_doi2.SelectedValue.ToString();
                    //thoigian = Convert.ToDateTime(dateTime.Value.ToString());
                    //masan = txt_san.SelectedValue.ToString();
                    //mavongdau = txt_vongdau.SelectedValue.ToString();
                    this.trandauTableAdapter1.UpdateByMaTranDau(madoi1, madoi2, thoigian, masan, mavongdau, matrandau, matrandau);
                    MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (xoa)
                {
                    if (
                        MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                        DialogResult.Yes)
                    {
                        matrandau = SinhMaTuDong();
                        //matrandau = txt_matrandau.Text.Trim();
                        this.trandauTableAdapter1.DeleteByMaTranDau(matrandau);
                    }
                }
                LoadDateGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
