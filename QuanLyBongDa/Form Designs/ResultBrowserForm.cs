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
    public partial class ResultBrowserForm : Form
    {
        public ResultBrowserForm()
        {
            InitializeComponent();
            LoadTreeView();
        }
        private void LoadTreeView()
        {
            this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.MUAGIAI.Rows)
            {
                TreeNode muagiaiNode = new TreeNode();
                muagiaiNode.Text = row["TenMua"].ToString();
                muagiaiNode.Tag = row["MaMua"].ToString();
                muagiaiNode.Name = "muagiai";
                muagiaiNode.Nodes.Add("*");
                treeView.Nodes.Add(muagiaiNode);
            }
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
        private void LoadListView(string matrandau)
        {
            this.cauthughibanTableAdapter1.FillByMaTranDau(this.giaivodichbongdaDataSet1.CAUTHUGHIBAN, matrandau);
            int i = 0;
            foreach (DataRow dataRow in this.giaivodichbongdaDataSet1.CAUTHUGHIBAN.Rows)
            {
                string tencauthu = LayTenCauThu(dataRow["MaCauThu"].ToString());
                string loaibanthang = LayLoaiBanThang(dataRow["MaLoaiBanThang"].ToString());
                string thoidiem = dataRow["ThoiDiem"].ToString();
                listView.Items.Add(createListViewItem(++i, tencauthu, loaibanthang, thoidiem));
            }
        }
        private ListViewItem createListViewItem(int i, string tencauthu, string loaibanthang, string thoidiem)
        {
            string[] item = new string[4];
            item[0] = i.ToString();
            item[1] = tencauthu;
            item[2] = loaibanthang;
            item[3] = thoidiem;
            return new ListViewItem(item);
        }
        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "muagiai")
            {
                e.Node.Nodes.Clear();
                this.luotTableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.LUOT, e.Node.Tag.ToString());
                foreach (DataRow dataRow in this.giaivodichbongdaDataSet1.LUOT.Rows)
                {
                    TreeNode vongNode = new TreeNode();
                    vongNode.Text = dataRow["TenLuot"].ToString();
                    vongNode.Tag = dataRow["MaLuot"].ToString();
                    vongNode.Name = "luot";
                    vongNode.Nodes.Add("*");
                    e.Node.Nodes.Add(vongNode);
                }
            }
            if (e.Node.Name == "luot")
            {
                e.Node.Nodes.Clear();
                string _mamua = e.Node.Parent.Tag.ToString();
                string _maluot = e.Node.Tag.ToString();
                this.trandauTableAdapter1.FillBy_MaMua_MaVong(this.giaivodichbongdaDataSet1.TRANDAU,_maluot,_mamua);
                foreach (DataRow dataRow in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
                {
                    TreeNode doiNode = new TreeNode();
                    string tendoi1 = LayTenDoi(dataRow["MaDoi1"].ToString());
                    string tendoi2 = LayTenDoi(dataRow["MaDoi2"].ToString());
                    doiNode.Text = tendoi1 + " - " + tendoi2;
                    doiNode.Tag = dataRow["MaTranDau"].ToString();
                    doiNode.Name = "doi";
                    e.Node.Nodes.Add(doiNode);
                }
            }
        }
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "doi")
            {
                this.trandauTableAdapter1.FillByMaTranDau(this.giaivodichbongdaDataSet1.TRANDAU, e.Node.Tag.ToString());
                foreach (DataRow dataRow in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
                {
                    txt_doi1.Text = LayTenDoi(dataRow["MaDoi1"].ToString());
                    txt_doi2.Text = LayTenDoi(dataRow["MaDoi2"].ToString());
                    txt_san.Text = LayTenSan(dataRow["MaSan"].ToString());
                    txt_sobanthangdoi1.Text = dataRow["SoBanThangDoi1"].ToString();
                    txt_sobanthangdoi2.Text = dataRow["SoBanThangDoi2"].ToString();
                    dateTime.Value = Convert.ToDateTime(dataRow["NgayGio"].ToString());
                    LoadListView(e.Node.Tag.ToString());
                }
            }
        }
    }
}
