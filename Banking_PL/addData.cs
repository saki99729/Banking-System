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
	public partial class addData : Form
	{
		public static string cnstring = ConfigurationManager.ConnectionStrings["Banking_PL.Properties.Settings.bank12ConnectionString"].ConnectionString;
		List<PassBook> accbranch = new List<PassBook >();
		public addData()
		{
			InitializeComponent();
			DbHelper.ConnectionString = cnstring;
		}
		
		private void adData()
		{
			PassBook ps = new PassBook(txtfname.Text,txtlname.Text,txtnic.Text,txtdate.Value,txtgender.Text);
			ps.salary = Convert.ToDouble(txtsalary.Text);
			accbranch.Add(ps);
			ps.AddToPass();

		}
		private void addData_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.adData();
			MessageBox.Show("sucsessfull adding...");
		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UI_AccountsMenu uia = new UI_AccountsMenu();
			uia.Show();
		}
	}
}
