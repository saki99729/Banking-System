using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_PL
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
			if (ds.Tables[0].Rows.Count == 0)
			{
				if (txtuser.Text == "Root" && txtpass.Text == "Root")
				{
					UI_AccountsMenu UI_A = new UI_AccountsMenu();
					this.Hide();
					UI_A.ShowDialog();
				}
			}
			else
			{
				query = "select * from users  where username = '" + txtuser.Text + "' and pass = '" + txtpass.Text + "'";
				ds = fn.getData(query);
				if (ds.Tables[0].Rows.Count != 0)
				{
					String role = ds.Tables[0].Rows[0][1].ToString();
					if (role == "MA")
					{
						UI_AccountsMenu UI_A = new UI_AccountsMenu();
						this.Hide();
						UI_A.ShowDialog();
					}
					else if (role == "CA")
					{
						this.Hide(); ;
						cashier cs = new cashier();
						cs.Show();

					}
					
				}
				else
				{
					lblerr.Text = "*Check Username Or Password";
					//MessageBox.Show("check username or password", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtuser.Clear();
					txtpass.Clear();
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtuser.Clear();
			txtpass.Clear();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
