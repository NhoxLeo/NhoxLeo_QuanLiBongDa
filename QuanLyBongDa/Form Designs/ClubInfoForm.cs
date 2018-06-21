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
        }

        public static string masan = "";
        private void LoadTreeView()
        {
            
            this.muagiaiTableAdapter1.Fill(this.giaivodichbongdaDataSet1.MUAGIAI);
            foreach (DataRow row in this.giaivodichbongdaDataSet1.MUAGIAI.Rows)
            {
                TreeNode muagiaiNode = new TreeNode();
                muagiaiNode.Text = row["TENMUA"].ToString();
                muagiaiNode.Tag = row["MAMUA"].ToString();
                muagiaiNode.Name = "muagiai";
                muagiaiNode.Nodes.Add("*");
                treeView1.Nodes.Add(muagiaiNode);
            }
        }
        //private void treeView_info_AfterExpand(object sender, TreeViewEventArgs e)
        //{
        //    List<string> listmadoi = new List<string>();
        //    if (e.Node.Name == "muagiai")
        //    {
                
        //        e.Node.Nodes.Clear();
        //        this.doibonG_MUAGIAITableAdapter1.Fill(this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI, e.Node.Tag.ToString());
        //        foreach (DataRow row in this.giaivodichbongdaDataSet1.DOIBONG_MUAGIAI.Rows)
        //        {
        //            listmadoi.Add(row["MADOI"].ToString());
        //        }
        //        foreach (string madoi in listmadoi)
        //        {
        //            this.doibongTableAdapter1.Fill(this.giaivodichbongdaDataSet1.DOIBONG, madoi);
        //            foreach (DataRow r in this.giaivodichbongdaDataSet1.DOIBONG.Rows)
        //            {
        //                TreeNode doiNode = new TreeNode();
        //                doiNode.Text = r["TENDOI"].ToString();
        //                doiNode.Tag = madoi;
        //                doiNode.Name = "doi";
        //                e.Node.Nodes.Add(doiNode);
        //            }
        //        }
        //    }

        //}
        //private void treeView_info_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    if (e.Node.Name == "muagiai")
        //    {
        //        //do: nothing
        //    }
        //    else if (e.Node.Name == "doi")
        //    {
        //        listView_Player.Items.Clear();

        //        label_tendoi.Text = e.Node.Text;

        //        this.doibonG_MUAGIAITableAdapter.FillByMaDoiMaMua(this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI, e.Node.Tag.ToString(), e.Node.Parent.Tag.ToString());
        //        foreach (DataRow row in this.quanLyGiaiVoDichDataSet.DOIBONG_MUAGIAI.Rows)
        //        {
        //            masan = row["MASANNHA"].ToString();
        //        }

        //        this.sanTableAdapter.FillByMaSan(this.quanLyGiaiVoDichDataSet.SAN, masan);
        //        foreach (DataRow r in this.quanLyGiaiVoDichDataSet.SAN.Rows)
        //        {
        //            txt_san.Text = r["TENSAN"].ToString();
        //        }

        //        //tai day con 1 doan code de lay thong tin chi tiet cua san


        //        List<string> listmacauthu = new List<string>();

        //        this.doibonG_CAUTHUTableAdapter.FillBy_Madoi_Mamua(this.quanLyGiaiVoDichDataSet.DOIBONG_CAUTHU, e.Node.Tag.ToString(), e.Node.Parent.Tag.ToString());
        //        foreach (DataRow row in this.quanLyGiaiVoDichDataSet.DOIBONG_CAUTHU.Rows)
        //        {
        //            listmacauthu.Add(row["MACT"].ToString());
        //        }

        //        int i = 0;
        //        if (listmacauthu.Count != 0)
        //        {
        //            foreach (string macauthu in listmacauthu)
        //            {
        //                ListViewItem item = new ListViewItem(Returninfo(macauthu, ++i));
        //                listView_Player.Items.Add(item);
        //            }
        //        }

        //    }
        //    else if (e.Node.Name == "cauthu")
        //    {

        //    }
        //}
        //private string[] Returninfo(string macauthu, int sothutu)
        //{
        //    string[] item = new string[6];
        //    this.cauthuTableAdapter.FillBy_MaCauthu(this.quanLyGiaiVoDichDataSet.CAUTHU, macauthu);
        //    foreach (DataRow r in this.quanLyGiaiVoDichDataSet.CAUTHU.Rows)
        //    {
        //        item[0] = sothutu.ToString();
        //        item[1] = r["TENCT"].ToString();
        //        item[2] = r["NGAYSINH"].ToString();
        //        item[3] = "loai cau thu";
        //        item[4] = r["QUOCTICH"].ToString();
        //        item[5] = r["GHICHU"].ToString();
        //    }

        //    return item;
        //}
        //private void link_thongtinsan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    if (masan != "")
        //    {
        //        FrmThongTinSan frm = new FrmThongTinSan();
        //        frm.ShowDialog();

        //    }

        //}
    }
}
