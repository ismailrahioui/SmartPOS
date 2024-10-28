using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SmartPOS.Classes;

namespace SmartPOS.Forms
{
	public partial class MainOption : Form
	{
		public MainOption()
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

		private void MainOption_Load(object sender, EventArgs e)
		{
			_adapter = new SqlDataAdapter("Select Top 1 * From Options",adoClass.sqlCn);
			_dataTable = new DataTable();

			try
			{
				_adapter.Fill( _dataTable );
				if (_dataTable.Rows.Count > 0) 
				{
					_dataRow = _dataTable.Rows[0];
					for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
					{
						TextRestName.Text = _dataTable.Rows[i]["RestName"].ToString();
						TextPrinterName.Text = _dataTable.Rows[i]["PrinterName"].ToString();
						TextRestAddress1.Text = _dataTable.Rows[i]["RestAddress1"].ToString();
						TextRestAddress2.Text = _dataTable.Rows[i]["RestAddress2"].ToString();
						TextReceiptLine1.Text = _dataTable.Rows[i]["ReceiptLine1"].ToString();
						TextReceiptLine2.Text = _dataTable.Rows[i]["ReceopLine2"].ToString();
						TextPhone.Text = _dataTable.Rows[i]["telephone"].ToString();

                        if (_dataTable.Rows[i]["logo"] != DBNull.Value)
                        {
							pictureBox1.BackgroundImage =  Helper.ByteToImage( _dataTable.Rows[i]["logo"]);
                            
                        }


					}

				}
                else
                {
					_dataRow=null;
                    
                }

            }
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
            if (MessageBox.Show("Save New Data" ,"?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SaveData();
            }

        }
		private void SaveData()
		{
			if (TextRestName.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Restaurant Name");
				TextRestName.Focus();
				return;
			}
			if (TextPhone.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Phone Number");
				TextPhone.Focus();
				return;
			}
			if (TextRestAddress1.Text == string.Empty)
			{
				MessageBox.Show("Please Enter The Restaurant Address ");
				TextRestAddress1.Focus();
				return;
			}

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
			_dataRow["RestName"]=TextRestName.Text;
			_dataRow["PrinterName"] = TextPrinterName.Text;
			_dataRow["RestAddress1"] = TextRestAddress1.Text;
			_dataRow["RestAddress2"] = TextRestAddress2.Text;
			_dataRow["ReceiptLine1"] = TextReceiptLine1.Text;
			_dataRow["ReceopLine2"] = TextReceiptLine2.Text;
			_dataRow["telephone"] = TextPhone.Text;
            if (pictureBox1.BackgroundImage!= null)
            {
				_dataRow["logo"] = Helper.ImagetoByte(pictureBox1.BackgroundImage);
            }

        }

		private void btnimage_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "Images|*.png";
			if(fileDialog.ShowDialog() == DialogResult.OK)
			{
				TextPicture.Text = fileDialog.FileName; 
				pictureBox1.BackgroundImage = new Bitmap(TextPicture.Text);	
			}
		}
	}
}
