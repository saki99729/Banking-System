using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
	class function
	{
		protected SqlConnection getconnection()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "data source = (localdb)\\ProjectsV13;database =bank12;integrated security =True";
			return con;
		}

		public DataSet getData(String query)
		{
			SqlConnection con = getconnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			cmd.CommandText = query;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return ds;


		}

		public void setData(String query,String msg)
		{
			SqlConnection con = getconnection();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = query;
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show(msg,"Infomation",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
