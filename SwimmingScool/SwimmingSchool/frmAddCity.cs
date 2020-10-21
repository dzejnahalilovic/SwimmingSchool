using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchool
{
	public partial class frmAddCity : Form
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public frmAddCity()
		{
			InitializeComponent();
			dgvCity.AutoGenerateColumns = false;
		}

		private void frmAddCity_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			try
			{
				dgvCity.DataSource = null;
				dgvCity.DataSource = connectionToBase.City.ToList();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + ' ' + ex.InnerException);
			}
		}

		private void btnAddCity_Click(object sender, EventArgs e)
		{
			City city = new City();
			city.Name = txtNameCity.Text;
			connectionToBase.City.Add(city);
			connectionToBase.SaveChanges();

			LoadData();
		}
	}
}
