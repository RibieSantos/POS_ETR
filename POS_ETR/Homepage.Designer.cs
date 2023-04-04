namespace POS_ETR
{
    partial class Homepage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.uname = new System.Windows.Forms.Label();
			this.pass = new System.Windows.Forms.Label();
			this.Adduser = new Guna.UI2.WinForms.Guna2Button();
			this.userview = new Guna.UI2.WinForms.Guna2DataGridView();
			this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.sampleDBDataSet = new POS_ETR.sampleDBDataSet();
			this.userTblTableAdapter = new POS_ETR.sampleDBDataSetTableAdapters.UserTblTableAdapter();
			this.delete = new Guna.UI2.WinForms.Guna2Button();
			this.update = new Guna.UI2.WinForms.Guna2Button();
			this.label3 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.TextBox();
			this.show = new Guna.UI2.WinForms.Guna2CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(909, 32);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(854, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "-";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(877, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// username
			// 
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(107, 118);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(150, 24);
			this.username.TabIndex = 1;
			this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(107, 148);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(150, 24);
			this.password.TabIndex = 2;
			this.password.UseSystemPasswordChar = true;
			// 
			// uname
			// 
			this.uname.AutoSize = true;
			this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uname.Location = new System.Drawing.Point(14, 124);
			this.uname.Name = "uname";
			this.uname.Size = new System.Drawing.Size(77, 18);
			this.uname.TabIndex = 4;
			this.uname.Text = "Username";
			this.uname.Click += new System.EventHandler(this.label4_Click);
			// 
			// pass
			// 
			this.pass.AutoSize = true;
			this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pass.Location = new System.Drawing.Point(16, 154);
			this.pass.Name = "pass";
			this.pass.Size = new System.Drawing.Size(75, 18);
			this.pass.TabIndex = 5;
			this.pass.Text = "Password";
			// 
			// Adduser
			// 
			this.Adduser.BorderRadius = 8;
			this.Adduser.BorderThickness = 1;
			this.Adduser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.Adduser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.Adduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.Adduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.Adduser.FillColor = System.Drawing.Color.BurlyWood;
			this.Adduser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Adduser.ForeColor = System.Drawing.Color.Black;
			this.Adduser.HoverState.BorderColor = System.Drawing.Color.White;
			this.Adduser.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			this.Adduser.HoverState.FillColor = System.Drawing.Color.White;
			this.Adduser.Location = new System.Drawing.Point(17, 213);
			this.Adduser.Name = "Adduser";
			this.Adduser.Size = new System.Drawing.Size(240, 28);
			this.Adduser.TabIndex = 6;
			this.Adduser.Text = "Add User";
			this.Adduser.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// userview
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.userview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.userview.AutoGenerateColumns = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.userview.ColumnHeadersHeight = 15;
			this.userview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.userview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
			this.userview.DataSource = this.userTblBindingSource1;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.userview.DefaultCellStyle = dataGridViewCellStyle9;
			this.userview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.userview.Location = new System.Drawing.Point(317, 67);
			this.userview.Name = "userview";
			this.userview.RowHeadersVisible = false;
			this.userview.Size = new System.Drawing.Size(532, 308);
			this.userview.TabIndex = 7;
			this.userview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.userview.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.userview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.userview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.userview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.userview.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.userview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.userview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.userview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.userview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.userview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.userview.ThemeStyle.HeaderStyle.Height = 15;
			this.userview.ThemeStyle.ReadOnly = false;
			this.userview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.userview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.userview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.userview.ThemeStyle.RowsStyle.Height = 22;
			this.userview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.userview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
			// userTblBindingSource1
			// 
			this.userTblBindingSource1.DataMember = "UserTbl";
			this.userTblBindingSource1.DataSource = this.sampleDBDataSet;
			// 
			// sampleDBDataSet
			// 
			this.sampleDBDataSet.DataSetName = "sampleDBDataSet";
			this.sampleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userTblTableAdapter
			// 
			this.userTblTableAdapter.ClearBeforeFill = true;
			// 
			// delete
			// 
			this.delete.BorderRadius = 8;
			this.delete.BorderThickness = 1;
			this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.delete.FillColor = System.Drawing.Color.Red;
			this.delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete.ForeColor = System.Drawing.Color.Black;
			this.delete.HoverState.BorderColor = System.Drawing.Color.White;
			this.delete.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			this.delete.HoverState.FillColor = System.Drawing.Color.White;
			this.delete.Location = new System.Drawing.Point(17, 281);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(240, 28);
			this.delete.TabIndex = 8;
			this.delete.Text = "Delete User";
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// update
			// 
			this.update.BorderRadius = 8;
			this.update.BorderThickness = 1;
			this.update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.update.FillColor = System.Drawing.Color.LimeGreen;
			this.update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.ForeColor = System.Drawing.Color.Black;
			this.update.HoverState.BorderColor = System.Drawing.Color.White;
			this.update.HoverState.CustomBorderColor = System.Drawing.Color.Black;
			this.update.HoverState.FillColor = System.Drawing.Color.White;
			this.update.Location = new System.Drawing.Point(17, 247);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(240, 28);
			this.update.TabIndex = 9;
			this.update.Text = "Update User";
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "ID";
			// 
			// id
			// 
			this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id.Location = new System.Drawing.Point(107, 88);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(150, 24);
			this.id.TabIndex = 10;
			this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
			// 
			// show
			// 
			this.show.AutoSize = true;
			this.show.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.show.CheckedState.BorderRadius = 0;
			this.show.CheckedState.BorderThickness = 0;
			this.show.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.show.Location = new System.Drawing.Point(107, 179);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(102, 17);
			this.show.TabIndex = 12;
			this.show.Text = "Show Password";
			this.show.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.show.UncheckedState.BorderRadius = 0;
			this.show.UncheckedState.BorderThickness = 0;
			this.show.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
			// 
			// Homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 423);
			this.Controls.Add(this.show);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.id);
			this.Controls.Add(this.update);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.userview);
			this.Controls.Add(this.Adduser);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.uname);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Homepage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Homepage";
			this.Load += new System.EventHandler(this.Homepage_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sampleDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label pass;
        private Guna.UI2.WinForms.Guna2Button Adduser;
        private Guna.UI2.WinForms.Guna2DataGridView userview;
        private sampleDBDataSet sampleDBDataSet;
        private sampleDBDataSetTableAdapters.UserTblTableAdapter userTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userTblBindingSource1;
		private Guna.UI2.WinForms.Guna2Button delete;
		private Guna.UI2.WinForms.Guna2Button update;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox id;
		private Guna.UI2.WinForms.Guna2CheckBox show;
	}
}