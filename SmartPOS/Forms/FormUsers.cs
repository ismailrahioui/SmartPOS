using SmartPOS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS.Forms
{
	public partial class FormUsers : Form
	{
		public FormUsers()
		{
			InitializeComponent();
		}

		private SqlDataAdapter _adapter;
		private DataTable _dataTable;
		private DataRow _dataRow;


		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormUsers_Load(object sender, EventArgs e)
		{
			_adapter = new SqlDataAdapter("Select * From Users",adoClass.sqlCn);
			_dataTable = new DataTable();
			loadData(0);
		}

		private void loadData(int Id)
		{
			DataRow[] dataRows = null;
            if (Id==0)
            {
				dataRows = _dataTable.Select();
            }
            else
            {
				dataRows = _dataTable.Select("Id ='" + Id + "'");
            }

			if (dataRows.Length > 0)
			{
				_dataRow = dataRows[0];
				TextUserName.Text = dataRows[0]["userName"].ToString();
				TextPassword.Text = dataRows[0]["password"].ToString();
				TextFullName.Text = dataRows[0]["fullName"].ToString();
				TextEmail.Text = dataRows[0]["email"].ToString();
				TextPhone.Text = dataRows[0]["phone"].ToString();
				TextJobDes.Text = dataRows[0]["jobDes"].ToString();


			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			_dataRow=null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
					ctr.Text = string.Empty;
                }
            }
			TextUserName.Focus();
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (TextUserName.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The User Name");
				TextUserName.Focus();
				return;
			}
			if (TextFullName.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Full Name");
				TextFullName.Focus();
				return;
			}
			if (TextPassword.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Password");
				TextPassword.Focus();
				return;
			}
			if (TextPhone.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Phone Number");
				TextPhone.Focus();
				return;
			}
			if (TextJobDes.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Job Description ");
				TextJobDes.Focus();
				return;
			}
			saveData();
		}

		private void saveData()
		{
			if (_dataRow == null)
			{
				_dataRow = _dataTable.NewRow();
				dataFillRow();
				_dataTable.Rows.Add(_dataRow);
			}
			else
			{
				_dataRow.BeginEdit();
				dataFillRow();
				_dataRow.EndEdit();
			}
			try
			{
				adoClass.builder = new SqlCommandBuilder(_adapter);
				_adapter.Update(_dataTable);
				MessageBox.Show("Data Has Been Updated ");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void dataFillRow()
		{
			_dataRow["userName"] = TextUserName.Text;
			_dataRow["password"] = TextPassword.Text;
			_dataRow["fullName"] = TextFullName.Text;
			_dataRow["email"] = TextEmail.Text;
			_dataRow["phone"] = TextPhone.Text;
			_dataRow["jobDes"] = TextJobDes.Text;
			
		}
	}
}
