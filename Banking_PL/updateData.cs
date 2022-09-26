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
	public partial class updateData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public updateData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void loadSelectBankAccount()
		{
			
			
				accbranch.Clear();
				gridsearch.DataSource = null;
				PassBook getOneAccount = new PassBook();
				getOneAccount.Acc_ID = Convert.ToInt32(txtsearch.Text);
				accbranch.AddRange(getOneAccount.veiwAccount());
				gridsearch.DataSource = accbranch;
			
		}
		private void updateBankAccount()
		{
			PassBook myaccnt = new PassBook();
			myaccnt.up(txtfname.Text, txtlname.Text, txtnic.Text);
			myaccnt.Acupdate(Convert.ToInt32(txtsearch.Text));

		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.loadSelectBankAccount();
		}

		private void updateData_Load(object sender, EventArgs e)
		{

		}

		private void btnupdate_Click(object sender, EventArgs e)
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

		private void guna2CircleButton1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
