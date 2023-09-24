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

namespace School_Manegement_System
{
    public partial class homeform : Form
    {
        public homeform()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-NKJIFN3\SQLEXPRESS;Initial Catalog=SCHOOL_MANEG_SYSTEM;Integrated Security=True";

        //MainClass obj= new MainClass();
        private void homeform_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from UserTable";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblusers.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentpaint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from StdRegister";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblstudent.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void Exampaint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from Exam";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblexam.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void paintlblusername(object sender, PaintEventArgs e)
        {
           
        }

        private void label12_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from Level_Register";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lbllevelRegester.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void lblprimary_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from PrimaryExamResult";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblprimary.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void lblsecondary_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from SecondaryExamResult";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblsecondary.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void label18_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "select count(*) from SchoolLevel";


            try
            {
                con.Open();
                //gunaLabel3.ForeColor = Color.Green;
                //gunaLabel3.Text = "Database Sucessfully Connected!!";

                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblschhollevel.Text = " " + rows_count.ToString();

            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
