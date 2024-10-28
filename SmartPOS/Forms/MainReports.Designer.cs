namespace SmartPOS.Forms
{
	partial class MainReports
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
			this.button3 = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Image = global::SmartPOS.Properties.Resources.report01;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.Location = new System.Drawing.Point(12, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(142, 101);
			this.button3.TabIndex = 4;
			this.button3.Text = "Sale Reports";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Image = global::SmartPOS.Properties.Resources.exit;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(600, 549);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(142, 101);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// MainReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 662);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.button3);
			this.Name = "MainReports";
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.MainReports_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnExit;
	}
}