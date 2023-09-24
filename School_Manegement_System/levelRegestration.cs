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
    public partial class levelRegestration : Form
    {
        public levelRegestration()
        {
            InitializeComponent();
        }
        MainClass obj = new MainClass();
      


        private void Reset()
        {
            obj.Display(dataGridView1, "select * from LevelRegesterView");
            //select*From LevelRegesterView
            obj.ClearControls(txtlid,txtClass,txtacedemicyear, txtSearch);
            //dropdown code 
            obj.FillComboBox(comboxschoolevel, "select 0 as s_level_id,'Select one...' as level_sch union all select * from SchoolLevel", "S_LEVEL_ID", "Level_Sch");
            obj.FillComboBox(comboxStdName, "select 0 as Std_id,'Select one...' as Std_Name union all select Std_id,Std_Name from StdRegister", "Std_id", "Std_Name");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (comboxschoolevel.SelectedIndex != 0)
            {
                if ((txtlid.Text != "") && (txtClass.Text != ""))
                {

                    MainClass.query = "insert into Level_Register values('" + txtlid.Text +
                            "','" + txtClass.Text + "','" + comboxschoolevel.SelectedValue.ToString() + "'," +
                            "'" + txtacedemicyear.Text + "','" + comboxStdName.SelectedValue.ToString() + "')";
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
                MessageBox.Show("Please select School Level  .", MainClass.Apptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MainClass.query = "delete from   Level_Register where level_id='" + txtlid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.deleteAlert);
            Reset();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MainClass.query = "Update Level_Register set level_id='" + 
                txtlid.Text + "',class='" + txtClass.Text +
           "',s_level_id='" + comboxschoolevel.SelectedValue.ToString() + "',academic_year='" + txtacedemicyear.Text +
           "',std_id='" + comboxStdName.SelectedValue.ToString() +
           "'where level_id='" + txtlid.Text + "'";
            obj.ProcessData(MainClass.query, MainClass.insertAlert);
            Reset();
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obj.GetDataFromDataGridView(dataGridView1, e, txtlid, comboxStdName, txtClass, comboxschoolevel, txtacedemicyear);

            }
            catch { }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                obj.Display(dataGridView1, "select*from LevelRegesterView where level_id like '%" + txtSearch.Text + "%' or Std_Name like '%" + txtSearch.Text + "%'");
            }
            catch { }
        }

        private void levelRegestration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet12.LevelRegesterView' table. You can move, or remove it, as needed.
            this.levelRegesterViewTableAdapter2.Fill(this.sCHOOL_MANEG_SYSTEMDataSet12.LevelRegesterView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet11.LevelRegesterView' table. You can move, or remove it, as needed.
            this.levelRegesterViewTableAdapter1.Fill(this.sCHOOL_MANEG_SYSTEMDataSet11.LevelRegesterView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet10.LevelRegesterView' table. You can move, or remove it, as needed.
            this.levelRegesterViewTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet10.LevelRegesterView);
            // TODO: This line of code loads data into the 'sCHOOL_MANEG_SYSTEMDataSet2.Level_Register' table. You can move, or remove it, as needed.
            this.level_RegisterTableAdapter.Fill(this.sCHOOL_MANEG_SYSTEMDataSet2.Level_Register);
            Reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtacedemicyear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
