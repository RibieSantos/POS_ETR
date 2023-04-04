using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ETR
{
	public partial class Maintain : Form
	{
		public Maintain()
		{
			InitializeComponent();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home home = new Home();
			home.Show();
		}
	}
}
