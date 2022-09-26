
namespace Banking_PL
{
	partial class searchData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchData));
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtseach = new System.Windows.Forms.TextBox();
			this.gddr = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gddr)).BeginInit();
			this.SuspendLayout();
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(320, 145);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 23);
			this.btnsearch.TabIndex = 0;
			this.btnsearch.Text = "button1";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// txtseach
			// 
			this.txtseach.Location = new System.Drawing.Point(213, 111);
			this.txtseach.Name = "txtseach";
			this.txtseach.Size = new System.Drawing.Size(182, 20);
			this.txtseach.TabIndex = 1;
			// 
			// gddr
			// 
			this.gddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gddr.Location = new System.Drawing.Point(12, 178);
			this.gddr.Name = "gddr";
			this.gddr.Size = new System.Drawing.Size(594, 150);
			this.gddr.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Enter Account ID:";
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(12, 34);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 15;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(149, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 29);
			this.label2.TabIndex = 16;
			this.label2.Text = "Search Pass Book Details";
			// 
			// searchData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(637, 359);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gddr);
			this.Controls.Add(this.txtseach);
			this.Controls.Add(this.btnsearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "searchData";
			this.Text = "searchData";
			((System.ComponentModel.ISupportInitialize)(this.gddr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.TextBox txtseach;
		private System.Windows.Forms.DataGridView gddr;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private System.Windows.Forms.Label label2;
	}
}