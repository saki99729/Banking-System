
namespace Banking_PL
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.lblErro = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnlog = new System.Windows.Forms.Button();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.lblerr = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.Location = new System.Drawing.Point(55, 326);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(0, 13);
			this.lblErro.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(151, 267);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Reset";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnlog
			// 
			this.btnlog.Location = new System.Drawing.Point(58, 267);
			this.btnlog.Name = "btnlog";
			this.btnlog.Size = new System.Drawing.Size(75, 23);
			this.btnlog.TabIndex = 2;
			this.btnlog.Text = "Login";
			this.btnlog.UseVisualStyleBackColor = true;
			this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(58, 195);
			this.txtpass.Name = "txtpass";
			this.txtpass.Size = new System.Drawing.Size(168, 20);
			this.txtpass.TabIndex = 1;
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(58, 134);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(168, 20);
			this.txtuser.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.lblerr);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblErro);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnlog);
			this.panel1.Controls.Add(this.txtpass);
			this.panel1.Controls.Add(this.txtuser);
			this.panel1.Location = new System.Drawing.Point(328, -21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 426);
			this.panel1.TabIndex = 6;
			// 
			// guna2Button1
			// 
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.Location = new System.Drawing.Point(230, 33);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(34, 30);
			this.guna2Button1.TabIndex = 8;
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// lblerr
			// 
			this.lblerr.AutoSize = true;
			this.lblerr.ForeColor = System.Drawing.Color.DarkRed;
			this.lblerr.Location = new System.Drawing.Point(42, 339);
			this.lblerr.Name = "lblerr";
			this.lblerr.Size = new System.Drawing.Size(0, 13);
			this.lblerr.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "PassWord :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "UserName :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(28, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(268, 208);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(40, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 43);
			this.label1.TabIndex = 8;
			this.label1.Text = "City Bank ";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 404);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "login";
			this.Text = "login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblErro;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnlog;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblerr;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private System.Windows.Forms.Label label1;
	}
}