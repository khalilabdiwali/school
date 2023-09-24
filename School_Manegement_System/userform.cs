using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Manegement_System
{
    public partial class userform : Form
    {
        public userform()
        {
            InitializeComponent();
        }
        MainClass obj = new MainClass();
        private void Reset()
        {
            usertycombox.SelectedIndex = 0;
            obj.Display(dataGridView1, "select * from userTable");
            obj.ClearControls(txtuserid, txtusername, txtpassword, txtconfirm,usertycombox);
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (usertycombox.SelectedIndex != 0)
            {
                if (txtpassword.Text == txtconfirm.Text)
                {
                    MainClass.query = "insert into userTable values('" + txtuserid.Text +
                   "','" + txtusername.Text + "','" + txtpassword.Text + "','" + usertycombox.Text + "')";
                    obj.ProcessData(MainClass.query, MainClass.insertAlert);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Password mismatch.", MainClass.Apptitle, MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    txtconfirm.Text = String.Empty;
                    txtconfirm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select item.", MainClass.Apptitle, MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                usertycombox.Focus();
            }





























            /*if (usertycombox.SelectedIndex != 0)
            {
                if (txtpassword.Text == txtconfirm.Text)
                {
                    MainClass.query = "insert into userTable values('" + txtuserid.Text +
                   "','" + txtusername.Text + "','" + txtpassword.Text + "','" + usertycombox.Text + "')";
                    obj.ProcessData(MainClass.query, MainClass.insertAlert);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Password mismatch.", MainClass.Apptitle, MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    txtconfirm.Text = String.Empty;
                    txtconfirm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select item.", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                usertycombox.Focus();
            }*/
        }

        private void userform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet.UserTable);
            Reset();
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            //txtuserid.Text = dataGridView1.Rows.[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                obj.GetDataFromDataGridView(dataGridView1, e, txtuserid, txtusername, txtpassword, txtconfirm,usertycombox);
                txtconfirm.Text = txtpassword.Text;

            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            MainClass.query = "Update userTable set User_id='" + txtuserid.Text +
           "',UserName='" + txtusername.Text + "',Password='" + txtpassword.Text + "',UserType='" + usertycombox.Text + "' where User_id='" + txtuserid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.updateAlert);
            Reset();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            MainClass.query = "delete from   userTable where User_id='" + txtuserid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.deleteAlert);
            Reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj.Display(dataGridView1, "select*from userTable where User_id like '%" + txtSearch.Text + "%' or UserName like '%" + txtSearch.Text + "%'");
            }
            catch { }
        }
    }
}
