namespace POS_ETR
{
	partial class Home
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.maintenance = new Guna.UI2.WinForms.Guna2Button();
			this.mainDropDown = new Guna.UI2.WinForms.Guna2Panel();
			this.user = new Guna.UI2.WinForms.Guna2Button();
			this.product = new Guna.UI2.WinForms.Guna2Button();
			this.category = new Guna.UI2.WinForms.Guna2Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.logout = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sampleDBDataSet1 = new POS_ETR.sampleDBDataSet1();
			this.usersTableAdapter = new POS_ETR.sampleDBDataSet1TableAdapters.UsersTableAdapter();
			this.username = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.password = new Guna.UI2.WinForms.Guna2TextBox();
			this.addbtn = new Guna.UI2.WinForms.Guna2Button();
			this.mainDropDown.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// maintenance
			// 
			this.maintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.maintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.maintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.maintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.maintenance.FillColor = System.Drawing.Color.Transparent;
			this.maintenance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.maintenance.ForeColor = System.Drawing.Color.Black;
			this.maintenance.Location = new System.Drawing.Point(722, 0);
			this.maintenance.Name = "maintenance";
			this.maintenance.Size = new System.Drawing.Size(115, 39);
			this.maintenance.TabIndex = 1;
			this.maintenance.Text = "Maintenance";
			this.maintenance.Click += new System.EventHandler(this.maintenance_Click);
			// 
			// mainDropDown
			// 
			this.mainDropDown.Controls.Add(this.user);
			this.mainDropDown.Controls.Add(this.product);
			this.mainDropDown.Controls.Add(this.category);
			this.mainDropDown.Location = new System.Drawing.Point(722, 36);
			this.mainDropDown.MaximumSize = new System.Drawing.Size(115, 92);
			this.mainDropDown.MinimumSize = new System.Drawing.Size(115, 0);
			this.mainDropDown.Name = "mainDropDown";
			this.mainDropDown.Size = new System.Drawing.Size(115, 1);
			this.mainDropDown.TabIndex = 2;
			// 
			// user
			// 
			this.user.CustomBorderColor = System.Drawing.Color.Gainsboro;
			this.user.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.user.FillColor = System.Drawing.Color.LightSeaGreen;
			this.user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.user.ForeColor = System.Drawing.Color.Black;
			this.user.Image = global::POS_ETR.Properties.Resources.admin;
			this.user.Location = new System.Drawing.Point(0, 61);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(115, 30);
			this.user.TabIndex = 4;
			this.user.Text = "User";
			// 
			// product
			// 
			this.product.CustomBorderColor = System.Drawing.Color.Gainsboro;
			this.product.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.product.FillColor = System.Drawing.Color.LightSeaGreen;
			this.product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.product.ForeColor = System.Drawing.Color.Black;
			this.product.Image = global::POS_ETR.Properties.Resources.product;
			this.product.Location = new System.Drawing.Point(0, 31);
			this.product.Name = "product";
			this.product.Size = new System.Drawing.Size(115, 30);
			this.product.TabIndex = 3;
			this.product.Text = "Product";
			// 
			// category
			// 
			this.category.CustomBorderColor = System.Drawing.Color.Gainsboro;
			this.category.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.category.FillColor = System.Drawing.Color.LightSeaGreen;
			this.category.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.category.ForeColor = System.Drawing.Color.Black;
			this.category.Image = global::POS_ETR.Properties.Resources.category;
			this.category.Location = new System.Drawing.Point(-2, 1);
			this.category.Name = "category";
			this.category.Size = new System.Drawing.Size(117, 30);
			this.category.TabIndex = 2;
			this.category.Text = "Category";
			this.category.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 15;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2Panel1.Controls.Add(this.maintenance);
			this.guna2Panel1.Controls.Add(this.logout);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(880, 36);
			this.guna2Panel1.TabIndex = 3;
			// 
			// logout
			// 
			this.logout.BackColor = System.Drawing.Color.Transparent;
			this.logout.FillColor = System.Drawing.Color.Transparent;
			this.logout.Image = global::POS_ETR.Properties.Resources.logoutIcon;
			this.logout.ImageRotate = 0F;
			this.logout.Location = new System.Drawing.Point(843, 5);
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(25, 27);
			this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logout.TabIndex = 1;
			this.logout.TabStop = false;
			this.logout.UseTransparentBackground = true;
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// guna2DataGridView1
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.guna2DataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.guna2DataGridView1.ColumnHeadersHeight = 15;
			this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn});
			this.guna2DataGridView1.DataSource = this.usersBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
			this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.Location = new System.Drawing.Point(296, 73);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.Size = new System.Drawing.Size(504, 296);
			this.guna2DataGridView1.TabIndex = 4;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
			this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
			// 
			// useridDataGridViewTextBoxColumn
			// 
			this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
			this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
			this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
			this.useridDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			// 
			// usertypeDataGridViewTextBoxColumn
			// 
			this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "user_type";
			this.usertypeDataGridViewTextBoxColumn.HeaderText = "user_type";
			this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataMember = "Users";
			this.usersBindingSource.DataSource = this.sampleDBDataSet1;
			// 
			// sampleDBDataSet1
			// 
			this.sampleDBDataSet1.DataSetName = "sampleDBDataSet1";
			this.sampleDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usersTableAdapter
			// 
			this.usersTableAdapter.ClearBeforeFill = true;
			// 
			// username
			// 
			this.username.BorderColor = System.Drawing.Color.Black;
			this.username.BorderRadius = 10;
			this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.username.ForeColor = System.Drawing.Color.Black;
			this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.username.Location = new System.Drawing.Point(40, 103);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "Username";
			this.username.SelectedText = "";
			this.username.Size = new System.Drawing.Size(177, 24);
			this.username.TabIndex = 5;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 82);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(59, 15);
			this.guna2HtmlLabel1.TabIndex = 6;
			this.guna2HtmlLabel1.Text = "Username";
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(40, 136);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 15);
			this.guna2HtmlLabel2.TabIndex = 8;
			this.guna2HtmlLabel2.Text = "Password";
			// 
			// password
			// 
			this.password.BorderColor = System.Drawing.Color.Black;
			this.password.BorderRadius = 10;
			this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.password.ForeColor = System.Drawing.Color.Black;
			this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.password.Location = new System.Drawing.Point(40, 157);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderText = "Password";
			this.password.SelectedText = "";
			this.password.Size = new System.Drawing.Size(177, 24);
			this.password.TabIndex = 7;
			// 
			// addbtn
			// 
			this.addbtn.BorderRadius = 10;
			this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addbtn.ForeColor = System.Drawing.Color.White;
			this.addbtn.Location = new System.Drawing.Point(40, 187);
			this.addbtn.Name = "addbtn";
			this.addbtn.Size = new System.Drawing.Size(177, 37);
			this.addbtn.TabIndex = 9;
			this.addbtn.Text = "Add Cashier";
			this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 470);
			this.Controls.Add(this.addbtn);
			this.Controls.Add(this.guna2HtmlLabel2);
			this.Controls.Add(this.password);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.username);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.mainDropDown);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.Load += new System.EventHandler(this.Home_Load);
			this.mainDropDown.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2PictureBox logout;
		private Guna.UI2.WinForms.Guna2Button maintenance;
		private Guna.UI2.WinForms.Guna2Panel mainDropDown;
		private Guna.UI2.WinForms.Guna2Button category;
		private Guna.UI2.WinForms.Guna2Button user;
		private Guna.UI2.WinForms.Guna2Button product;
		private System.Windows.Forms.Timer timer1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
		private sampleDBDataSet1 sampleDBDataSet1;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private sampleDBDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
		private Guna.UI2.WinForms.Guna2TextBox username;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2TextBox password;
		private Guna.UI2.WinForms.Guna2Button addbtn;
	}
}