namespace SmartPOS
{
	partial class mainForm
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
			this.components = new System.ComponentModel.Container();
			this.PanelMenu = new System.Windows.Forms.Panel();
			this.btnOprtions = new System.Windows.Forms.Button();
			this.btnReporting = new System.Windows.Forms.Button();
			this.btnSetup = new System.Windows.Forms.Button();
			this.btnPOS = new System.Windows.Forms.Button();
			this.PanelLogo = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.PanelTitle = new System.Windows.Forms.Panel();
			this.LabelTimer = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.PanelMainForm = new System.Windows.Forms.Panel();
			this.PanelMenu.SuspendLayout();
			this.PanelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.PanelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelMenu
			// 
			this.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PanelMenu.Controls.Add(this.btnOprtions);
			this.PanelMenu.Controls.Add(this.btnReporting);
			this.PanelMenu.Controls.Add(this.btnSetup);
			this.PanelMenu.Controls.Add(this.btnPOS);
			this.PanelMenu.Controls.Add(this.PanelLogo);
			this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.PanelMenu.Location = new System.Drawing.Point(0, 0);
			this.PanelMenu.Name = "PanelMenu";
			this.PanelMenu.Size = new System.Drawing.Size(250, 953);
			this.PanelMenu.TabIndex = 0;
			// 
			// btnOprtions
			// 
			this.btnOprtions.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnOprtions.FlatAppearance.BorderSize = 0;
			this.btnOprtions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOprtions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnOprtions.Image = global::SmartPOS.Properties.Resources.gear;
			this.btnOprtions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOprtions.Location = new System.Drawing.Point(0, 417);
			this.btnOprtions.Name = "btnOprtions";
			this.btnOprtions.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnOprtions.Size = new System.Drawing.Size(250, 88);
			this.btnOprtions.TabIndex = 4;
			this.btnOprtions.Text = "Options";
			this.btnOprtions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOprtions.UseVisualStyleBackColor = true;
			this.btnOprtions.Click += new System.EventHandler(this.btnOprtions_Click);
			// 
			// btnReporting
			// 
			this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReporting.FlatAppearance.BorderSize = 0;
			this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReporting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnReporting.Image = global::SmartPOS.Properties.Resources.report2;
			this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReporting.Location = new System.Drawing.Point(0, 329);
			this.btnReporting.Name = "btnReporting";
			this.btnReporting.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnReporting.Size = new System.Drawing.Size(250, 88);
			this.btnReporting.TabIndex = 3;
			this.btnReporting.Text = "Reporting";
			this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReporting.UseVisualStyleBackColor = true;
			this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
			// 
			// btnSetup
			// 
			this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSetup.FlatAppearance.BorderSize = 0;
			this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSetup.Image = global::SmartPOS.Properties.Resources.settings;
			this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSetup.Location = new System.Drawing.Point(0, 241);
			this.btnSetup.Name = "btnSetup";
			this.btnSetup.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnSetup.Size = new System.Drawing.Size(250, 88);
			this.btnSetup.TabIndex = 2;
			this.btnSetup.Text = "Setup";
			this.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetup.UseVisualStyleBackColor = true;
			this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
			// 
			// btnPOS
			// 
			this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPOS.FlatAppearance.BorderSize = 0;
			this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPOS.Image = global::SmartPOS.Properties.Resources.shopping_cart;
			this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPOS.Location = new System.Drawing.Point(0, 153);
			this.btnPOS.Name = "btnPOS";
			this.btnPOS.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.btnPOS.Size = new System.Drawing.Size(250, 88);
			this.btnPOS.TabIndex = 1;
			this.btnPOS.Text = "Point of Sale";
			this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPOS.UseVisualStyleBackColor = true;
			this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
			// 
			// PanelLogo
			// 
			this.PanelLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.PanelLogo.Controls.Add(this.linkLabel1);
			this.PanelLogo.Controls.Add(this.label2);
			this.PanelLogo.Controls.Add(this.label1);
			this.PanelLogo.Controls.Add(this.pictureBox1);
			this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelLogo.Location = new System.Drawing.Point(0, 0);
			this.PanelLogo.Name = "PanelLogo";
			this.PanelLogo.Size = new System.Drawing.Size(250, 153);
			this.PanelLogo.TabIndex = 0;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.linkLabel1.Location = new System.Drawing.Point(118, 92);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(105, 22);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Caevenom";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(118, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "1.0.1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(118, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "SmartPOS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::SmartPOS.Properties.Resources.fast_food;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 105);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// PanelTitle
			// 
			this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PanelTitle.Controls.Add(this.LabelTimer);
			this.PanelTitle.Controls.Add(this.LabelTitle);
			this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelTitle.Location = new System.Drawing.Point(250, 0);
			this.PanelTitle.Name = "PanelTitle";
			this.PanelTitle.Size = new System.Drawing.Size(1118, 153);
			this.PanelTitle.TabIndex = 1;
			// 
			// LabelTimer
			// 
			this.LabelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelTimer.AutoSize = true;
			this.LabelTimer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTimer.Location = new System.Drawing.Point(800, 9);
			this.LabelTimer.Name = "LabelTimer";
			this.LabelTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.LabelTimer.Size = new System.Drawing.Size(84, 28);
			this.LabelTimer.TabIndex = 1;
			this.LabelTimer.Text = "label1";
			// 
			// LabelTitle
			// 
			this.LabelTitle.AutoSize = true;
			this.LabelTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTitle.Location = new System.Drawing.Point(6, 9);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(164, 28);
			this.LabelTitle.TabIndex = 0;
			this.LabelTitle.Text = "Point Of Sale";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// PanelMainForm
			// 
			this.PanelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelMainForm.Location = new System.Drawing.Point(250, 153);
			this.PanelMainForm.Name = "PanelMainForm";
			this.PanelMainForm.Size = new System.Drawing.Size(1118, 800);
			this.PanelMainForm.TabIndex = 2;
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1368, 953);
			this.Controls.Add(this.PanelMainForm);
			this.Controls.Add(this.PanelTitle);
			this.Controls.Add(this.PanelMenu);
			this.Name = "mainForm";
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.PanelMenu.ResumeLayout(false);
			this.PanelLogo.ResumeLayout(false);
			this.PanelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.PanelTitle.ResumeLayout(false);
			this.PanelTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelMenu;
		private System.Windows.Forms.Button btnPOS;
		private System.Windows.Forms.Panel PanelLogo;
		private System.Windows.Forms.Button btnOprtions;
		private System.Windows.Forms.Button btnReporting;
		private System.Windows.Forms.Button btnSetup;
		private System.Windows.Forms.Panel PanelTitle;
		private System.Windows.Forms.Label LabelTitle;
		public System.Windows.Forms.Label LabelTimer;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel PanelMainForm;
	}
}

