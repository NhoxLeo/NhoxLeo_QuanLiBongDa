using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBongDa.Form_Designs
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            FillText_MuaGiai();
            cbox_muagiai.Text = "";
        }
        private bool search = false;
        private void FillText_MuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
            cbox_muagiai.DataSource = this.giaivodichbongdaDataSet1.MUAGIAI;
            cbox_muagiai.DisplayMember = "TenMua";
            cbox_muagiai.ValueMember = "MaMua";
        }
        private void FillText_Doi(string mamua)
        {
            this.doibongTableAdapter1.FillBy_Mamua(this.giaivodichbongdaDataSet1.DOIBONG, mamua);
            cbox_chondoi.DataSource = this.giaivodichbongdaDataSet1.DOIBONG;
            cbox_chondoi.DisplayMember = "TenDoi";
            cbox_chondoi.ValueMember = "MaDoi";
        }
        private void AddItemListView(ListView lv, ListViewItem item)
        {
            lv.Items.Add(item);
        }
        private void Getinfo_Doi(string mamua)
        {
            string[] temp = new string[5];
            this.doibonG_MUAGIAITableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI, mamua);
            int i = 0;
            foreach (DataRow row in this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI.Rows)
            {
                string[] info = GetInfoSan(row["MaSan"].ToString());
                temp[0] = Convert.ToString(++i);
                temp[1] = GetTenDoi(row["MaDoi"].ToString());
                temp[2] = info[0];
                temp[3] = info[1];
                temp[4] = info[2];
                AddItemListView(listView_doi, new ListViewItem(temp));
            }
        }
        private string GetTenDoi(string madoi)
        {
            string tendoi = "";
            this.doibongTableAdapter1.FillByMadoi(this.giaivodichbongdaDataSet1.DOIBONG, madoi);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.DOIBONG.Rows)
            {
                tendoi = r["MaDoi"].ToString();
            }
            return tendoi;
        }
        private string[] GetInfoSan(string masan)
        {
            string[] info = new string[3];
            this.sanTableAdapter1.FillByMaSan(this.giaivodichbongdaDataSet1.SAN, masan);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.SAN.Rows)
            {
                info[0] = r["TenSan"].ToString();
                //info[1] = r["SucChua"].ToString();
                info[2] = r["DiaChi"].ToString();
            }
            return info;
        }
        private void Getinfo_CauThu(string madoi, string mamua)
        {
            string[] temp = new string[7];
            this.cauthU_MUAGIAITableAdapter1.FillBy_Madoi_Mamua(this.giaivodichbongdaDataSet1.CAUTHU_MUAGIAI, madoi, mamua);
            int i = 0;
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU_MUAGIAI.Rows)
            {
                string[] info = GetInfoCauThu(row["MaCauThu"].ToString());
                temp[0] = Convert.ToString(++i);
                temp[1] = info[0];
                temp[2] = info[1];
                temp[3] = info[2];
                temp[4] = info[3];
                temp[5] = info[4];
                temp[6] = row["SoLuongBanThang"].ToString();
                AddItemListView(listView_cauthu, new ListViewItem(temp));
            }
        }
        private string[] GetInfoCauThu(string macauthu)
        {
            string[] info = new string[5];
            this.cauthuTableAdapter1.FillBy_MaCauthu(this.giaivodichbongdaDataSet1.CAUTHU, macauthu);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU.Rows)
            {
                info[0] = row["TenCauThu"].ToString();
                info[1] = row["NgaySinh"].ToString();
                info[2] = GetLoaiCauThu(row["MaLoaiCauThu"].ToString());
                info[3] = row["QuocTich"].ToString();
                info[4] = row["GhiChu"].ToString();
            }
            return info;
        }
        private string GetLoaiCauThu(string maloaicauthu)
        {
            string loaict = "";
            this.loaicauthuTableAdapter1.FillBy_MaLoaiCT(this.giaivodichbongdaDataSet1.LOAICAUTHU, maloaicauthu);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.LOAICAUTHU.Rows)
            {
                loaict = row["TenLoaiCauThu"].ToString();
            }
            return loaict;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listView_doi.Items.Clear();
            Getinfo_Doi(cbox_muagiai.SelectedValue.ToString());
            FillText_Doi(cbox_muagiai.SelectedValue.ToString());
            search = true;
        }
        private void cbox_chondoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search)
            {
                listView_cauthu.Items.Clear();
                string boxchondoi = cbox_chondoi.SelectedValue.ToString();
                string boxmuagiai = cbox_muagiai.SelectedValue.ToString();
                Getinfo_CauThu(boxchondoi,boxmuagiai );
            }
        }
        private void txt_cauthu_MouseClick(object sender, MouseEventArgs e)
        {
            txt_cauthu.Text = "";
        }
        private void button_searchct_MouseClick(object sender, MouseEventArgs e)
        {
            this.cauthuTableAdapter1.Fill(this.giaivodichbongdaDataSet1.CAUTHU);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU.Rows)
            {
                if (!Search(row["TenCauThu"].ToString(), txt_cauthu.Text.Trim()))
                {
                    this.giaivodichbongdaDataSet1.CAUTHU.Rows.Remove(row);
                }
            }
            string[] temp = new string[5];
            int i = 0;
            foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU.Rows)
            {
                string[] info = GetInfoCauThu(row["MaCauThu"].ToString());
                temp[0] = Convert.ToString(++i);
                temp[1] = info[0];
                temp[2] = info[1];
                temp[3] = info[2];
                temp[4] = info[3];
                temp[5] = info[4];
                AddItemListView(listView_cauthu, new ListViewItem(temp));
            }
        }
        private bool Search(string text, string textsearch)
        {
            if (textsearch != "")
            {
                if (text.ToLower().Contains(textsearch.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
