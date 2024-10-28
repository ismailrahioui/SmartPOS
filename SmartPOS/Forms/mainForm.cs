using SmartPOS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS
{
	public partial class mainForm : Form
	{
		private Button currentButton;
		private Form ActiveForm;
		public mainForm()
		{
			InitializeComponent();
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			LabelTimer.Text = DateTime.Now.ToString();
		}

		private void openChildForm(Form cForm, object btnSender)
		{
			if (ActiveForm != null) 
			{
				ActiveForm.Close();
			}
			ActiveForm = cForm;
			ActiveButton(btnSender);	
			cForm.TopLevel = false;
			cForm.FormBorderStyle = FormBorderStyle.None;
			cForm.Dock = DockStyle.Fill;
			PanelMainForm.Controls.Add(cForm);
			PanelMainForm.Tag = cForm;
			cForm.BringToFront();
			cForm.Show();
		}
		private Color SelectTheme()
		{
			if (currentButton.Text == "Point of Sale")
            {
                return Color.Gray;
            }
			else if (currentButton.Text == "Setup")
			{
				return Color.Red;
			}
			else if (currentButton.Text == "Reporting")
			{
				return Color.Blue;
			}
			else if (currentButton.Text == "Options")
			{
				return Color.Green;
			}
			else 
			{
				return Color.Red;
			}

		}

		private void ActiveButton(object sender)
		{
			if (sender != null)
			{
				if (currentButton != (Button)sender)
				{ 
					unSelectedButton();
					currentButton= (Button)sender;
					Color color = SelectTheme();
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					PanelTitle.BackColor = color;
					LabelTitle.Text	= currentButton.Text;

				}
			}


		}

		private void unSelectedButton()
		{
            foreach (Control ctr in  PanelMenu.Controls )
            {
                if(ctr.GetType() == typeof(Button))
				{
					ctr.BackColor = Color.Gray;
					ctr.ForeColor = Color.White;
				}
            }
        }

		private void btnPOS_Click(object sender, EventArgs e)
		{
			openChildForm(new MainPointofSale(), sender);
		}

		private void btnSetup_Click(object sender, EventArgs e)
		{
			openChildForm(new MainSetup(), sender);

		}

		private void btnReporting_Click(object sender, EventArgs e)
		{
			openChildForm(new MainReports(), sender);

		}

		private void btnOprtions_Click(object sender, EventArgs e)
		{
			openChildForm(new MainOption(), sender);	

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			LabelTimer.Text = DateTime.Now.ToString();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://wwww.instagram.com");
		}
	}
}
