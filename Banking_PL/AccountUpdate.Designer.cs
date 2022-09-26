
namespace Banking_PL
{
	partial class AccountUpdate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountUpdate));
			this.label1 = new System.Windows.Forms.Label();
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.search = new System.Windows.Forms.DataGridView();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.txtname = new System.Windows.Forms.TextBox();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnupdate = new System.Windows.Forms.Button();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(502, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Enter User Name :";
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(684, 69);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 23);
			this.btnsearch.TabIndex = 7;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(599, 40);
			this.txtsearch.Multiline = true;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(160, 23);
			this.txtsearch.TabIndex = 6;
			// 
			// search
			// 
			this.search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.search.Location = new System.Drawing.Point(34, 102);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(725, 187);
			this.search.TabIndex = 5;
			// 
			// txtpassword
			// 
			this.txtpassword.Location = new System.Drawing.Point(106, 397);
			this.txtpassword.Multiline = true;
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(160, 23);
			this.txtpassword.TabIndex = 10;
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(320, 329);
			this.txtname.Multiline = true;
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(160, 23);
			this.txtname.TabIndex = 12;
			// 
			// cmbRole
			// 
			this.cmbRole.FormattingEnabled = true;
			this.cmbRole.Items.AddRange(new object[] {
            "MA",
            "CA"});
			this.cmbRole.Location = new System.Drawing.Point(106, 331);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(160, 21);
			this.cmbRole.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 310);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "userRole";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(299, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(53, 381);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "password";
			// 
			// btnupdate
			// 
			this.btnupdate.Location = new System.Drawing.Point(405, 441);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(75, 23);
			this.btnupdate.TabIndex = 18;
			this.btnupdate.Text = "update";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(3, 12);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 19;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// AccountUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 494);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbRole);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.txtpassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.search);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AccountUpdate";
			this.Text = "AccountUpdate";
			((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.DataGridView search;
		private System.Windows.Forms.TextBox txtpassword;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.ComboBox cmbRole;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnupdate;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
	}
}