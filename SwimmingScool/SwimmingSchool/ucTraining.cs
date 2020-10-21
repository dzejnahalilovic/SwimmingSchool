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
	public partial class ucTraining : UserControl
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public ucTraining()
		{
			InitializeComponent();
			dgvTraining.AutoGenerateColumns = false;
		}

		private void ucTraining_Load(object sender, EventArgs e)
		{
			LoadData();
			LoadGroup();
			LoadProfessor();
		}

		private void LoadProfessor()
		{
			cmbProfessor.DataSource = connectionToBase.Professor.ToList();
		}

		private void LoadGroup()
		{
			cmbGroup.DataSource = connectionToBase.Group.ToList();
		}

		private void LoadData(List<Training>result = null)
		{
			dgvTraining.DataSource = null;
			dgvTraining.DataSource = result ?? connectionToBase.Training.ToList();
		}

		private void cmbProfessor_SelectedIndexChanged(object sender, EventArgs e)
		{
			Professor professor = cmbProfessor.SelectedItem as Professor;
			List<Training> result = new List<Training>();
			foreach (var t in connectionToBase.Training)
			{
				if (t.Professor == professor)
				{
					result.Add(t);
				}
			}
			LoadData(result);
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			string date = dtpDate.Value.ToString();
			List<Training> result = new List<Training>();
			foreach (var t in connectionToBase.Training)
			{
				if (t.Date == date)
				{
					result.Add(t);
				}
			}
			LoadData(result);
		}

		private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			Group group = cmbGroup.SelectedItem as Group;
			List<Training> result = new List<Training>();
			foreach (var t in connectionToBase.Training)
			{
				if (t.Group == group)
				{
					result.Add(t);
				}
			}
			LoadData(result);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				Training training = new Training();
				Professor professor = cmbProfessor.SelectedItem as Professor;
				Group group = cmbGroup.SelectedItem as Group;
				training.Date = dtpDate.Value.ToString("dd.MM.yyyy");
				training.Professor = professor;
				training.Group = group;
				connectionToBase.Training.Add(training);
				connectionToBase.SaveChanges();

				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.InnerException);
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			frmReportTraining report = new frmReportTraining(dgvTraining);
			report.ShowDialog();
		}

		private void dgvTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Training tr = dgvTraining.SelectedRows[0].DataBoundItem as Training;
			if(e.ColumnIndex == 3)
			{
				frmMembersTraining frm = new frmMembersTraining(tr);
				frm.ShowDialog();
			}
			else if(e.ColumnIndex == 4)
			{
				DialogResult response = MessageBox.Show("Are you sure?", "Delete",
						 MessageBoxButtons.YesNo,
						 MessageBoxIcon.Question,
						 MessageBoxDefaultButton.Button2);

				if (response == DialogResult.Yes)
				{

					connectionToBase.Training.Remove(tr);
					connectionToBase.SaveChanges();
					LoadData();
				}
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
