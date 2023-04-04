	
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

namespace POS_ETR
{
	public partial class Home : Form
	{
		private bool isCollapsed;
		public Home()
		{
			InitializeComponent();
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
	}
}
