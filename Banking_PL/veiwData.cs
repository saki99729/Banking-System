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
	public partial class veiwData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook>();
		public veiwData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		private void loadAccounts()
		{
			accbranch.Clear();
			dtgridw.DataSource = null;
			accbranch.AddRange(PassBook.getAccount());

			dtgridw.DataSource = accbranch;
			MessageBox.Show("found deatails...");

		}
		private void btnveiw_Click(object sender, EventArgs e)
		{
			this.loadAccounts();
		}

		private void btnclear_Click(object sender, EventArgs e)
		{
			
		}
	}
}
