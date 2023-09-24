namespace School_Manegement_System
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.btnlogin = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnshow = new Guna.UI.WinForms.GunaButton();
            this.btnhide = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(156, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // txtUsername
            // 
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(124, 223);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(256, 36);
            this.txtUsername.TabIndex = 10;
            // 
            // txtpassword
            // 
            this.txtpassword.BaseColor = System.Drawing.Color.White;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(124, 305);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(256, 36);
            this.txtpassword.TabIndex = 11;
            // 
            // btnlogin
            // 
            this.btnlogin.AnimationHoverSpeed = 0.07F;
            this.btnlogin.AnimationSpeed = 0.03F;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.BorderColor = System.Drawing.Color.Black;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Image = null;
            this.btnlogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnlogin.Location = new System.Drawing.Point(273, 376);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnlogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnlogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnlogin.OnHoverImage = null;
            this.btnlogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnlogin.Radius = 9;
            this.btnlogin.Size = new System.Drawing.Size(107, 42);
            this.btnlogin.TabIndex = 12;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(75, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Radius = 9;
            this.btnExit.Size = new System.Drawing.Size(107, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(-7, -4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(511, 100);
            this.label12.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 34);
            this.label3.TabIndex = 56;
            this.label3.Text = "School Manegment System";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = global::School_Manegement_System.Properties.Resources.icons8_password_30px_1;
            this.gunaPictureBox3.Location = new System.Drawing.Point(71, 305);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(36, 36);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox3.TabIndex = 18;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::School_Manegement_System.Properties.Resources.icons8_user_24px_2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(71, 223);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(36, 36);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 15;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnshow
            // 
            this.btnshow.AnimationHoverSpeed = 0.07F;
            this.btnshow.AnimationSpeed = 0.03F;
            this.btnshow.BaseColor = System.Drawing.Color.White;
            this.btnshow.BorderColor = System.Drawing.Color.Black;
            this.btnshow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnshow.FocusedColor = System.Drawing.Color.Empty;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Image = ((System.Drawing.Image)(resources.GetObject("btnshow.Image")));
            this.btnshow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnshow.ImageSize = new System.Drawing.Size(20, 20);
            this.btnshow.Location = new System.Drawing.Point(328, 308);
            this.btnshow.Name = "btnshow";
            this.btnshow.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnshow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnshow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnshow.OnHoverImage = null;
            this.btnshow.OnPressedColor = System.Drawing.Color.Black;
            this.btnshow.Size = new System.Drawing.Size(35, 30);
            this.btnshow.TabIndex = 59;
            this.btnshow.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnhide
            // 
            this.btnhide.AnimationHoverSpeed = 0.07F;
            this.btnhide.AnimationSpeed = 0.03F;
            this.btnhide.BaseColor = System.Drawing.Color.White;
            this.btnhide.BorderColor = System.Drawing.Color.Black;
            this.btnhide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnhide.FocusedColor = System.Drawing.Color.Empty;
            this.btnhide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhide.ForeColor = System.Drawing.Color.White;
            this.btnhide.Image = ((System.Drawing.Image)(resources.GetObject("btnhide.Image")));
            this.btnhide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnhide.ImageSize = new System.Drawing.Size(20, 20);
            this.btnhide.Location = new System.Drawing.Point(328, 307);
            this.btnhide.Name = "btnhide";
            this.btnhide.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnhide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnhide.OnHoverForeColor = System.Drawing.Color.White;
            this.btnhide.OnHoverImage = null;
            this.btnhide.OnPressedColor = System.Drawing.Color.Black;
            this.btnhide.Size = new System.Drawing.Size(35, 30);
            this.btnhide.TabIndex = 60;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // loginform
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 522);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginform";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaButton btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Guna.UI.WinForms.GunaButton btnshow;
        private Guna.UI.WinForms.GunaButton btnhide;
    }
}