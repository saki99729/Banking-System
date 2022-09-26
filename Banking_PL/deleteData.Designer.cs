
namespace Banking_PL
{
	partial class deleteData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteData));
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.datadelete = new System.Windows.Forms.DataGridView();
			this.btnsearch = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.datadelete)).BeginInit();
			this.SuspendLayout();
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(52, 93);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(195, 20);
			this.txtsearch.TabIndex = 0;
			// 
			// datadelete
			// 
			this.datadelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datadelete.Location = new System.Drawing.Point(39, 136);
			this.datadelete.Name = "datadelete";
			this.datadelete.Size = new System.Drawing.Size(551, 150);
			this.datadelete.TabIndex = 1;
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(253, 90);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 23);
			this.btnsearch.TabIndex = 2;
			this.btnsearch.Text = "search";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.button1_Click);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(528, 308);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 3;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(1, 25);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 14;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// deleteData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(625, 370);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.datadelete);
			this.Controls.Add(this.txtsearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "deleteData";
			this.Text = "deleteData";
			((System.ComponentModel.ISupportInitialize)(this.datadelete)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.DataGridView datadelete;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.Button btndelete;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
	}
}