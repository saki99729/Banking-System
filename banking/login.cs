using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Banking_PL;
using UI_AcoountPassBook;

namespace banking
{
	public partial class login : Form
	{
		function fn = new function();
		String query;
		DataSet ds;
		public login()
		{
			InitializeComponent();
		}

		private void btnlog_Click(object sender, EventArgs e)
		{
			query = "select * from users";
			ds = fn.getData(query);
			if(ds.Tables[0].Rows.Count==0)
			{
				if(txtuser.Text=="Root" && txtpass.Text=="Root")
				{
					UI_AccountsMenu UI_A = new UI_AccountsMenu();
					this.Hide();
					UI_A.ShowDialog();
				}
			}
			else
			{
				query= "select * from users  where username = '"+txtuser.Text+"' and pass = '"+txtpass.Text+"'";
				ds = fn.getData(query);
				if(ds.Tables[0].Rows.Count!=0)
				{
					String role = ds.Tables[0].Rows[0][1].ToString();
					if(role=="MA")
					{
						UI_AccountsMenu UI_A = new UI_AccountsMenu();
						this.Hide();
						UI_A.ShowDialog();
					}
					else if(role=="CA")
					{
						PassBookMenu PBM = new PassBookMenu();
						PBM.ShowDialog();
						this.Hide();

					}
				}
			}






		}

		private void txtpass_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnClear_Click(object sender, EventArgs e)
		{

		}

		private void lblErro_Click(object sender, EventArgs e)
		{

		}

		private void txtuser_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
