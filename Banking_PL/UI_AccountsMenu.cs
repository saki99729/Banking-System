using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_PL
{
	public partial class UI_AccountsMenu : Form
	{
		public UI_AccountsMenu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			AccountAdd acADD = new AccountAdd();
			acADD.Show();
			this.Hide();

		}

		private void UI_AccountsMenu_Load(object sender, EventArgs e)
		{
			label3.Text = DateTime.Now.ToLongTimeString();
		}

		private void btnveiwAc_Click(object sender, EventArgs e)
		{
			AccountVeiw acveiw = new AccountVeiw();
			acveiw.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Accountsearch Asearch = new Accountsearch();
			Asearch.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AccountUpdate upt = new AccountUpdate();
			upt.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			login lg = new login();
			lg.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			AccountDelete dlt = new AccountDelete();
			this.Hide();
			dlt.Show();
				

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			addData ad = new addData();
			ad.Show();
			this.Hide();

		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			veiwData vd = new veiwData();
			vd.Show();
			this.Hide();

		}

		private void button7_Click(object sender, EventArgs e)
		{
			searchData sd = new searchData();
			sd.Show();
			this.Hide();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			updateData updata = new updateData();
			updata.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{ 
			deleteData dD = new deleteData();
			dD.Show();
			this.Hide();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			depositData dipdata = new depositData();
			dipdata.Show();
			this.Hide();

		}

		private void button13_Click(object sender, EventArgs e)
		{
			withrawData wd = new withrawData();
			wd.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
