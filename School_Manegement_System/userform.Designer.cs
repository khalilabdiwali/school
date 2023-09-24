namespace School_Manegement_System
{
    partial class userform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usertycombox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndelete = new Guna.UI.WinForms.GunaButton();
            this.btnupdate = new Guna.UI.WinForms.GunaButton();
            this.btnInsert = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCHOOL_MANEG_SYSTEMDataSet = new School_Manegement_System.SCHOOL_MANEG_SYSTEMDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtconfirm = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuserid = new Guna.UI.WinForms.GunaTextBox();
            this.userTableTableAdapter = new School_Manegement_System.SCHOOL_MANEG_SYSTEMDataSetTableAdapters.UserTableTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHOOL_MANEG_SYSTEMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.usertycombox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtconfirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtuserid);
            this.panel1.Location = new System.Drawing.Point(-15, -28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 767);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 745);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1246, 22);
            this.statusStrip1.TabIndex = 72;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(52, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 100);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search here";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 59;
            this.label13.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(139, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(315, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Location = new System.Drawing.Point(198, 296);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(474, 5);
            this.panel7.TabIndex = 70;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(199, 249);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(474, 5);
            this.panel6.TabIndex = 69;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(198, 342);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 5);
            this.panel5.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(199, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 5);
            this.panel4.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(199, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 5);
            this.panel3.TabIndex = 66;
            // 
            // usertycombox
            // 
            this.usertycombox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usertycombox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertycombox.FormattingEnabled = true;
            this.usertycombox.Items.AddRange(new object[] {
            "Select One",
            "admin",
            "user"});
            this.usertycombox.Location = new System.Drawing.Point(198, 311);
            this.usertycombox.Name = "usertycombox";
            this.usertycombox.Size = new System.Drawing.Size(474, 31);
            this.usertycombox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "User type:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Location = new System.Drawing.Point(797, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 189);
            this.panel2.TabIndex = 60;
            // 
            // btndelete
            // 
            this.btndelete.AnimationHoverSpeed = 0.07F;
            this.btndelete.AnimationSpeed = 0.03F;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btndelete.BorderColor = System.Drawing.Color.Black;
            this.btndelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndelete.FocusedColor = System.Drawing.Color.Empty;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Image = null;
            this.btndelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btndelete.Location = new System.Drawing.Point(39, 120);
            this.btndelete.Name = "btndelete";
            this.btndelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btndelete.OnHoverImage = null;
            this.btndelete.OnPressedColor = System.Drawing.Color.Black;
            this.btndelete.Radius = 8;
            this.btndelete.Size = new System.Drawing.Size(160, 42);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AnimationHoverSpeed = 0.07F;
            this.btnupdate.AnimationSpeed = 0.03F;
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnupdate.BorderColor = System.Drawing.Color.Black;
            this.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnupdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = null;
            this.btnupdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnupdate.Location = new System.Drawing.Point(39, 66);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupdate.OnHoverImage = null;
            this.btnupdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnupdate.Radius = 8;
            this.btnupdate.Size = new System.Drawing.Size(160, 42);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AnimationHoverSpeed = 0.07F;
            this.btnInsert.AnimationSpeed = 0.03F;
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnInsert.BorderColor = System.Drawing.Color.Black;
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInsert.FocusedColor = System.Drawing.Color.Empty;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = null;
            this.btnInsert.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInsert.Location = new System.Drawing.Point(39, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnInsert.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInsert.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInsert.OnHoverImage = null;
            this.btnInsert.OnPressedColor = System.Drawing.Color.Black;
            this.btnInsert.Radius = 8;
            this.btnInsert.Size = new System.Drawing.Size(160, 42);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Register";
            this.btnInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 500);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 240);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "User_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.sCHOOL_MANEG_SYSTEMDataSet;
            // 
            // sCHOOL_MANEG_SYSTEMDataSet
            // 
            this.sCHOOL_MANEG_SYSTEMDataSet.DataSetName = "SCHOOL_MANEG_SYSTEMDataSet";
            this.sCHOOL_MANEG_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(569, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 47);
            this.label9.TabIndex = 55;
            this.label9.Text = "User Form";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(-1, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1259, 100);
            this.label12.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Confirm:";
            // 
            // txtconfirm
            // 
            this.txtconfirm.BackColor = System.Drawing.Color.Transparent;
            this.txtconfirm.BaseColor = System.Drawing.Color.White;
            this.txtconfirm.BorderColor = System.Drawing.Color.Silver;
            this.txtconfirm.BorderSize = 0;
            this.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirm.FocusedBaseColor = System.Drawing.Color.Ivory;
            this.txtconfirm.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtconfirm.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtconfirm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.Location = new System.Drawing.Point(198, 262);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Radius = 6;
            this.txtconfirm.SelectedText = "";
            this.txtconfirm.Size = new System.Drawing.Size(474, 36);
            this.txtconfirm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BaseColor = System.Drawing.Color.White;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.BorderSize = 0;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.Ivory;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(198, 215);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Radius = 6;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(474, 36);
            this.txtpassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name:";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.BaseColor = System.Drawing.Color.White;
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.BorderSize = 0;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.FocusedBaseColor = System.Drawing.Color.Ivory;
            this.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(198, 169);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.Radius = 6;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(474, 36);
            this.txtusername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "User id:";
            // 
            // txtuserid
            // 
            this.txtuserid.BackColor = System.Drawing.Color.Transparent;
            this.txtuserid.BaseColor = System.Drawing.Color.White;
            this.txtuserid.BorderColor = System.Drawing.Color.Silver;
            this.txtuserid.BorderSize = 0;
            this.txtuserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuserid.FocusedBaseColor = System.Drawing.Color.Ivory;
            this.txtuserid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtuserid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtuserid.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(198, 123);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.PasswordChar = '\0';
            this.txtuserid.Radius = 6;
            this.txtuserid.SelectedText = "";
            this.txtuserid.Size = new System.Drawing.Size(474, 36);
            this.txtuserid.TabIndex = 0;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 711);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userform";
            this.Load += new System.EventHandler(this.userform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCHOOL_MANEG_SYSTEMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox usertycombox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btndelete;
        private Guna.UI.WinForms.GunaButton btnupdate;
        private Guna.UI.WinForms.GunaButton btnInsert;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtconfirm;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtuserid;
        private SCHOOL_MANEG_SYSTEMDataSet sCHOOL_MANEG_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private SCHOOL_MANEG_SYSTEMDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}