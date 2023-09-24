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
using System.IO;

namespace School_Manegement_System
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NKJIFN3\\SQLEXPRESS;Initial Catalog=SCHOOL_MANEG_SYSTEM;Integrated Security=True");
        SqlDataAdapter da;

        private void report_Load(object sender, EventArgs e)
        {
            GetRDLCReport();


            this.reportViewer1.RefreshReport();
        }
        private void GetRDLCReport(string value = "")
        {
            string query = "";
            if (value == "")
                query = "select * from ReportSecondaryExamResultView";
            else
                query = "select * from ReportSecondaryExamResultView where Std_Name like '%" + value + "%'";
            using (da = new SqlDataAdapter(query, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "ReportSecondaryExamResultView");

                ReportDataSource source = new ReportDataSource("StudentDataSet", ds.Tables[0]);
                string reportPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\StudentReports.rdlc";
                this.reportViewer1.LocalReport.ReportPath = reportPath;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.RefreshReport();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            GetRDLCReport(txtSearch.Text);
        }
    }
}
