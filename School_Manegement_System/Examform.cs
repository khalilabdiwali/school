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
    public partial class Examform : Form
    {
        public Examform()
        {
            InitializeComponent();
        }
        MainClass obj= new MainClass();
        private void Reset()
        {

            obj.Display(dataGridView1, "select * from Exam");
            obj.ClearControls(txtenddate, txtexamtype, txtstartdate, txtenddate, txtlevelid);

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            MainClass.query = "insert into Exam values('" + txtexamid.Text +
                    "','" + txtexamtype.Text + "','" + txtstartdate.Text + "'," +
                    "'" + txtenddate.Text + "','" + txtlevelid.Text + "')";
            obj.ProcessData(MainClass.query, MainClass.insertAlert);
            Reset();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            MainClass.query = "Update Exam set exam_id='" + txtexamid.Text +
            "',exam_type='" + txtexamtype.Text + "',start_date='" + txtstartdate.Text +
            "',end_date='" + txtenddate.Text + "',level_id='" + txtlevelid.Text +
            "'where Exam_id='" + txtexamid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.updateAlert);
            Reset();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj.Display(dataGridView1, "select*from Exam where Exam_id like '%" + txtSearch.Text + "%' or exam_type like '%" + txtSearch.Text + "%'");
            }
            catch { }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MainClass.query = "delete from   Exam where Exam_id='" + txtexamid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.deleteAlert);
            Reset();
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj.GetDataFromDataGridView(dataGridView1, e, txtexamid, txtexamtype, txtstartdate, txtenddate, txtlevelid);
               
            }
            catch { }
        }

        private void Examform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet3.Exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet3.Exam);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
