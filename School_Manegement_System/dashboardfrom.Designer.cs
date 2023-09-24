namespace School_Manegement_System
{
    partial class dashboardfrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardfrom));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PanelContent = new Guna.UI.WinForms.GunaPanel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGoogleSwitch1 = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.lblwatch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btndashboard = new Guna.UI.WinForms.GunaButton();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaButton8 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnstudent = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btnExam = new Guna.UI.WinForms.GunaButton();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton7 = new Guna.UI.WinForms.GunaButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.White;
            this.PanelContent.Controls.Add(this.panelHome);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(254, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1029, 678);
            this.PanelContent.TabIndex = 1;
            this.PanelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1029, 678);
            this.panelHome.TabIndex = 0;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.paintpanel2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.gunaGoogleSwitch1);
            this.panel1.Controls.Add(this.lblwatch);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaGoogleSwitch1
            // 
            this.gunaGoogleSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaGoogleSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch1.Location = new System.Drawing.Point(894, 39);
            this.gunaGoogleSwitch1.Name = "gunaGoogleSwitch1";
            this.gunaGoogleSwitch1.Size = new System.Drawing.Size(74, 45);
            this.gunaGoogleSwitch1.TabIndex = 0;
            this.gunaGoogleSwitch1.CheckedChanged += new System.EventHandler(this.gunaGoogleSwitch1_CheckedChanged);
            // 
            // lblwatch
            // 
            this.lblwatch.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwatch.ForeColor = System.Drawing.Color.White;
            this.lblwatch.Location = new System.Drawing.Point(765, 28);
            this.lblwatch.Name = "lblwatch";
            this.lblwatch.Size = new System.Drawing.Size(159, 56);
            this.lblwatch.TabIndex = 0;
            this.lblwatch.Text = " ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(946, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "School Manegment System";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btndashboard);
            this.gunaPanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(251, 97);
            this.gunaPanel1.TabIndex = 2;
            // 
            // btndashboard
            // 
            this.btndashboard.AnimationHoverSpeed = 0.07F;
            this.btndashboard.AnimationSpeed = 0.03F;
            this.btndashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btndashboard.BorderColor = System.Drawing.Color.Black;
            this.btndashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btndashboard.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
            this.btndashboard.ImageSize = new System.Drawing.Size(33, 33);
            this.btndashboard.Location = new System.Drawing.Point(7, 39);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btndashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btndashboard.OnHoverImage = null;
            this.btndashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btndashboard.Size = new System.Drawing.Size(213, 58);
            this.btndashboard.TabIndex = 1;
            this.btndashboard.Text = "  Dashboard";
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.sidebar.Controls.Add(this.gunaPanel1);
            this.sidebar.Controls.Add(this.gunaButton8);
            this.sidebar.Controls.Add(this.gunaButton1);
            this.sidebar.Controls.Add(this.btnstudent);
            this.sidebar.Controls.Add(this.gunaButton3);
            this.sidebar.Controls.Add(this.btnExam);
            this.sidebar.Controls.Add(this.gunaButton6);
            this.sidebar.Controls.Add(this.gunaButton5);
            this.sidebar.Controls.Add(this.gunaButton2);
            this.sidebar.Controls.Add(this.gunaButton4);
            this.sidebar.Controls.Add(this.gunaButton7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(254, 678);
            this.sidebar.TabIndex = 0;
            // 
            // gunaButton8
            // 
            this.gunaButton8.AnimationHoverSpeed = 0.07F;
            this.gunaButton8.AnimationSpeed = 0.03F;
            this.gunaButton8.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton8.ForeColor = System.Drawing.Color.White;
            this.gunaButton8.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton8.Image")));
            this.gunaButton8.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton8.Location = new System.Drawing.Point(8, 111);
            this.gunaButton8.Margin = new System.Windows.Forms.Padding(8);
            this.gunaButton8.Name = "gunaButton8";
            this.gunaButton8.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton8.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton8.OnHoverImage = null;
            this.gunaButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton8.Size = new System.Drawing.Size(189, 42);
            this.gunaButton8.TabIndex = 9;
            this.gunaButton8.Text = "  Home";
            this.gunaButton8.Click += new System.EventHandler(this.gunaButton8_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton1.Location = new System.Drawing.Point(8, 169);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(8);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(189, 42);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "  User Form";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.AnimationHoverSpeed = 0.07F;
            this.btnstudent.AnimationSpeed = 0.03F;
            this.btnstudent.BaseColor = System.Drawing.Color.Transparent;
            this.btnstudent.BorderColor = System.Drawing.Color.Black;
            this.btnstudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnstudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnstudent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.Color.White;
            this.btnstudent.Image = ((System.Drawing.Image)(resources.GetObject("btnstudent.Image")));
            this.btnstudent.ImageSize = new System.Drawing.Size(28, 28);
            this.btnstudent.Location = new System.Drawing.Point(8, 227);
            this.btnstudent.Margin = new System.Windows.Forms.Padding(8);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnstudent.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.btnstudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnstudent.OnHoverImage = null;
            this.btnstudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnstudent.Size = new System.Drawing.Size(189, 42);
            this.btnstudent.TabIndex = 3;
            this.btnstudent.Text = "  Student ";
            this.btnstudent.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton3.Location = new System.Drawing.Point(8, 285);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(8);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(189, 42);
            this.gunaButton3.TabIndex = 4;
            this.gunaButton3.Text = "  Level Regi";
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // btnExam
            // 
            this.btnExam.AnimationHoverSpeed = 0.07F;
            this.btnExam.AnimationSpeed = 0.03F;
            this.btnExam.BaseColor = System.Drawing.Color.Transparent;
            this.btnExam.BorderColor = System.Drawing.Color.Black;
            this.btnExam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExam.FocusedColor = System.Drawing.Color.Empty;
            this.btnExam.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.Image = ((System.Drawing.Image)(resources.GetObject("btnExam.Image")));
            this.btnExam.ImageSize = new System.Drawing.Size(28, 28);
            this.btnExam.Location = new System.Drawing.Point(8, 343);
            this.btnExam.Margin = new System.Windows.Forms.Padding(8);
            this.btnExam.Name = "btnExam";
            this.btnExam.OnHoverBaseColor = System.Drawing.Color.Black;
            this.btnExam.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.btnExam.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExam.OnHoverImage = null;
            this.btnExam.OnPressedColor = System.Drawing.Color.Black;
            this.btnExam.Size = new System.Drawing.Size(189, 42);
            this.btnExam.TabIndex = 5;
            this.btnExam.Text = "  Exam";
            this.btnExam.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton6.Image")));
            this.gunaButton6.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton6.Location = new System.Drawing.Point(8, 401);
            this.gunaButton6.Margin = new System.Windows.Forms.Padding(8);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Size = new System.Drawing.Size(189, 42);
            this.gunaButton6.TabIndex = 7;
            this.gunaButton6.Text = "  Secondary Exam";
            this.gunaButton6.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = global::School_Manegement_System.Properties.Resources.icons8_school_24px;
            this.gunaButton5.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton5.Location = new System.Drawing.Point(8, 459);
            this.gunaButton5.Margin = new System.Windows.Forms.Padding(8);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(189, 42);
            this.gunaButton5.TabIndex = 6;
            this.gunaButton5.Text = "  Primary Exam";
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::School_Manegement_System.Properties.Resources.icons8_report_card_24px;
            this.gunaButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton2.Location = new System.Drawing.Point(15, 524);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(15);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(189, 42);
            this.gunaButton2.TabIndex = 10;
            this.gunaButton2.Text = "Sec Report";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click_1);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.White;
            this.gunaButton4.Image = global::School_Manegement_System.Properties.Resources.icons8_edit_graph_report_24px;
            this.gunaButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton4.Location = new System.Drawing.Point(15, 596);
            this.gunaButton4.Margin = new System.Windows.Forms.Padding(15);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Size = new System.Drawing.Size(189, 42);
            this.gunaButton4.TabIndex = 11;
            this.gunaButton4.Text = "Prim Report";
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click_1);
            // 
            // gunaButton7
            // 
            this.gunaButton7.AnimationHoverSpeed = 0.07F;
            this.gunaButton7.AnimationSpeed = 0.03F;
            this.gunaButton7.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton7.ForeColor = System.Drawing.Color.White;
            this.gunaButton7.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton7.Image")));
            this.gunaButton7.ImageSize = new System.Drawing.Size(28, 28);
            this.gunaButton7.Location = new System.Drawing.Point(8, 661);
            this.gunaButton7.Margin = new System.Windows.Forms.Padding(8);
            this.gunaButton7.Name = "gunaButton7";
            this.gunaButton7.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaButton7.OnHoverBorderColor = System.Drawing.Color.MintCream;
            this.gunaButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton7.OnHoverImage = null;
            this.gunaButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton7.Size = new System.Drawing.Size(189, 42);
            this.gunaButton7.TabIndex = 8;
            this.gunaButton7.Text = "  Log out";
            this.gunaButton7.Click += new System.EventHandler(this.gunaButton7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dashboardfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboardfrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboardfrom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboardfrom_Load);
            this.PanelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btnstudent;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton btnExam;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton7;
        private Guna.UI.WinForms.GunaButton gunaButton8;
        private Guna.UI.WinForms.GunaPanel PanelContent;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btndashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label lblwatch;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch1;
        private System.Windows.Forms.Panel panelHome;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton4;
    }
}