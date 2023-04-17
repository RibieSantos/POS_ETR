	
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_ETR
{
	public partial class Home : Form
	{
		private bool isCollapsed;
		public Home()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johns\source\repos\POS_ETR\POS_ETR\sampleDB.mdf;Integrated Security=True;Connect Timeout=30");
		private void userData()
		{
			try
			{
				con.Open();
				string query = "SELECT * FROM Users";
				SqlDataAdapter adapter = new SqlDataAdapter(query, con);
				SqlCommandBuilder build = new SqlCommandBuilder(adapter);
				var ds = new DataSet();
				adapter.Fill(ds);
				guna2DataGridView1.DataSource = ds.Tables[0];
				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void logout_Click(object sender, EventArgs e)
		{
            if (MessageBox.Show("Do you really want to logout?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes){
				this.Close();
				Login ln = new Login();
				ln.Show();
				MessageBox.Show("Logout Successfully", "Logout", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
        }

		private void maintenance_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{

		}

		private void Home_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'sampleDBDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.sampleDBDataSet1.Users);

        }

        private void timer1_Tick(object sender, EventArgs e)
		{
            if (isCollapsed)
            {
				mainDropDown.Height += 10;
                if (mainDropDown.Size == mainDropDown.MaximumSize)
                {
					timer1.Stop();
					isCollapsed = false;
                }
            }
            else
            {
				mainDropDown.Height -= 10;
				if (mainDropDown.Size == mainDropDown.MinimumSize)
				{
					timer1.Stop();
					isCollapsed = true;
				}
			}
        }

		private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void addbtn_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				string query = "INSERT INTO Users VALUES('" + username.Text + "','" + password.Text + "', 'cashier')";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User Added Successfully!", "Success", MessageBoxButtons.OK);
				username.Clear();
				password.Clear();
				con.Close();
				userData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void password_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
