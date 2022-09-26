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
	public partial class AccountVeiw : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<AccountBranch> accbranch = new List<AccountBranch>();
		public AccountVeiw()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void loadAccounts()
		{
			accbranch.Clear();
			dataVeiw.DataSource = null;
		accbranch.AddRange(AccountBranch.getAccount());

			dataVeiw.DataSource = accbranch;
			MessageBox.Show("found deatails...");

		}
		private void btnVeiw_Click(object sender, EventArgs e)
		{
			this.loadAccounts();
		}

		private void AccountVeiw_Load(object sender, EventArgs e)
		{

		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
