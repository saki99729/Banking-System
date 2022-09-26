
namespace Banking_PL
{
	partial class updateData
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateData));
			this.gridsearch = new System.Windows.Forms.DataGridView();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.txtnic = new System.Windows.Forms.TextBox();
			this.txtlname = new System.Windows.Forms.TextBox();
			this.txtfname = new System.Windows.Forms.TextBox();
			this.searchbtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.btnupdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridsearch)).BeginInit();
			this.SuspendLayout();
			// 
			// gridsearch
			// 
			this.gridsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridsearch.Location = new System.Drawing.Point(48, 140);
			this.gridsearch.Name = "gridsearch";
			this.gridsearch.Size = new System.Drawing.Size(628, 150);
			this.gridsearch.TabIndex = 1;
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(223, 111);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(185, 20);
			this.txtsearch.TabIndex = 2;
			// 
			// txtnic
			// 
			this.txtnic.Location = new System.Drawing.Point(525, 330);
			this.txtnic.Name = "txtnic";
			this.txtnic.Size = new System.Drawing.Size(151, 20);
			this.txtnic.TabIndex = 3;
			// 
			// txtlname
			// 
			this.txtlname.Location = new System.Drawing.Point(299, 330);
			this.txtlname.Name = "txtlname";
			this.txtlname.Size = new System.Drawing.Size(164, 20);
			this.txtlname.TabIndex = 4;
			// 
			// txtfname
			// 
			this.txtfname.Location = new System.Drawing.Point(86, 330);
			this.txtfname.Name = "txtfname";
			this.txtfname.Size = new System.Drawing.Size(135, 20);
			this.txtfname.TabIndex = 5;
			// 
			// searchbtn
			// 
			this.searchbtn.Location = new System.Drawing.Point(444, 108);
			this.searchbtn.Name = "searchbtn";
			this.searchbtn.Size = new System.Drawing.Size(75, 23);
			this.searchbtn.TabIndex = 6;
			this.searchbtn.Text = "Search";
			this.searchbtn.UseVisualStyleBackColor = true;
			this.searchbtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 330);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "First Name :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(230, 330);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Last Name :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(488, 333);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "NIC :";
			// 
			// guna2CircleButton1
			// 
			this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
			this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
			this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
			this.guna2CircleButton1.ImageSize = new System.Drawing.Size(40, 40);
			this.guna2CircleButton1.Location = new System.Drawing.Point(12, 12);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 15;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click_1);
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(567, 383);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(109, 33);
			this.btnupdate.TabIndex = 7;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
			// 
			// updateData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(738, 450);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.searchbtn);
			this.Controls.Add(this.txtfname);
			this.Controls.Add(this.txtlname);
			this.Controls.Add(this.txtnic);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.gridsearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "updateData";
			this.Text = "updateData";
			this.Load += new System.EventHandler(this.updateData_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridsearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridsearch;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.TextBox txtnic;
		private System.Windows.Forms.TextBox txtlname;
		private System.Windows.Forms.TextBox txtfname;
		private System.Windows.Forms.Button searchbtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private System.Windows.Forms.Button btnupdate;
	}
}