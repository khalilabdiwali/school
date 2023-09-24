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
    public partial class primaryExamform : Form
    {
        public primaryExamform()
        {
            InitializeComponent();
        }
        MainClass obj = new MainClass();
        private void Reset()
        {

            obj.Display(dataGridView1, "select*from PrimaryExamResultView");
            obj.ClearControls(txtpid,   txtmath, txtEnglish, txtSomali , txtscience,txtislamic,txttechnology, 
                txtarabic, txtislamic, txttotalmarks, txtaverage, txtgrade
                );
            obj.FillComboBox(ComboxExamtype, "select 0 as Exam_id,'Select one...' as Exam_Type union all select Exam_id,Exam_Type from Exam", "Exam_id", "Exam_Type");
            obj.FillComboBox(comboxStdName, "select 0 as Std_id,'Select one...' as Std_Name union all select Std_id,Std_Name from StdRegister", "Std_id", "Std_Name");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ComboxExamtype.SelectedIndex != 0)
            {
                if ((ComboxExamtype.Text != "") && (txtpid.Text != ""))
                {

                    MainClass.query = "insert into PrimaryExamResult values('" + txtpid.Text +
                    "','" + comboxStdName.SelectedValue.ToString() + "','" + ComboxExamtype.SelectedValue.ToString() + "'," +
                    "'" + txtmath.Text + "','" + txtEnglish.Text + "'," +
                    "'" + txtSomali.Text + "','" + txtscience.Text + "'," +
                    "'" + txtislamic.Text + "','" + txttechnology.Text + "'" +
                    "," + "'" + txtarabic.Text + "'," +
                    "'" + txttotalmarks.Text + "','" + txtaverage.Text + "'" +
                    ",'" + txtgrade.Text + "')";
                    obj.ProcessData(MainClass.query, MainClass.insertAlert);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Please fill the blank spaces.", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select Exam Type  .", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




           /* MainClass.query = "insert into PrimaryExamResult values('" + txtpid.Text +
                   "','" + txtstid.Text + "','" + ComboxExamtype.SelectedValue.ToString() + "'," +
                   "'" + txtmath.Text + "','" + txtEnglish.Text + "'," +
                   "'" + txtSomali.Text + "','" + txtscience.Text + "'," +
                   "'" + txtislamic.Text + "','" + txttechnology.Text + "'" +
                   "," + "'" + txtarabic.Text + "'," +
                   "'" + txttotalmarks.Text + "','" + txtaverage.Text + "'" +
                   ",'" + txtgrade.Text + "')";
            obj.ProcessData(MainClass.query, MainClass.insertAlert);
            Reset();*/
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MainClass.query = "delete from   PrimaryExamResult where pryres_id='" + txtpid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.deleteAlert);
            Reset();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MainClass.query = "Update PrimaryExamResult set pryres_id='" + txtpid.Text +
             "',std_id='" + comboxStdName.SelectedValue.ToString() + "',exam_id='" + ComboxExamtype.SelectedValue.ToString() +
             "',xisaab='" + txtmath.Text + "',english='" + txtEnglish.Text +
             "',somali='" + txtSomali.Text + "',saynis='" +
             txtscience.Text + "',Tarbiya='" + txtislamic.Text +
             "',tegnology='" + txttechnology.Text + "',Carabi='" +
             txtarabic.Text + "',total_marks='" +
             txttotalmarks.Text + "',average='" + txtaverage.Text +
             "',grade='" + txtgrade.Text +

             "'where pryres_id='" + txtpid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.updateAlert);
            Reset();
        }

        private void primaryExamform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet15.PrimaryExamResultView' table. You can move, or remove it, as needed.
            this.primaryExamResultViewTableAdapter1.Fill(this.sCHOOL_MANEG_SYSTEMDataSet15.PrimaryExamResultView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet14.PrimaryExamResultView' table. You can move, or remove it, as needed.
            this.primaryExamResultViewTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet14.PrimaryExamResultView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet13.PrimaryExamResultView' table. You can move, or remove it, as needed.
            //this.primaryExamResultViewTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet13.PrimaryExamResultView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet5.PrimaryExamResult' table. You can move, or remove it, as needed.
            this.primaryExamResultTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet5.PrimaryExamResult);
            Reset();

        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj.GetDataFromDataGridView(dataGridView1, e, txtpid, comboxStdName, ComboxExamtype, txtmath, txtEnglish, txtSomali, txtscience, txtislamic, txttechnology, txtarabic,  txttotalmarks, txtaverage, txtgrade);

            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj.Display(dataGridView1, "select*from PrimaryExamResultView where pryres_id like '%" + txtSearch.Text + "%' or std_name like '%" + txtSearch.Text + "%'");
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmath_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            double maths, technology, science,english, somali , islamic, arabic, tot, avg;
            string grade;

            maths = double.Parse(txtmath.Text);
            english = double.Parse(txtEnglish.Text);
            somali = double.Parse(txtSomali.Text);
            science = double.Parse(txtscience.Text);
            islamic = double.Parse(txtislamic.Text);
            technology = double.Parse(txttechnology.Text);
            arabic = double.Parse(txtislamic.Text);
            

            tot = maths + science + english + somali + islamic + arabic + technology ;

            txttotalmarks.Text = tot.ToString();

            avg = tot / 7;

            txtaverage.Text = avg.ToString();
            if (avg >= 95)
            {
                grade = "A";
            }
            else if (avg >= 85)
            {
                grade = "B";
            }
            else if (avg >= 75)
            {
                grade = "C";
            }
            else if (avg >= 45)
            {
                grade = "S";
            }
            else
            {
                grade = "F";
            }

            txtgrade.Text = grade;
        }
    }
}
