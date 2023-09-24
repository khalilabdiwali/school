using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace School_Manegement_System
{
    internal class MainClass
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-NKJIFN3\\SQLEXPRESS;Initial Catalog=SCHOOL_MANEG_SYSTEM;Integrated Security=True");
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static string query;
        public static string insertAlert = "Data has been savd";
        public static string updateAlert = "Data has been Updated";
        public static string deleteAlert = "Data has been Deleted";
        public static string Apptitle = "student  ";

        public void Connect()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }
        public void Disconnect()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        // method for insert delte update
        public void ProcessData(string sqlSt, string alert)
        {
            using (cmd = new SqlCommand(sqlSt, con))
            {
                Connect();//open connection
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(alert, Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Something went wrong. Please trty again.", Apptitle, MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Disconnect();//close connection
            }
        }
       

        //display
        public void Display(DataGridView dgv, string sqlSt)
        {
            using (da = new SqlDataAdapter(sqlSt, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "table");
                dgv.DataSource = ds.Tables["table"];
            }
        }

        //clear controls method
        public void ClearControls(params Control[] ctrl)
        {
            for (int i = 0; i < ctrl.Length; i++)
            {
                ctrl[i].Text = String.Empty;
            }
            ctrl[0].Focus();
        }
        public void GetDataFromDataGridView(DataGridView dgv, DataGridViewCellEventArgs e, params Control[] ctrl)
        {
            try
            {
                for (int i = 0; i < ctrl.Length; i++)
                {
                    ctrl[i].Text = dgv.Rows[e.RowIndex].Cells[i].Value.ToString();
                }
            }
            catch { }
        }
        public void FillComboBox(ComboBox cBox, string sqlSt, string colValueMember, string colDisplayMember)
        {
            using (da = new SqlDataAdapter(sqlSt, con))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "table");
                cBox.DataSource = ds.Tables["table"];
                cBox.ValueMember = colValueMember;
                cBox.DisplayMember = colDisplayMember;
            }
        }
    }
}
