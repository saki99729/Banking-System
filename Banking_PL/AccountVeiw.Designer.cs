
namespace Banking_PL
{
	partial class AccountVeiw
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountVeiw));
			this.dataVeiw = new System.Windows.Forms.DataGridView();
			this.btnVeiw = new System.Windows.Forms.Button();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataVeiw)).BeginInit();
			this.SuspendLayout();
			// 
			// dataVeiw
			// 
			this.dataVeiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataVeiw.Location = new System.Drawing.Point(12, 104);
			this.dataVeiw.Name = "dataVeiw";
			this.dataVeiw.Size = new System.Drawing.Size(662, 185);
			this.dataVeiw.TabIndex = 0;
			// 
			// btnVeiw
			// 
			this.btnVeiw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVeiw.Location = new System.Drawing.Point(518, 295);
			this.btnVeiw.Name = "btnVeiw";
			this.btnVeiw.Size = new System.Drawing.Size(156, 44);
			this.btnVeiw.TabIndex = 1;
			this.btnVeiw.Text = "veiw";
			this.btnVeiw.UseVisualStyleBackColor = true;
			this.btnVeiw.Click += new System.EventHandler(this.btnVeiw_Click);
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(0, 25);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 15;
			this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 42);
			this.label1.TabIndex = 16;
			this.label1.Text = "View All Details";
			// 
			// AccountVeiw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(707, 389);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.btnVeiw);
			this.Controls.Add(this.dataVeiw);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AccountVeiw";
			this.Text = "AccountVeiw";
			this.Load += new System.EventHandler(this.AccountVeiw_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataVeiw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataVeiw;
		private System.Windows.Forms.Button btnVeiw;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private System.Windows.Forms.Label label1;
	}
}