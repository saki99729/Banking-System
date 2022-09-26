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
	public partial class AccountDelete : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<AccountBranch> accbranch = new List<AccountBranch>();
		public AccountDelete()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;

		}
		private void loadData()
		{
			accbranch.Clear();
			datedelete.DataSource = null;
			AccountBranch accnt = new AccountBranch();
			accnt.username = txtsearch.Text;
			accbranch.AddRange(accnt.veiwAccount());


			datedelete.DataSource = accbranch;
		}

		private void deletAc()
		{
			AccountBranch bankaccount = new AccountBranch();
			int check = bankaccount.AcDeleteAccount(txtsearch.Text);
			if (check == 1)
			{
				MessageBox.Show("Bank Account Deleted", "Successful");
			}
			else
			{
				MessageBox.Show("Account Not Found", "Error");
			}
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
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			 
		}

		private void txtdelete_Click(object sender, EventArgs e)
		{
			//if (checkvali())
			//{
			//	this.deletAc();
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (checkvali())
			{
				this.loadData();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (checkvali())
			{
				this.deletAc();
			}
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{

		}

		private void guna2CircleButton1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
