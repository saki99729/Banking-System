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
	public partial class depositData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public depositData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void loadSelectBankAccount()
		{
			accbranch.Clear();
			gddr.DataSource = null;
			PassBook getOneAccount = new PassBook();
			getOneAccount.Acc_ID = Convert.ToInt32(txtsearch.Text);
			accbranch.AddRange(getOneAccount.veiwAccount());
		gddr.DataSource = accbranch;
		}


		private void deposit()
		{
			double oldsalary, newsalary,newonesalary;
			PassBook accnt = new PassBook();
			accnt.Acc_ID = Convert.ToInt32(txtsearch.Text);
			if (gddr.SelectedCells.Count > 0)
			{
				int selectrows = gddr.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRows = gddr.Rows[selectrows];
				oldsalary = Convert.ToDouble(selectedRows.Cells["salary"].Value);
				newsalary = Convert.ToDouble(txtdeposit.Text);
				newonesalary = oldsalary + newsalary;
				accnt.salary =newonesalary;
				accnt.deposit();
				
				MessageBox.Show("succussfull.............");

			}
		}

		private void clear()
		{
			txtdeposit.Clear();
			txtsearch.Clear();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.loadSelectBankAccount();
		}

		private void btndeposit_Click(object sender, EventArgs e)
		{
			this.deposit();
			this.loadSelectBankAccount();
			this.clear();
			
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
