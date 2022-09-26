
namespace Banking_PL
{
	partial class AccountAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountAdd));
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtusername = new System.Windows.Forms.TextBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.cmbuser = new System.Windows.Forms.ComboBox();
			this.btnCreat = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(2, 0);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 15;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(208, 182);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(148, 20);
			this.txtname.TabIndex = 0;
			// 
			// txtusername
			// 
			this.txtusername.Location = new System.Drawing.Point(208, 244);
			this.txtusername.Name = "txtusername";
			this.txtusername.Size = new System.Drawing.Size(148, 20);
			this.txtusername.TabIndex = 1;
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(208, 301);
			this.txtpass.Name = "txtpass";
			this.txtpass.Size = new System.Drawing.Size(148, 20);
			this.txtpass.TabIndex = 2;
			// 
			// cmbuser
			// 
			this.cmbuser.FormattingEnabled = true;
			this.cmbuser.Items.AddRange(new object[] {
            "MA",
            "CA"});
			this.cmbuser.Location = new System.Drawing.Point(208, 116);
			this.cmbuser.Name = "cmbuser";
			this.cmbuser.Size = new System.Drawing.Size(148, 21);
			this.cmbuser.TabIndex = 3;
			// 
			// btnCreat
			// 
			this.btnCreat.Location = new System.Drawing.Point(87, 364);
			this.btnCreat.Name = "btnCreat";
			this.btnCreat.Size = new System.Drawing.Size(254, 23);
			this.btnCreat.TabIndex = 4;
			this.btnCreat.Text = "Create";
			this.btnCreat.UseVisualStyleBackColor = true;
			this.btnCreat.Click += new System.EventHandler(this.btnCreat_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Job Role :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(84, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "name :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 251);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "User Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(84, 308);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Password :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(67, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(319, 34);
			this.label5.TabIndex = 9;
			this.label5.Text = "User Account Create";
			// 
			// AccountAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(446, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbuser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtusername);
			this.Controls.Add(this.btnCreat);
			this.Controls.Add(this.txtpass);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AccountAdd";
			this.Text = "Account_Add";
			this.Load += new System.EventHandler(this.Account_Add_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.TextBox txtusername;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.ComboBox cmbuser;
		private System.Windows.Forms.Button btnCreat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}