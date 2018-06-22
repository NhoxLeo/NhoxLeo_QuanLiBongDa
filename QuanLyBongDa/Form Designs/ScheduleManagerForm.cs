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

        private DateTime thoigian;
        private string masan;

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
        private void LoadDateGV()
        {
            this.trandauTableAdapter1.Fill(this.giaivodichbongdaDataSet1.TRANDAU);
            DataTable table = newTable();
            foreach (DataRow row in this.giaivodichbongdaDataSet1.TRANDAU.Rows)
            {
                matrandau = row["MaTranDau"].ToString();
                madoi1 = row["MaDoi1"].ToString();
                madoi2 = row["MaDoi2"].ToString();
                thoigian = Convert.ToDateTime(row["NgayGioThucTe"].ToString());
                masan = row["MaSan"].ToString();
                //mavongdau = row["MaVong"].ToString();
                table.Rows.Add(newRow(matrandau, madoi1, madoi2, thoigian, masan, mavongdau));

            }
            dataGridView1.DataSource = table;
            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = true;
            }
        }
        private DataTable newTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaTranDau", typeof(string));
            table.Columns.Add("MaDoi1", typeof(string));
            table.Columns.Add("MaDoi2", typeof(string));
            table.Columns.Add("NgayGioThucTe", typeof(string));
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
            row[5] = LayTenVongDau(mavong);
            //row[6] = LayTenMua(mavong);
            return row;
        }
        private string LayTenDoi(string madoi)
        {
            string tendoi = "";
            this.doibongTableAdapter1.FillByMadoi(this.giaivodichbongdaDataSet1.DOIBONG, madoi);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.DOIBONG.Rows)
            {
                tendoi = r["TENDOI"].ToString();
            }
            return tendoi;
        }
        private string LayTenSan(string masan)
        {
            string tensan = "";
            this.sanTableAdapter1.FillByMaSan(this.giaivodichbongdaDataSet1.SAN, masan);
            foreach (DataRow r in this.giaivodichbongdaDataSet1.SAN.Rows)
            {
                tensan = r["TENSAN"].ToString();
            }
            return tensan;
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
    }
}
