﻿namespace SmartPOS.Forms
{
	partial class MainSetup
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
			this.btnExit = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Image = global::SmartPOS.Properties.Resources.exit;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.Location = new System.Drawing.Point(600, 549);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(142, 101);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// button4
			// 
			this.button4.Image = global::SmartPOS.Properties.Resources.maintenance;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button4.Location = new System.Drawing.Point(12, 140);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 112);
			this.button4.TabIndex = 4;
			this.button4.Text = "Categories";
			this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Image = global::SmartPOS.Properties.Resources.online_payment;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.Location = new System.Drawing.Point(12, 268);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 112);
			this.button3.TabIndex = 3;
			this.button3.Text = "Payments";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Image = global::SmartPOS.Properties.Resources.food_delivery;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new System.Drawing.Point(171, 140);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(143, 112);
			this.button2.TabIndex = 2;
			this.button2.Text = "Items";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Image = global::SmartPOS.Properties.Resources.man;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 112);
			this.button1.TabIndex = 1;
			this.button1.Text = "Users";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 662);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainSetup";
			this.Text = "Setup";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnExit;
	}
}