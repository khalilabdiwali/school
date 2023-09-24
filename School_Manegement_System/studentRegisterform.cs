using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace School_Manegement_System
{
    public partial class studentRegisterform : Form
    {
        public studentRegisterform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NKJIFN3\\SQLEXPRESS;Initial Catalog=SCHOOL_MANEG_SYSTEM;Integrated Security=True");
        string query;
        MainClass obj = new MainClass();
        private void Reset()
        {

            obj.Display(dataGridView1, "select * from StdRegister");
            obj.ClearControls(txtstdid, txtstdname, ComboxGender, txtparentName ,txtDateofBirth, txtPhone, txtAddress, txtEmail, txtDateofjoin  ,txtEmerphone);
            this.gunaCirclePictureBox1.Image = global::School_Manegement_System.Properties.Resources.download__1_;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
               /* MessageBox.Show(txtstdname.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(txtPhone.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            con.Open();
           
            
            query = "insert into StdRegister values(@Std_id,@std_name,@gender,@parent_name,@dateofbirth,@phone,@address,@email,@joineddate,@emergencyphone,@photo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Std_id", txtstdid.Text);
            cmd.Parameters.AddWithValue("@std_name", txtstdname.Text);
            cmd.Parameters.AddWithValue("@gender", ComboxGender.Text);
            cmd.Parameters.AddWithValue("@parent_name", txtparentName.Text);
            cmd.Parameters.AddWithValue("@dateofbirth", txtDateofBirth.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@joineddate", txtDateofjoin.Text);
            cmd.Parameters.AddWithValue("@emergencyphone", txtEmerphone.Text);
            cmd.Parameters.AddWithValue("@photo", @GetImageFromPBox());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved.", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            //obj.Disconnect();



            /* MainClass.query = "insert into StdRegister values('" + txtstdid.Text +
                      "','" + txtstdname.Text + "','" + ComboxGender.Text + "'," +
                      "'" + txtparentName.Text + "','" + txtDateofBirth.Text + "'," +
                      "'" + txtPhone.Text + "','" + txtAddress.Text + "'," +
                      "'" + txtEmail.Text + "','" + txtDateofjoin.Text + "'" +
                      "," + "'" + txtEmerphone.Text + "','" + @GetImageFromPBox() + "')";
             obj.ProcessData(MainClass.query, MainClass.insertAlert);*/
            Reset();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MainClass.query = "delete from   StdRegister where std_id='" + txtstdid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.deleteAlert);
            Reset();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            query = "update  StdRegister set std_name=@std_name,gender=@gender,parent_name=@parent_name,date_of_birth=@dateofbirth,phone=@phone,address=@address,email=@email,joined_date=@joineddate,Emergency_phone=@emergencyphone,photo=@photo where std_id=@Std_id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Std_id", txtstdid.Text);
            cmd.Parameters.AddWithValue("@std_name", txtstdname.Text);
            cmd.Parameters.AddWithValue("@gender", ComboxGender.Text);
            cmd.Parameters.AddWithValue("@parent_name", txtparentName.Text);
            cmd.Parameters.AddWithValue("@dateofbirth", txtDateofBirth.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@joineddate", txtDateofjoin.Text);
            cmd.Parameters.AddWithValue("@emergencyphone", txtEmerphone.Text);
            cmd.Parameters.AddWithValue("@photo", @GetImageFromPBox());
            /*MainClass.query = "Update StdRegister set std_id='" + txtstdid.Text +
              "',std_name='" + txtstdname.Text + "',gender='" + ComboxGender.Text +
              "',parent_name='" + txtparentName.Text + "',Date_of_birth='" + txtDateofBirth.Text +
              "',phone='" + txtPhone.Text + "',address='" + txtAddress.Text + "' ,email='" +
              txtEmail.Text + "',Joined_Date='" + txtDateofjoin.Text +
              "',Emergency_phone='" + txtEmerphone.Text +
             
              "'where std_id='" + txtstdid.Text + "'";*/
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result < 0)

                MessageBox.Show("Error", "Student system", MessageBoxButtons.OK, MessageBoxIcon.Error);


            else
            {
                MessageBox.Show("Updated", "Student system", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();

            //obj.ProcessData(MainClass.query, MainClass.insertAlert);
            Reset();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg |*.jpg|png|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                gunaCirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
        private byte[] GetImageFromPBox()
        {
            MemoryStream ms = new MemoryStream();
            gunaCirclePictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
            //byte[] photo = new byte[ms.Length];
            //ms.Position = 0;
            //ms.Read(photo, 0, photo.Length);
            //return photo;
        }
        private void GetImageFromDB(string _id)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-NKJIFN3\\SQLEXPRESS;Initial Catalog=SCHOOL_MANEG_SYSTEM;Integrated Security=True");

                string query = "select photo from StdRegister where id=" + _id + "";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                //SqlDataReader dr = new SqlDataReader();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])dr[0]);
                    gunaCirclePictureBox1.Image = Image.FromStream(ms);
                }
                con.Close();
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj.Display(dataGridView1, "select*from StdRegister where std_id like '%" + txtSearch.Text + "%' or std_name like '%" + txtSearch.Text + "%'");
            }
            catch { }
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            /* try
             {
                 obj.GetDataFromDataGridView(dataGridView1, e, txtstdid, txtstdname,ComboxGender,txtparentName,txtDateofBirth,txtPhone,txtAddress,txtEmail,txtDateofjoin, txtEmerphone);
                 byte[] photo = (byte[])dataGridView1.Rows[e.RowIndex].Cells[10].Value;
                 MemoryStream ms = new MemoryStream(photo);
                 gunaCirclePictureBox1.Image = Image.FromStream(ms);
             }
             catch { }*/




            try
            {
                txtstdid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtstdname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                ComboxGender.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtparentName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                txtDateofBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                txtDateofjoin.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtEmerphone.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                /* RbtnMale.Checked = dataGridView1.Rows[e.RowIndex].Cells[4].Value.Equals("Male");
                 //RbtnMale.Checked = true;
                 RbtnFemale.Checked = dataGridView1.Rows[e.RowIndex].Cells[4].Value.Equals("Female");*/
                //RbtnFemale.Checked = true;
                //RbtnFemale.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                byte[] photo = (byte[])dataGridView1.Rows[e.RowIndex].Cells[10].Value;
                MemoryStream ms = new MemoryStream(photo);
                gunaCirclePictureBox1.Image = Image.FromStream(ms);
            }
            catch { }
            


        }

        private void studentRegisterform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet9.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter3.Fill(this.sCHOOL_MANEG_SYSTEMDataSet9.StdRegister);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet8.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter2.Fill(this.sCHOOL_MANEG_SYSTEMDataSet8.StdRegister);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet6.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter1.Fill(this.sCHOOL_MANEG_SYSTEMDataSet6.StdRegister);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet1.StdRegister' table. You can move, or remove it, as needed.
            this.stdRegisterTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet1.StdRegister);

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (int.MaxValue==8)
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "phone must 8 number ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtstdname, null);
            }
        }

        private void txtstdname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtstdname.Text))
            {
                e.Cancel = true;
                txtstdname.Focus();
                errorProvider1.SetError(txtstdname, "Please enter student name ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtstdname, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtstdname.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Please enter student Email ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }
    }
}
