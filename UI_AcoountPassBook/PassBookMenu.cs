using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Banking_PL;

namespace UI_AcoountPassBook
{
	public partial class PassBookMenu : Form
	{
		public PassBookMenu()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AccountAdd add = new AccountAdd();
			add.Show();
			this.Hide();
		}
	}
}
