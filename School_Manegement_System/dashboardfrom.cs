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
    public partial class dashboardfrom : Form
    {
        public dashboardfrom()
        {
            InitializeComponent();
        }

        //bool sidebarExpand;
        private void dashboardfrom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            /*if (sidebarExpand)
            {
                sidebar.Width -= 100;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 100;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }*/
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            //sidebarTimer.Start();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            Openform(new homeform());
        }
        private void Openform(object _frm)
        {
            if (PanelContent.Controls.Count > 0)
                PanelContent.Controls.RemoveAt(0);
            Form activeForm = _frm as Form;
            activeForm.Dock = DockStyle.Fill;
            activeForm.TopLevel = false;
            PanelContent.Controls.Add(activeForm);
            PanelContent.Tag = activeForm;
            activeForm.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Openform(new studentRegisterform());
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {
            //Openform(new homeform());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Openform(new levelRegestration());
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Openform(new userform());
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Openform(new Examform());
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            Openform(new secondaryExamform());
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Openform(new primaryExamform());
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblwatch.Text = DateTime.Now.ToString("T");
        }

        private void gunaGoogleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaGoogleSwitch1.Checked == true)
            {
                sidebar.BackColor = Color.FromArgb(34, 36, 49);
                panel1.BackColor = Color.FromArgb(34, 36, 49);
                
                ///label1.Text = BackColor Color.

            }
            else
            {
                sidebar.BackColor = Color.RoyalBlue;
                panel1.BackColor = Color.RoyalBlue;

            }
        }

        private void paintusername(object sender, PaintEventArgs e)
        {
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void paintpanel2(object sender, PaintEventArgs e)
        {
            Openform(new homeform());
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Openform(new report());
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            Openform(new primaryReportForm());
        }
    }
}
