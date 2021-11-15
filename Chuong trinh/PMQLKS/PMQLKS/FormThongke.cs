using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace PMQLKS
{
    public partial class FormThongke : Form
    {
        public FormThongke()
        {
            InitializeComponent();
        }

        private void FormThongke_Load(object sender, EventArgs e)
        {

            this.rpvDoanhthu.RefreshReport();
        }

        private void btnTaobaocao_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.HotelManagerNew1ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Doanhthu1";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@tungay", dtTungay.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@denngay", dtDenngay.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            rpvDoanhthu.ProcessingMode = ProcessingMode.Local;
            rpvDoanhthu.LocalReport.ReportPath = "RptDoanhthu1.rdlc";
            if(ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DsDoanhthu1";
                rds.Value = ds.Tables[0];
                rpvDoanhthu.LocalReport.DataSources.Clear();
                rpvDoanhthu.LocalReport.DataSources.Add(rds);
                rpvDoanhthu.RefreshReport();
            }
        }
    }
}
