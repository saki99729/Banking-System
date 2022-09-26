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
	public partial class searchData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public searchData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}

		private void loaddata()
		{
			accbranch.Clear();
			gddr.DataSource = null;
			PassBook getOneAccount = new PassBook();
			getOneAccount.Acc_ID = Convert.ToInt32(txtseach.Text);
			accbranch.AddRange(getOneAccount.veiwAccount());
		gddr.DataSource = accbranch;
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			this.loaddata(); 
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
