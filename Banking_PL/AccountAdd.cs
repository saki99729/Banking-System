using Bank_DL;
using Bank_BL;
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
	public partial class AccountAdd : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<AccountBranch> accbranch = new List<AccountBranch>();
		public AccountAdd()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void addData()
		{
			AccountBranch accBrnch = new AccountBranch();
			accBrnch.userRole = cmbuser.Text;
			accBrnch.name = txtname.Text;
			accBrnch.username = txtusername.Text;
			accBrnch.password = txtpass.Text;
			accbranch.Add(accBrnch);
			accBrnch.AddTo();
			MessageBox.Show("sucsessfull adding...");

		}


		private void Account_Add_Load(object sender, EventArgs e)
		{

		}

		private void btnCreat_Click(object sender, EventArgs e)
		{
			this.addData();
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
