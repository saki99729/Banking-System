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
	public partial class AccountUpdate : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<AccountBranch> accbranch = new List<AccountBranch>();
		public AccountUpdate()
		{ 
			InitializeComponent();
		DbHelper.ConnectionString = cnstring;
		
		}
		private void loadSelectBankAccount()
		{
			accbranch.Clear();
			search.DataSource = null;
			AccountBranch getOneAccount = new AccountBranch();
			getOneAccount.username = txtsearch.Text;
			accbranch.AddRange(getOneAccount.veiwAccount());
			search.DataSource = accbranch;
		}


		private void updateBankAccount()
		{
			AccountBranch myaccnt = new AccountBranch();
			myaccnt.udate(cmbRole.Text, txtname.Text,txtpassword.Text);
			myaccnt.Acupdate(txtsearch.Text);
		}
		private void btnsearch_Click(object sender, EventArgs e)
		{
			this.loadSelectBankAccount();
		}

		private void btnupdate_Click(object sender, EventArgs e)
		{
			//this.updateBankAccount();
		}

		private void btnupdate_Click_1(object sender, EventArgs e)
		{
			this.updateBankAccount();
			this.loadSelectBankAccount();
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
