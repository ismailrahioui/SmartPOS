namespace SmartPOS.Forms
{
	partial class FormUsers
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSelect = new System.Windows.Forms.ToolStripButton();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnFirst = new System.Windows.Forms.ToolStripButton();
			this.btnPrevious = new System.Windows.Forms.ToolStripButton();
			this.btnNext = new System.Windows.Forms.ToolStripButton();
			this.btnLast = new System.Windows.Forms.ToolStripButton();
			this.btnExit = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TextPhone = new System.Windows.Forms.TextBox();
			this.TextEmail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.TextFullName = new System.Windows.Forms.TextBox();
			this.TextPassword = new System.Windows.Forms.TextBox();
			this.TextUserName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TextJobDes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelect,
            this.toolStripSeparator1,
            this.btnNew,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnFirst,
            this.btnPrevious,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator3,
            this.btnExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(839, 73);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 73);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 73);
			// 
			// btnSelect
			// 
			this.btnSelect.Image = global::SmartPOS.Properties.Resources.frequency;
			this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(53, 70);
			this.btnSelect.Text = "Select";
			this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnNew
			// 
			this.btnNew.Image = global::SmartPOS.Properties.Resources.add_file;
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(50, 70);
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = global::SmartPOS.Properties.Resources.floppy_disk2;
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 70);
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Image = global::SmartPOS.Properties.Resources.previous;
			this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(50, 70);
			this.btnFirst.Text = "First";
			this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Image = global::SmartPOS.Properties.Resources.back;
			this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(68, 70);
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnNext
			// 
			this.btnNext.Image = global::SmartPOS.Properties.Resources.play;
			this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(50, 70);
			this.btnNext.Text = "Next";
			this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnLast
			// 
			this.btnLast.Image = global::SmartPOS.Properties.Resources.next;
			this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(50, 70);
			this.btnLast.Text = "Last";
			this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnExit
			// 
			this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnExit.Image = global::SmartPOS.Properties.Resources.log_out2;
			this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(50, 70);
			this.btnExit.Text = "Exit";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.TextJobDes);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.TextPhone);
			this.panel1.Controls.Add(this.TextEmail);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.TextFullName);
			this.panel1.Controls.Add(this.TextPassword);
			this.panel1.Controls.Add(this.TextUserName);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 350);
			this.panel1.TabIndex = 1;
			// 
			// TextPhone
			// 
			this.TextPhone.Location = new System.Drawing.Point(209, 190);
			this.TextPhone.Name = "TextPhone";
			this.TextPhone.Size = new System.Drawing.Size(263, 22);
			this.TextPhone.TabIndex = 43;
			// 
			// TextEmail
			// 
			this.TextEmail.Location = new System.Drawing.Point(209, 147);
			this.TextEmail.Name = "TextEmail";
			this.TextEmail.Size = new System.Drawing.Size(263, 22);
			this.TextEmail.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 24);
			this.label6.TabIndex = 41;
			this.label6.Text = "Phone";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 150);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 24);
			this.label7.TabIndex = 40;
			this.label7.Text = "Email";
			// 
			// TextFullName
			// 
			this.TextFullName.Location = new System.Drawing.Point(209, 108);
			this.TextFullName.Name = "TextFullName";
			this.TextFullName.Size = new System.Drawing.Size(263, 22);
			this.TextFullName.TabIndex = 38;
			// 
			// TextPassword
			// 
			this.TextPassword.Location = new System.Drawing.Point(209, 65);
			this.TextPassword.Name = "TextPassword";
			this.TextPassword.Size = new System.Drawing.Size(263, 22);
			this.TextPassword.TabIndex = 37;
			// 
			// TextUserName
			// 
			this.TextUserName.Location = new System.Drawing.Point(209, 25);
			this.TextUserName.Name = "TextUserName";
			this.TextUserName.Size = new System.Drawing.Size(263, 22);
			this.TextUserName.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 24);
			this.label4.TabIndex = 34;
			this.label4.Text = "Full Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 24);
			this.label3.TabIndex = 33;
			this.label3.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 24);
			this.label1.TabIndex = 32;
			this.label1.Text = "User Name";
			// 
			// TextJobDes
			// 
			this.TextJobDes.Location = new System.Drawing.Point(209, 236);
			this.TextJobDes.Name = "TextJobDes";
			this.TextJobDes.Size = new System.Drawing.Size(263, 22);
			this.TextJobDes.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 44;
			this.label2.Text = "Job Des";
			// 
			// FormUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 423);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "FormUsers";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormUsers";
			this.Load += new System.EventHandler(this.FormUsers_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnSelect;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnFirst;
		private System.Windows.Forms.ToolStripButton btnPrevious;
		private System.Windows.Forms.ToolStripButton btnNext;
		private System.Windows.Forms.ToolStripButton btnLast;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox TextPhone;
		private System.Windows.Forms.TextBox TextEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TextFullName;
		private System.Windows.Forms.TextBox TextPassword;
		private System.Windows.Forms.TextBox TextUserName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextJobDes;
		private System.Windows.Forms.Label label2;
	}
}