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
    public partial class secondaryExamform : Form
    {
        public secondaryExamform()
        {
            InitializeComponent();
        }
        MainClass obj = new MainClass();
        private void Reset()
        {

            obj.Display(dataGridView1, "select*from SecondaryExamResultView");
            obj.ClearControls(txtsecid,  txtmath, txtEnglish, txtSomali, txtphysics, txtchemistry, txtbiology, txtgeography,
                txtarabic, txtislamic, txthistory, txttotalmarks, txtaverage, txtgrade
                );
            obj.FillComboBox(ComboxExamtype, "select 0 as Exam_id,'Select one...' as Exam_Type union all select Exam_id,Exam_Type from Exam ", "Exam_id", "Exam_Type");
            obj.FillComboBox(comboxStdName, "select 0 as Std_id,'Select one...' as Std_Name union all select Std_id,Std_Name from StdRegister ", "Std_id", "Std_Name");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MainClass.query = "insert into SecondaryExamResult values('" + txtsecid.Text +
                    "','" + comboxStdName.SelectedValue.ToString() + "','" + ComboxExamtype.SelectedValue.ToString() + "'," +
                    "'" + txtmath.Text + "','" + txtEnglish.Text + "'," +
                    "'" + txtSomali.Text + "','" + txtphysics.Text + "'," +
                    "'" + txtchemistry.Text + "','" + txtbiology.Text + "'" +
                    "," + "'" + txtgeography.Text + "','" + txtarabic.Text + "'" +
                    ",'" + txtislamic.Text + "','" + txthistory.Text + "'," +
                    "'" + txttotalmarks.Text + "','" + txtaverage.Text + "'" +
                    ",'" + txtgrade.Text + "')";
            obj.ProcessData(MainClass.query, MainClass.insertAlert);
            Reset();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MainClass.query = "Update SecondaryExamResult set res_id='" + txtsecid.Text +
             "',std_id='" + comboxStdName.SelectedValue.ToString() + "',exam_id='" + ComboxExamtype.SelectedValue.ToString() +
             "',xisaab='" + txtmath.Text + "',english='" + txtEnglish.Text +
             "',somali='" + txtSomali.Text + "',physics='" + txtphysics.Text + "' ,chemistry='" +
             txtchemistry.Text + "',Biology='" + txtbiology.Text +
             "',geography='" + txtgeography.Text + "',Carabi='" + 
             txtarabic.Text + "',Tarbiya='" + txtislamic.Text + 
             "',Tariiq='" + txthistory.Text + "',total_marks='" + 
             txttotalmarks.Text + "',average='" + txtaverage.Text + 
             "',grade='" + txtgrade.Text +

             "'where res_id='" + txtsecid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.updateAlert);
            Reset();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MainClass.query = "delete from   SecondaryExamResult where res_id='" + txtsecid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.deleteAlert);
            Reset();
        }

        private void secondaryExamform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet16.SecondaryExamResultView' table. You can move, or remove it, as needed.
            this.secondaryExamResultViewTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet16.SecondaryExamResultView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet4.SecondaryExamResult' table. You can move, or remove it, as needed.
            this.secondaryExamResultTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet4.SecondaryExamResult);
            Reset();

        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj.GetDataFromDataGridView(dataGridView1, e, txtsecid, comboxStdName, ComboxExamtype, txtmath, txtEnglish, txtSomali, txtphysics, txtchemistry, txtbiology, txtgeography,txtarabic,txtislamic,txthistory,txttotalmarks,txtaverage,txtgrade);
              
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj.Display(dataGridView1, "select*from SecondaryExamResultView where std_name like '%" + txtSearch.Text + "%' or res_id like '%" + txtSearch.Text + "%'");
            }
            catch { }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboxStdName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboxExamtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            double maths, physics, english, somali, history, geography, islamic, arabic, chemistry, biology, tot, avg;
            string grade;

            maths = double.Parse(txtmath.Text);
            physics = double.Parse(txtEnglish.Text);
            english = double.Parse(txtSomali.Text);

            somali = double.Parse(txtphysics.Text);
            history = double.Parse(txtchemistry.Text);
            geography = double.Parse(txtbiology.Text);

            islamic = double.Parse(txtarabic.Text);
            arabic = double.Parse(txtislamic.Text);
            chemistry = double.Parse(txthistory.Text);
            biology = double.Parse(txthistory.Text);

            tot = maths + physics + english + somali + history + geography + islamic + arabic + chemistry + biology;

            txttotalmarks.Text = tot.ToString();

            avg = tot / 10;

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
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            txtgrade.Text = grade;
        }
    }
    }

