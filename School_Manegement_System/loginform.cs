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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        MainClass obj= new MainClass();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("please fill the blank spaces", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainClass.query = "select*from userTable where Username='" + txtUsername.Text + "' and Password ='" + txtpassword.Text + "' ";
                using (MainClass.cmd = new SqlCommand(MainClass.query, MainClass.con))
                {
                    obj.Connect();
                    SqlDataReader dr = MainClass.cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dashboardfrom dashboardfrom = new dashboardfrom();
                        dashboardfrom.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("invalid username or password", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    obj.Disconnect();
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
            btnhide.Visible = true;
            btnshow.Visible = false;
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '*';
            }
            btnshow.Visible = true;
            btnhide.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
