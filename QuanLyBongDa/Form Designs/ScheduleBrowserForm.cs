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
    public partial class ScheduleBrowserForm : Form
    {
        public ScheduleBrowserForm()
        {
            InitializeComponent();
            Filltext_MuaGiai();
            LoadListView();
        }
        #region fill text
        private void Filltext_MuaGiai()
        {
            this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
            DataTable tb = this.giaivodichbongdaDataSet1.MUAGIAI.Copy();
            seasonCombobox.DataSource = tb;
            seasonCombobox.DisplayMember = "TenMua";
            seasonCombobox.ValueMember = "MaMua";
        }
        #endregion
        #region Load listview
        private void AddItemListView(ListView lv, ListViewItem item)
        {
            lv.Items.Add(item);
        }
        private void LoadListView()
        {
            string matrandau, madoi1, madoi2, mavongdau, masan;
            DateTime thoigian;
            listView1.Items.Clear();
            this.trandauTableAdapter1.Fill(this.giaivodichbongdaDataSet1.TRANDAU);
            int i = 0;
            foreach (DataRow row in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
            {
                matrandau = row["MaTranDau"].ToString();
                madoi1 = row["MaDoi1"].ToString();
                madoi2 = row["MaDoi2"].ToString();
                thoigian = Convert.ToDateTime(row["NgayGio"].ToString());
                masan = row["MaSan"].ToString();
                mavongdau = row["MaLuot"].ToString();
                AddItemListView(listView1, newItemListView(Convert.ToString(++i), madoi1, madoi2, thoigian, masan, mavongdau));
            }
        }
        private ListViewItem newItemListView(string matd, string madoi1, string madoi2, DateTime ngaygio, string masan, string mavong)
        {
            string[] item = new string[7];
            ListViewItem listitem;
            item[0] = matd;
            item[1] = LayTenDoi(madoi1);
            item[2] = LayTenDoi(madoi2);
            item[3] = ngaygio.ToString("HH:mm MM/dd/yyyy");
            item[4] = LayTenSan(masan);
            item[5] = LayTenLuot(mavong);
            item[6] = LayTenMua(mavong);
            listitem = new ListViewItem(item);
            listitem.Tag = item[1] + " - " + item[2];
            listitem.Name = item[6] + " - " + item[5];
            return listitem;
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
        private string LayTenLuot(string mavong)
        {
            string tenluot = "";
            this.luotTableAdapter1.FillByMaVong(this.giaivodichbongdaDataSet1.LUOT, mavong);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.LUOT.Rows)
            {
                tenluot = r["TenLuot"].ToString();
            }
            return tenluot;
        }
        private string LayTenMua(string mavong)
        {
            string tenmua = "";
            string mamua = "";
            this.luotTableAdapter1.FillByMaVong(this.giaivodichbongdaDataSet1.LUOT, mavong);
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
        #endregion
        private void Search_MuaGiai(string textsearch)
        {
            if (textsearch != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (Convert.ToString(item.SubItems[6]).ToLower().Contains(textsearch.ToLower()))
                    {

                        item.Selected = true;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }

                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
        }
        private void Search_Vong(string textsearch)
        {
            if (textsearch != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (Convert.ToString(item.SubItems[5]).ToLower().Contains(textsearch.ToLower()))
                    {

                        item.Selected = true;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }

                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
        }
        private void seasonCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seasonCombobox.SelectedValue != null)
            {
                try
                {
                    int kq = int.Parse(seasonCombobox.SelectedValue.ToString().Substring(2)) / 1;
                    LoadListView();
                    Search_MuaGiai(seasonCombobox.Text.Trim());
                }
                catch (Exception)
                {

                }

            }
        }
    }
}
