
namespace Banking_PL
{
	partial class withrawData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withrawData));
			this.btnwithdraw = new System.Windows.Forms.Button();
			this.txtwithraw = new System.Windows.Forms.TextBox();
			this.gddr = new System.Windows.Forms.DataGridView();
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			((System.ComponentModel.ISupportInitialize)(this.gddr)).BeginInit();
			this.SuspendLayout();
			// 
			// btnwithdraw
			// 
			this.btnwithdraw.Location = new System.Drawing.Point(374, 297);
			this.btnwithdraw.Name = "btnwithdraw";
			this.btnwithdraw.Size = new System.Drawing.Size(75, 23);
			this.btnwithdraw.TabIndex = 9;
			this.btnwithdraw.Text = "Withdraw";
			this.btnwithdraw.UseVisualStyleBackColor = true;
			this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
			// 
			// txtwithraw
			// 
			this.txtwithraw.Location = new System.Drawing.Point(159, 297);
			this.txtwithraw.Name = "txtwithraw";
			this.txtwithraw.Size = new System.Drawing.Size(197, 20);
			this.txtwithraw.TabIndex = 8;
			// 
			// gddr
			// 
			this.gddr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gddr.Location = new System.Drawing.Point(3, 130);
			this.gddr.Name = "gddr";
			this.gddr.Size = new System.Drawing.Size(589, 150);
			this.gddr.TabIndex = 7;
			// 
			// btnsearch
			// 
			this.btnsearch.Location = new System.Drawing.Point(374, 101);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 23);
			this.btnsearch.TabIndex = 6;
			this.btnsearch.Text = "Search";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(159, 101);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(209, 20);
			this.txtsearch.TabIndex = 5;
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(3, 0);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 19;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// withrawData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(604, 357);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.btnwithdraw);
			this.Controls.Add(this.txtwithraw);
			this.Controls.Add(this.gddr);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.txtsearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "withrawData";
			this.Text = "withrawData";
			((System.ComponentModel.ISupportInitialize)(this.gddr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnwithdraw;
		private System.Windows.Forms.TextBox txtwithraw;
		private System.Windows.Forms.DataGridView gddr;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.TextBox txtsearch;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
	}
}