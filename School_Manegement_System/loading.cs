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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            if (gunaCircleProgressBar1.Value < 100)
            {
                gunaCircleProgressBar1.Value += 5;
                lblProgresresult.Text = gunaCircleProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer_loading.Stop();
                loginform loginform = new loginform();
                loginform.Show();
                this.Hide();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer_loading.Start();
        }
    }
}
