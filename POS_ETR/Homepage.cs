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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johns\OneDrive\Documents\sampleDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void userData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM UserTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder build = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                userview.DataSource = ds.Tables[0];
                con.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO UserTbl VALUES('" + username.Text + "','" + password.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully!", "Success", MessageBoxButtons.OK);
                username.Clear();
                con.Close();
                userData();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDBDataSet.UserTbl' table. You can move, or remove it, as needed.
            this.userTblTableAdapter.Fill(this.sampleDBDataSet.UserTbl);

        }

		private void update_Click(object sender, EventArgs e)
		{
            try
            {
				con.Open();
				string query = "UPDATE UserTbl SET username = '" + username.Text + "', password = '" + password.Text + "' WHERE user_id='" + id.Text + "'";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User Updated Successfully!", "Success", MessageBoxButtons.OK);
				con.Close();
				userData();
			}
            catch(Exception ex)
            {
				MessageBox.Show(ex.Message);

			}


		}

		private void id_TextChanged(object sender, EventArgs e)
		{

		}

		private void delete_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				string query = "DELETE UserTbl WHERE user_id = '"+id.Text+"'";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("User Deleted Successfully!", "Deleted", MessageBoxButtons.OK);
				con.Close();
				userData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void show_CheckedChanged(object sender, EventArgs e)
		{
            if (show.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;

			}
		}
	}
}
