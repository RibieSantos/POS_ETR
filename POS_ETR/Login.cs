using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS_ETR
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johns\source\repos\POS_ETR\POS_ETR\sampleDB.mdf;Integrated Security=True;Connect Timeout=30");

		private void gradientPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void guna2PictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void guna2HtmlLabel4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void password_TextChanged(object sender, EventArgs e)
		{

		}

		private void loginUser_Click(object sender, EventArgs e)
		{
			String user, pass;
			user = username.Text;
			pass = password.Text;
			con.Open();

			try
			{
				String query = "SELECT * FROM Users WHERE username = '"+username.Text+"' AND password = '"+password.Text+"'";
				SqlDataAdapter sda = new SqlDataAdapter(query,con);

				DataTable dt = new DataTable();
				sda.Fill(dt);

                if (dt.Rows.Count>0)
                {
					user = username.Text;
					pass = password.Text;

					Home hp = new Home();
					hp.Show();
					this.Hide();
					MessageBox.Show("Login Successfully!","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
					MessageBox.Show("Invalid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					username.Clear();
					password.Clear();

					username.Focus();

				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
			}
			con.Close();
		}

		private void check_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void check_CheckedChanged_1(object sender, EventArgs e)
		{
			password.PasswordChar = check.Checked ? '\0' : '*';
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
