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
	public partial class withrawData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public withrawData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void load()
		{
			accbranch.Clear();
			gddr.DataSource = null;
			PassBook getOneAccount = new PassBook();
			getOneAccount.Acc_ID = Convert.ToInt32(txtsearch.Text);
			accbranch.AddRange(getOneAccount.veiwAccount());
			gddr.DataSource = accbranch;
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
				newsalary = Convert.ToDouble(txtwithraw.Text);
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
		private void btnsearch_Click(object sender, EventArgs e)
		{
			load();
		}

		private void btnwithdraw_Click(object sender, EventArgs e)
		{
			withdraw();
			load();
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
