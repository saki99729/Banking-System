
namespace Banking_PL
{
	partial class veiwData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(veiwData));
			this.dtgridw = new System.Windows.Forms.DataGridView();
			this.btnveiw = new System.Windows.Forms.Button();
			this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgridw)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgridw
			// 
			this.dtgridw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgridw.Location = new System.Drawing.Point(12, 83);
			this.dtgridw.Name = "dtgridw";
			this.dtgridw.Size = new System.Drawing.Size(726, 209);
			this.dtgridw.TabIndex = 0;
			// 
			// btnveiw
			// 
			this.btnveiw.Location = new System.Drawing.Point(490, 298);
			this.btnveiw.Name = "btnveiw";
			this.btnveiw.Size = new System.Drawing.Size(248, 38);
			this.btnveiw.TabIndex = 1;
			this.btnveiw.Text = "Veiw";
			this.btnveiw.UseVisualStyleBackColor = true;
			this.btnveiw.Click += new System.EventHandler(this.btnveiw_Click);
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
			this.guna2CircleButton1.Location = new System.Drawing.Point(12, 12);
			this.guna2CircleButton1.Name = "guna2CircleButton1";
			this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
			this.guna2CircleButton1.Size = new System.Drawing.Size(40, 37);
			this.guna2CircleButton1.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(232, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 37);
			this.label1.TabIndex = 16;
			this.label1.Text = "View All Details";
			// 
			// veiwData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(763, 352);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2CircleButton1);
			this.Controls.Add(this.btnveiw);
			this.Controls.Add(this.dtgridw);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "veiwData";
			this.Text = "veiwData";
			((System.ComponentModel.ISupportInitialize)(this.dtgridw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgridw;
		private System.Windows.Forms.Button btnveiw;
		private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
		private System.Windows.Forms.Label label1;
	}
}