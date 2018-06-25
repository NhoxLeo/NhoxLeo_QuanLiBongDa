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
            LoadStatus(null);
            LoadDataGV();
            LayQuyDinh();
            FilltextMuaGiai();
            FilltextDoiBong();
            FilltextLoaiCauThu();
        }
        #region Properties
        private bool them;
        private bool sua;
        private bool xoa;
        private string quoctich;
        private string hoten;
        private DateTime ngaysinh;
        private string ghichu;
        private string macauthu;
        private string maloaicauthu;
        private string madoi = "";
        private string mamua = "";

        private int tuoitoithieu;
        private int tuoitoida;
        private int sct_toithieu;
        private int sct_toida;
        private int sct_nuocngoai;

        QueriesTableAdapter queries = new QueriesTableAdapter();
        #endregion
        private void LoadStatus(string stt)
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
                case "huy":
                    button_ok.Enabled = false;
                    them = sua = xoa = false;
                    button_ok.Enabled = true;
                    button_them.Enabled = true;
                    button_sua.Enabled = true;
                    button_xoa.Enabled = true;
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
        private void LayQuyDinh()
        {
            tuoitoithieu = int.Parse(queries.GetTuoiToiThieu().ToString());
            tuoitoida = int.Parse(queries.GetTuoiToiDa().ToString());
            sct_toithieu = int.Parse(queries.GetSoCauThuToiThieu().ToString());
            sct_toida = int.Parse(queries.GetSoCauThuToiDa().ToString());
            sct_nuocngoai = int.Parse(queries.GetSoCTNNToiDa().ToString());
        }
        private string[] GetInfoCauThu(string macauthu)
        {
            string[] info = new string[6];
            this.cauthuTableAdapter1.FillBy_MaCauthu(this.giaivodichbongdaDataSet1.CAUTHU, macauthu);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU.Rows)
            {
                info[0] = row["MaCauThu"].ToString();
                info[1] = row["TenCauThu"].ToString();
                info[2] = row["NgaySinh"].ToString();
                info[3] = GetLoaiCauThu(row["MaLoaiCauThu"].ToString());
                info[4] = row["QuocTich"].ToString();
                info[5] = row["GhiChu"].ToString();
            }
            return info;
        }
        private string GetLoaiCauThu(string maloaicauthu)
        {
            string loaict = "";
            this.loaicauthuTableAdapter1.FillBy_MaLoaiCT(this.giaivodichbongdaDataSet1.LOAICAUTHU, maloaicauthu);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.LOAICAUTHU.Rows)
            {
                loaict = row["MaLoaiCauThu"].ToString();
            }
            return loaict;
        }
        private void LoadDataGV()
        {
            //DataTable tb = createTable();
            //this.cauthuTableAdapter1.FillBy_Mamua_Madoi(this.giaivodichbongdaDataSet1.CAUTHU, madoi, mamua);
            //DataTable temp = this.giaivodichbongdaDataSet1.CAUTHU.Copy();
            //foreach (DataRow row in temp.Rows)
            //{
            //    tb.Rows.Add(GetInfoCauThu(row["MaCauThu"].ToString()));
            //}
            //dataGridView1.DataSource = tb;

            this.cauthuTableAdapter1.Fill(this.giaivodichbongdaDataSet1.CAUTHU);
            dataGridView1.DataSource = this.giaivodichbongdaDataSet1.CAUTHU;
        }
        private DataTable createTable()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MaCauThu", typeof(string));
            tb.Columns.Add("TenCauThu", typeof(string));
            tb.Columns.Add("NgaySinh", typeof(string));
            tb.Columns.Add("MaLoaiCauThu", typeof(string));
            tb.Columns.Add("QuocTich", typeof(string));
            tb.Columns.Add("GhiChu", typeof(string));
            return tb;
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
            this.loaicauthuTableAdapter1.Fill(this.giaivodichbongdaDataSet1.LOAICAUTHU);
            playerType.DataSource = giaivodichbongdaDataSet1.LOAICAUTHU;
            playerType.DisplayMember = "TenLoaiCauThu";
            playerType.ValueMember = "MaLoaiCauThu";
            playerType.Text = "";
        }
        private void FilltextMuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
            seasonComboBox.DataSource = giaivodichbongdaDataSet1.MUAGIAI;
            seasonComboBox.DisplayMember = "TenMua";
            seasonComboBox.ValueMember = "MaMua";
        }
        private void FilltextDoiBong()
        {
            this.doibongTableAdapter1.Fill(this.giaivodichbongdaDataSet1.DOIBONG);
            clubComboBox.DataSource = giaivodichbongdaDataSet1.DOIBONG;
            clubComboBox.DisplayMember = "TenDoi";
            clubComboBox.ValueMember = "MaDoi";
        }
        private int TinhTuoi(DateTime namsinh)
        {
            if (namsinh < DateTime.Now)  return DateTime.Now.Year - namsinh.Year;
            return 0;
        }
        private string SinhMaTuDong()
        {
            try
            {
                string code = "";
                QueriesTableAdapter queries = new QueriesTableAdapter();
                string numbermax = queries.GetMaCauThuMax().ToString();
                if (numbermax != "")
                {
                    int temp = int.Parse(numbermax) + 1;
                    code = "0000" + temp;
                    code = "CT" + code.Substring(code.Length - 4);
                }
                else
                {
                    code = "CT0001";
                }
                return code;
            }
            catch (Exception)
            {
            }
            return null;
        }
        private void Cleartext()
        {
            playerName.Text = "";
            playerType.Text = "";
            nationalityTexBox.Text = "";
            noteTextBox.Text = "";
        }
        private void Databinding()
        {
            txt_macauthu.DataBindings.Clear();
            txt_macauthu.DataBindings.Add("Text", dataGridView1.DataSource, "MaCauThu");
            playerNameTextBox.DataBindings.Clear();
            playerNameTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "TenCauThu");
            birthday.DataBindings.Clear();
            birthday.DataBindings.Add("Text", dataGridView1.DataSource, "NgaySinh");
            nationalityTexBox.DataBindings.Clear();
            nationalityTexBox.DataBindings.Add("Text", dataGridView1.DataSource, "QuocTich");
            noteTextBox.DataBindings.Clear();
            noteTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "GhiChu");
            playerType.DataBindings.Clear();
            playerType.DataBindings.Add("Text", dataGridView1.DataSource, "MaloaiCauThu");
        }
        private void playerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerType.SelectedValue != null)
            {
                maloaicauthu = playerType.SelectedValue.ToString();
            }
        }
        private void clubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            LoadStatus("them");
            Cleartext();
            FilltextLoaiCauThu();
            LoadDataGV();
        }
        private void button_sua_Click(object sender, EventArgs e)
        {
            LoadStatus("sua");
            //Databinding();
            LoadDataGV();
        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            LoadStatus("xoa");
            Databinding();
            LoadDataGV();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (them)
            {
                if (int.Parse(queries.CountSoCauThuCuaDoi(mamua, madoi).ToString()) >= sct_toida)
                {
                    MessageBox.Show("Không thể thêm cầu thủ, Số Cầu thủ của đội đã đủ");
                    return;
                }
                ngaysinh = Convert.ToDateTime(birthday.Value.ToString("MM-dd-yyyy"));
                if (!(TinhTuoi(ngaysinh) >= tuoitoithieu && TinhTuoi(ngaysinh) <= tuoitoida))
                {
                    MessageBox.Show("Tuổi không đúng quy định, " + tuoitoithieu + "< tuoi <" + tuoitoida);
                    return;
                }
                hoten = playerNameTextBox.Text.Trim();
                if (hoten == "")
                {
                    MessageBox.Show("Nhập tên cầu thủ");
                    return;
                }
                quoctich = nationalityTexBox.Text.Trim();
                if (quoctich == "")
                {
                    MessageBox.Show("Nhập quốc tịch cầu thủ");
                    return;
                }
                macauthu = SinhMaTuDong();
                ghichu = noteTextBox.Text.Trim();
                this.cauthuTableAdapter1.Insert(macauthu, hoten, ngaysinh, quoctich,ghichu,maloaicauthu,null);
                clubComboBox.DisplayMember = "MaDoi";
                madoi = clubComboBox.Text.Trim();
                clubComboBox.DisplayMember = "TenDoi";
                seasonComboBox.DisplayMember = "MaMua";
                mamua = seasonComboBox.Text.Trim();
                seasonComboBox.DisplayMember = "TenMua";
                this.cauthU_MUAGIAITableAdapter1.Insert(mamua, macauthu, madoi, 0);
                MessageBox.Show("Thêm thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sua)
            {
                Databinding();
                clubComboBox.DisplayMember = "MaDoi";
                madoi = clubComboBox.Text.Trim();
                clubComboBox.DisplayMember = "TenDoi";
                seasonComboBox.DisplayMember = "MaMua";
                mamua = seasonComboBox.Text.Trim();
                seasonComboBox.DisplayMember = "TenMua";
                macauthu = txt_macauthu.Text.Trim();
                hoten = playerNameTextBox.Text.Trim();
                maloaicauthu = playerType.Text.Trim();
                if (hoten == "")
                {
                    MessageBox.Show("Nhập tên cầu thủ");
                    return;
                }
                quoctich = nationalityTexBox.Text.Trim();
                if (quoctich == "")
                {
                    MessageBox.Show("Nhập tên cầu thủ");
                    return;
                }
                ngaysinh = Convert.ToDateTime(birthday.Value.ToString("MM-dd-yyyy"));
                if (!(TinhTuoi(ngaysinh) >= tuoitoithieu && TinhTuoi(ngaysinh) <= tuoitoida))
                {
                    MessageBox.Show("Tuổi không đúng quy định, " + tuoitoithieu + "< tuoi <" + tuoitoida);
                    return;
                }
                quoctich = nationalityTexBox.Text.Trim();
                ghichu = noteTextBox.Text.Trim();
                this.cauthuTableAdapter1.UpdateByMaCauThu(hoten, ngaysinh.ToString(),  quoctich, ghichu, maloaicauthu, null,macauthu,macauthu);
                MessageBox.Show("Sửa thành công!", "Success !^^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (xoa)
            {
                Databinding();
                if (MessageBox.Show("Bạn có muốn xoá", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    clubComboBox.DisplayMember = "MaDoi";
                    madoi = clubComboBox.Text.Trim();
                    clubComboBox.DisplayMember = "TenDoi";
                    seasonComboBox.DisplayMember = "MaMua";
                    mamua = seasonComboBox.Text.Trim();
                    seasonComboBox.DisplayMember = "TenMua";
                    macauthu = txt_macauthu.Text.Trim();
                    this.cauthU_MUAGIAITableAdapter1.DeleteBy_MaMua_MaDoi_MaCt(mamua, macauthu, madoi);
                    this.cauthuTableAdapter1.DeleteByMaCauThu(macauthu);
                }
            }
            Cleartext();
            LoadDataGV();
            FilltextLoaiCauThu();
            LoadStatus(null);
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadStatus("huy");
            Cleartext();
            LoadDataGV();
        }
    }
}
