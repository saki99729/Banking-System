
namespace Banking_PL
{
	partial class cashier
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gddr = new System.Windows.Forms.DataGridView();
			this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnseatch = new Guna.UI2.WinForms.Guna2Button();
			this.btnwithdraw = new Guna.UI2.WinForms.Guna2Button();
			this.txtwithdraw = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.btndeposit = new Guna.UI2.WinForms.Guna2Button();
			this.txtdeposit = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gddr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.guna2Button2);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1341, 120);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(0, 120);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1342, 45);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(559, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(606, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// gddr
			// 
			this.gddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gddr.Location = new System.Drawing.Point(150, 296);
			this.gddr.Name = "gddr";
			this.gddr.Size = new System.Drawing.Size(1036, 191);
			this.gddr.TabIndex = 2;
			// 
			// txtsearch
			// 
			this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtsearch.DefaultText = "";
			this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsearch.DisabledState.Parent = this.txtsearch;
			this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsearch.FocusedState.Parent = this.txtsearch;
			this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtsearch.HoverState.Parent = this.txtsearch;
			this.txtsearch.Location = new System.Drawing.Point(475, 240);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.PasswordChar = '\0';
			this.txtsearch.PlaceholderText = "Search";
			this.txtsearch.SelectedText = "";
			this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
			this.txtsearch.Size = new System.Drawing.Size(267, 36);
			this.txtsearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtsearch.TabIndex = 3;
			// 
			// btnseatch
			// 
			this.btnseatch.BorderRadius = 21;
			this.btnseatch.CheckedState.Parent = this.btnseatch;
			this.btnseatch.CustomImages.Parent = this.btnseatch;
			this.btnseatch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnseatch.ForeColor = System.Drawing.Color.White;
			this.btnseatch.HoverState.Parent = this.btnseatch;
			this.btnseatch.Location = new System.Drawing.Point(760, 229);
			this.btnseatch.Name = "btnseatch";
			this.btnseatch.ShadowDecoration.Parent = this.btnseatch;
			this.btnseatch.Size = new System.Drawing.Size(180, 47);
			this.btnseatch.TabIndex = 4;
			this.btnseatch.Text = "Search ";
			this.btnseatch.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// btnwithdraw
			// 
			this.btnwithdraw.BorderRadius = 21;
			this.btnwithdraw.CheckedState.Parent = this.btnwithdraw;
			this.btnwithdraw.CustomImages.Parent = this.btnwithdraw;
			this.btnwithdraw.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnwithdraw.ForeColor = System.Drawing.Color.White;
			this.btnwithdraw.HoverState.Parent = this.btnwithdraw;
			this.btnwithdraw.Location = new System.Drawing.Point(434, 678);
			this.btnwithdraw.Name = "btnwithdraw";
			this.btnwithdraw.ShadowDecoration.Parent = this.btnwithdraw;
			this.btnwithdraw.Size = new System.Drawing.Size(180, 45);
			this.btnwithdraw.TabIndex = 6;
			this.btnwithdraw.Text = "Withdraw";
			this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
			// 
			// txtwithdraw
			// 
			this.txtwithdraw.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtwithdraw.DefaultText = "";
			this.txtwithdraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtwithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtwithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtwithdraw.DisabledState.Parent = this.txtwithdraw;
			this.txtwithdraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtwithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtwithdraw.FocusedState.Parent = this.txtwithdraw;
			this.txtwithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtwithdraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtwithdraw.HoverState.Parent = this.txtwithdraw;
			this.txtwithdraw.Location = new System.Drawing.Point(150, 611);
			this.txtwithdraw.Name = "txtwithdraw";
			this.txtwithdraw.PasswordChar = '\0';
			this.txtwithdraw.PlaceholderText = "Withdraw Money";
			this.txtwithdraw.SelectedText = "";
			this.txtwithdraw.ShadowDecoration.Parent = this.txtwithdraw;
			this.txtwithdraw.Size = new System.Drawing.Size(464, 31);
			this.txtwithdraw.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtwithdraw.TabIndex = 5;
			// 
			// guna2Button5
			// 
			this.guna2Button5.BorderRadius = 21;
			this.guna2Button5.CheckedState.Parent = this.guna2Button5;
			this.guna2Button5.CustomImages.Parent = this.guna2Button5;
			this.guna2Button5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.HoverState.Parent = this.guna2Button5;
			this.guna2Button5.Location = new System.Drawing.Point(806, 512);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
			this.guna2Button5.Size = new System.Drawing.Size(380, 45);
			this.guna2Button5.TabIndex = 10;
			this.guna2Button5.Text = "View All";
			this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
			// 
			// btndeposit
			// 
			this.btndeposit.BorderRadius = 21;
			this.btndeposit.CheckedState.Parent = this.btndeposit;
			this.btndeposit.CustomImages.Parent = this.btndeposit;
			this.btndeposit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndeposit.ForeColor = System.Drawing.Color.White;
			this.btndeposit.HoverState.Parent = this.btndeposit;
			this.btndeposit.Location = new System.Drawing.Point(1006, 678);
			this.btndeposit.Name = "btndeposit";
			this.btndeposit.ShadowDecoration.Parent = this.btndeposit;
			this.btndeposit.Size = new System.Drawing.Size(180, 45);
			this.btndeposit.TabIndex = 12;
			this.btndeposit.Text = "Deposit";
			this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
			// 
			// txtdeposit
			// 
			this.txtdeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtdeposit.DefaultText = "";
			this.txtdeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtdeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtdeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtdeposit.DisabledState.Parent = this.txtdeposit;
			this.txtdeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtdeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtdeposit.FocusedState.Parent = this.txtdeposit;
			this.txtdeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtdeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtdeposit.HoverState.Parent = this.txtdeposit;
			this.txtdeposit.Location = new System.Drawing.Point(715, 606);
			this.txtdeposit.Name = "txtdeposit";
			this.txtdeposit.PasswordChar = '\0';
			this.txtdeposit.PlaceholderText = "Deposit Money";
			this.txtdeposit.SelectedText = "";
			this.txtdeposit.ShadowDecoration.Parent = this.txtdeposit;
			this.txtdeposit.Size = new System.Drawing.Size(471, 36);
			this.txtdeposit.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtdeposit.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(605, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(430, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(382, 75);
			this.label4.TabIndex = 10;
			this.label4.Text = "City Bank.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(98, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(152, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
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
			this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
			this.guna2Button1.Location = new System.Drawing.Point(1284, 6);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new System.Drawing.Size(44, 54);
			this.guna2Button1.TabIndex = 12;
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
			// 
			// guna2Button2
			// 
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
			this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
			this.guna2Button2.Location = new System.Drawing.Point(1210, 12);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new System.Drawing.Size(54, 38);
			this.guna2Button2.TabIndex = 13;
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
			// 
			// cashier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1341, 808);
			this.Controls.Add(this.btndeposit);
			this.Controls.Add(this.txtdeposit);
			this.Controls.Add(this.guna2Button5);
			this.Controls.Add(this.btnwithdraw);
			this.Controls.Add(this.txtwithdraw);
			this.Controls.Add(this.btnseatch);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.gddr);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "cashier";
			this.Text = "cashier";
			this.Load += new System.EventHandler(this.cashier_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gddr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gddr;
		private Guna.UI2.WinForms.Guna2TextBox txtsearch;
		private Guna.UI2.WinForms.Guna2Button btnseatch;
		private Guna.UI2.WinForms.Guna2Button btnwithdraw;
		private Guna.UI2.WinForms.Guna2TextBox txtwithdraw;
		private Guna.UI2.WinForms.Guna2Button guna2Button5;
		private Guna.UI2.WinForms.Guna2Button btndeposit;
		private Guna.UI2.WinForms.Guna2TextBox txtdeposit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}