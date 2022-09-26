
namespace Banking_PL
{
	partial class Accountsearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountsearch));
			this.search = new System.Windows.Forms.DataGridView();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.btnsearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
			this.SuspendLayout();
			// 
			// search
			// 
			this.search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.search.Location = new System.Drawing.Point(59, 165);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(603, 171);
			this.search.TabIndex = 0;
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(209, 91);
			this.txtsearch.Multiline = true;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(160, 23);
			this.txtsearch.TabIndex = 1;
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(294, 120);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 23);
			this.btnsearch.TabIndex = 2;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter User Name :";
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(1, 1);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 15;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// Accountsearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(700, 367);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.search);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Accountsearch";
			this.Text = "Accountsearch";
			((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView search;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
	}
}