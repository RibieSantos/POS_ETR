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
			this.maintenance = new Guna.UI2.WinForms.Guna2Button();
			this.mainDropDown = new Guna.UI2.WinForms.Guna2Panel();
			this.user = new Guna.UI2.WinForms.Guna2Button();
			this.product = new Guna.UI2.WinForms.Guna2Button();
			this.category = new Guna.UI2.WinForms.Guna2Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.logout = new Guna.UI2.WinForms.Guna2PictureBox();
			this.mainDropDown.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
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
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 470);
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
			this.ResumeLayout(false);

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
	}
}