	
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
		public Home()
		{
			InitializeComponent();
		}

		private void logout_Click(object sender, EventArgs e)
		{
			this.Close();
			Login ln = new Login();
			ln.Show();
		}

		private void maintenance_Click(object sender, EventArgs e)
		{
			this.Close();
			Maintain maintain = new Maintain();
			maintain.Show();
		}
	}
}
