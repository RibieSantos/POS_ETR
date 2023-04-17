using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ETR
{
	internal class Connection
	{
		private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\johns\source\repos\POS_ETR\POS_ETR\sampleDB.mdf;Integrated Security=True;Connect Timeout=30");

		

	}
}
