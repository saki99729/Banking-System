using Bank_BL;
using Bank_DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_PL
{
	
	public partial class deleteData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public deleteData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void loadData()
		{
			accbranch.Clear();
			datadelete.DataSource = null;
		 PassBook accnt = new PassBook();
			accnt.Acc_ID = Convert.ToInt32(txtsearch.Text);
			accbranch.AddRange(accnt.veiwAccount());


			datadelete.DataSource = accbranch;
		}

		private bool checkvali()
		{
			try
			{
				if (txtsearch.Text.Trim() == string.Empty)
				{
					MessageBox.Show("check the search box........ !", "Error");
					return false;
				}
				else
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				return false;
			}

		}


		private void deletAc()
		{
			PassBook bankaccount = new PassBook();
			int check = bankaccount.AcDeleteAccount(Convert.ToInt32(txtsearch.Text));
			if (check == 1)
			{
				MessageBox.Show(" Account Deleted", "Successful");
			}
			else
			{
				MessageBox.Show(" Not Found", "Error");
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{

			if (checkvali())
			{
				this.loadData();
			}


		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			if (checkvali())
			{
				this.deletAc();
			}
		}
	}
}
