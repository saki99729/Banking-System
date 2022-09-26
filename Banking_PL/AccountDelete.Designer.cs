
namespace Banking_PL
{
	partial class AccountDelete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDelete));
			this.datedelete = new System.Windows.Forms.DataGridView();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.datedelete)).BeginInit();
			this.SuspendLayout();
			// 
			// datedelete
			// 
			this.datedelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datedelete.Location = new System.Drawing.Point(30, 115);
			this.datedelete.Name = "datedelete";
			this.datedelete.Size = new System.Drawing.Size(682, 171);
			this.datedelete.TabIndex = 0;
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(121, 74);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(191, 20);
			this.txtsearch.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(331, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Enter User Name :";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(637, 302);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(1, 0);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 20;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click_1);
			// 
			// AccountDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 361);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.datedelete);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AccountDelete";
			this.Text = "AccountDelete";
			((System.ComponentModel.ISupportInitialize)(this.datedelete)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView datedelete;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
	}
}