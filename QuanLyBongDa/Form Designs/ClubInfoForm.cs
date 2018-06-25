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
    public partial class ClubInfoForm : Form
    {
        public ClubInfoForm()
        {
            InitializeComponent();
            LoadTreeView();
        }
        public static string masan = "";
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
                treeView1.Nodes.Add(muagiaiNode);
            }
        }
        private string[] Returninfo(string macauthu, int sothutu)
        {
            string[] item = new string[6];
            this.cauthuTableAdapter1.FillBy_MaCauthu(this.giaivodichbongdaDataSet1.CAUTHU, macauthu);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.CAUTHU.Rows)
            {
                item[0] = sothutu.ToString();
                item[1] = r["TenCauThu"].ToString();
                item[2] = r["NgaySinh"].ToString();
                item[3] = "loai cau thu";
                item[4] = r["QuocTich"].ToString();
                item[5] = r["GhiChu"].ToString();
            }
            return item;
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "muagiai")
            {
                //do: nothing
            }
            else if (e.Node.Name == "doi")
            {
                listviewPlayer.Items.Clear();
                label_tendoi.Text = e.Node.Text;
                this.doibonG_MUAGIAITableAdapter1.FillByMaDoiMaMua(this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI, e.Node.Parent.Tag.ToString(), e.Node.Tag.ToString());
                foreach (DataRow row in this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI.Rows)
                {
                    masan = row["MaSan"].ToString();
                }
                this.sanTableAdapter1.FillByMaSan(this.giaivodichbongdaDataSet1.SAN, masan);
                foreach (DataRow r in this.giaivodichbongdaDataSet1.SAN.Rows)
                {
                    txt_san.Text = r["TenSan"].ToString();
                }
                List<string> listmacauthu = new List<string>();
                this.cauthU_MUAGIAITableAdapter1.FillBy_Madoi_Mamua(this.giaivodichbongdaDataSet1.CAUTHU_MUAGIAI, e.Node.Tag.ToString(), e.Node.Parent.Tag.ToString());
                foreach (DataRow row in this.giaivodichbongdaDataSet1.CAUTHU_MUAGIAI.Rows)
                {
                    listmacauthu.Add(row["MaCauThu"].ToString());
                }
                int i = 0;
                if (listmacauthu.Count != 0)
                {
                    foreach (string macauthu in listmacauthu)
                    {
                        ListViewItem item = new ListViewItem(Returninfo(macauthu, ++i));
                        listviewPlayer.Items.Add(item);
                    }
                }
            }
            else if (e.Node.Name == "cauthu")
            {

            }
        }
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            List<string> listmadoi = new List<string>();
            if (e.Node.Name == "muagiai")
            {
                e.Node.Nodes.Clear();
                this.doibonG_MUAGIAITableAdapter1.FillByMaMua(this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI, e.Node.Tag.ToString());
                foreach (DataRow row in this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI.Rows)
                {
                    listmadoi.Add(row["MaDoi"].ToString());
                }
                foreach (string madoi in listmadoi)
                {
                    this.doibongTableAdapter1.FillByMadoi(this.giaivodichbongdaDataSet1.DOIBONG, madoi);
                    foreach (DataRow r in this.giaivodichbongdaDataSet1.DOIBONG.Rows)
                    {
                        TreeNode doiNode = new TreeNode();
                        doiNode.Text = r["TenDoi"].ToString();
                        doiNode.Tag = madoi;
                        doiNode.Name = "doi";
                        e.Node.Nodes.Add(doiNode);
                    }
                }
            }
        }
        private void link_thongtinsan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (masan != "")
            //{
            //    FrmThongTinSan frm = new FrmThongTinSan();
            //    frm.ShowDialog();
            //}
        }
    }
}
