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
	public partial class cashier : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public cashier()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void loadAccounts()
		{
			accbranch.Clear();
			gddr.DataSource = null;
			accbranch.AddRange(PassBook.getAccount());

			gddr.DataSource = accbranch;
			MessageBox.Show("found deatails...");

		}

		private void loaddata()
		{
			accbranch.Clear();
			gddr.DataSource = null;
			PassBook getOneAccount = new PassBook();
			getOneAccount.Acc_ID = Convert.ToInt32(txtsearch.Text);
			accbranch.AddRange(getOneAccount.veiwAccount());
			gddr.DataSource = accbranch;
		}


		//private void loadSelectBankAccount()
		//{
		//	accbranch.Clear();
		//	gddr.DataSource = null;
		//	PassBook getOneAccount = new PassBook();
		//	getOneAccount.Acc_ID = Convert.ToInt32(txtsearch.Text);
		//	accbranch.AddRange(getOneAccount.veiwAccount());
		//	gddr.DataSource = accbranch;
		//}

		private void deposit()
		{
			double oldsalary, newsalary, newonesalary;
			PassBook accnt = new PassBook();
			accnt.Acc_ID = Convert.ToInt32(txtsearch.Text);
			if (gddr.SelectedCells.Count > 0)
			{
				int selectrows = gddr.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRows = gddr.Rows[selectrows];
				oldsalary = Convert.ToDouble(selectedRows.Cells["salary"].Value);
				newsalary = Convert.ToDouble(txtdeposit.Text);
				newonesalary = oldsalary + newsalary;
				accnt.salary = newonesalary;
				accnt.deposit();

				MessageBox.Show("succussfull.............");

			}



		}


		private void withdraw()
		{
			double oldsalary, newsalary, newonesalary;
			PassBook accnt = new PassBook();
			accnt.Acc_ID = Convert.ToInt32(txtsearch.Text);
			if (gddr.SelectedCells.Count > 0)
			{

				int selectrows = gddr.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRows = gddr.Rows[selectrows];
				oldsalary = Convert.ToDouble(selectedRows.Cells["salary"].Value);
				newsalary = Convert.ToDouble(txtwithdraw.Text);
				newonesalary = oldsalary - newsalary;


				if (oldsalary <= 0)
				{
					MessageBox.Show("insuffesent account balance");
				}
				else
				{


					accnt.salary = newonesalary;
					accnt.deposit();

					MessageBox.Show("succussfull.............");
				}
			}
		}
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			this.loadAccounts();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			loaddata();
		}

		private void btnwithdraw_Click(object sender, EventArgs e)
		{
			withdraw();
			loaddata();
		}

		private void btndeposit_Click(object sender, EventArgs e)
		{
			deposit();
			loaddata();
		}

		private void cashier_Load(object sender, EventArgs e)
		{
			label2.Text = DateTime.Now.ToLongTimeString();
		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			login lg = new login();
			this.Hide();
			lg.Show();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
