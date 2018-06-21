using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;


namespace QuanLyBongDa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string sqlConnectionString = @"Data Source=DESKTOP-LTNSJNF\SQLEXPRESS;Initial Catalog=GIAIVODICHBONGDA;Integrated Security=True";
            //FileInfo file = new FileInfo("D:\\UIT\\UIT-HK4\\Nhập Môn Công Nghệ Phần Mềm\\MyCourse_QuanLyBongDa\\Database\\script.sql");
            //string script = file.OpenText().ReadToEnd();
            //SqlConnection conn = new SqlConnection(sqlConnectionString);
            //Server server = new Server(new ServerConnection(conn));
            ////server.ConnectionContext.ExecuteNonQuery(script);






            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
