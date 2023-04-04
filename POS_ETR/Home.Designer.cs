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
			this.panel1 = new System.Windows.Forms.Panel();
			this.maintenance = new Guna.UI2.WinForms.Guna2Button();
			this.logout = new Guna.UI2.WinForms.Guna2PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.maintenance);
			this.panel1.Controls.Add(this.logout);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(880, 39);
			this.panel1.TabIndex = 0;
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
			this.maintenance.Location = new System.Drawing.Point(730, 0);
			this.maintenance.Name = "maintenance";
			this.maintenance.Size = new System.Drawing.Size(107, 39);
			this.maintenance.TabIndex = 1;
			this.maintenance.Text = "Maintenance";
			this.maintenance.Click += new System.EventHandler(this.maintenance_Click);
			// 
			// logout
			// 
			this.logout.BackColor = System.Drawing.Color.Transparent;
			this.logout.FillColor = System.Drawing.Color.Transparent;
			this.logout.Image = global::POS_ETR.Properties.Resources.logoutIcon;
			this.logout.ImageRotate = 0F;
			this.logout.Location = new System.Drawing.Point(843, 7);
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
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2PictureBox logout;
		private Guna.UI2.WinForms.Guna2Button maintenance;
	}
}