
namespace banking
{
	partial class login
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
			this.txtuser = new System.Windows.Forms.TextBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.btnlog = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblErro = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(58, 107);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(168, 20);
			this.txtuser.TabIndex = 0;
			this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(58, 195);
			this.txtpass.Name = "txtpass";
			this.txtpass.Size = new System.Drawing.Size(168, 20);
			this.txtpass.TabIndex = 1;
			this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
			// 
			// btnlog
			// 
			this.btnlog.Location = new System.Drawing.Point(58, 267);
			this.btnlog.Name = "btnlog";
			this.btnlog.Size = new System.Drawing.Size(75, 23);
			this.btnlog.TabIndex = 2;
			this.btnlog.Text = "button1";
			this.btnlog.UseVisualStyleBackColor = true;
			this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(151, 267);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "button1";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.Location = new System.Drawing.Point(55, 326);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(0, 13);
			this.lblErro.TabIndex = 4;
			this.lblErro.Click += new System.EventHandler(this.lblErro_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblErro);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnlog);
			this.panel1.Controls.Add(this.txtpass);
			this.panel1.Controls.Add(this.txtuser);
			this.panel1.Location = new System.Drawing.Point(344, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 446);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "PassWord :";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "UserName :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 443);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "login";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.Button btnlog;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblErro;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

