using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchool
{
	public partial class ucProfessor : UserControl
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public ucProfessor()
		{
			InitializeComponent();
			dgvProfessors.AutoGenerateColumns = false;
		}

		private void ucProfessor_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData(List<Professor>result = null)
		{
			dgvProfessors.DataSource = null;
			dgvProfessors.DataSource = result ?? connectionToBase.Professor.ToList();
		}

		private void txtFirstName_TextChanged(object sender, EventArgs e)
		{
			string search = txtFirstName.Text.ToLower();
			List<Professor> result = new List<Professor>();
			foreach (var p in connectionToBase.Professor)
			{
				if (p.FirstName.ToLower().Contains(search))
				{
					result.Add(p);
				}
			}
			LoadData(result);
		}

		private void txtLastName_TextChanged(object sender, EventArgs e)
		{
			string search = txtLastName.Text.ToLower();
			List<Professor> result = new List<Professor>();
			foreach (var p in connectionToBase.Professor)
			{
				if (p.LastName.ToLower().Contains(search))
				{
					result.Add(p);
				}
			}
			LoadData(result);
		}

		private void dgvProfessors_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Professor professor = dgvProfessors.SelectedRows[0].DataBoundItem as Professor;
				if (e.ColumnIndex == 8)
				{
					DialogResult response = MessageBox.Show("Are you sure?", "Delete",
							 MessageBoxButtons.YesNo,
							 MessageBoxIcon.Question,
							 MessageBoxDefaultButton.Button2);

					if (response == DialogResult.Yes)
					{

						connectionToBase.Professor.Remove(professor);
						connectionToBase.SaveChanges();
						LoadData();
					}
				}
				else
				{
					frmChangeInformationOfMember_Professor frm = new frmChangeInformationOfMember_Professor(professor);
					frm.ShowDialog();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + " " + ex.InnerException);
			}
		}
	}
}
