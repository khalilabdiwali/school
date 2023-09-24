namespace School_Manegement_System
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.gunaWinCircleProgressIndicator1 = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.lblProgresresult = new System.Windows.Forms.Label();
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // gunaWinCircleProgressIndicator1
            // 
            this.gunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaWinCircleProgressIndicator1.Location = new System.Drawing.Point(182, 220);
            this.gunaWinCircleProgressIndicator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaWinCircleProgressIndicator1.Name = "gunaWinCircleProgressIndicator1";
            this.gunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.gunaWinCircleProgressIndicator1.Size = new System.Drawing.Size(96, 104);
            this.gunaWinCircleProgressIndicator1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(139, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOADING..";
            // 
            // timer_loading
            // 
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // lblProgresresult
            // 
            this.lblProgresresult.AutoSize = true;
            this.lblProgresresult.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresresult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblProgresresult.Location = new System.Drawing.Point(209, 365);
            this.lblProgresresult.Name = "lblProgresresult";
            this.lblProgresresult.Size = new System.Drawing.Size(0, 34);
            this.lblProgresresult.TabIndex = 5;
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(165, 209);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.gunaCircleProgressBar1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(67, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "School Manegment System";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.lblProgresresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaWinCircleProgressIndicator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunaWinCircleProgressIndicator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_loading;
        private System.Windows.Forms.Label lblProgresresult;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}

