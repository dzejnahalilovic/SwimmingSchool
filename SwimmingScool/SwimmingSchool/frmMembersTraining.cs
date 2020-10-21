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
	public partial class frmMembersTraining : Form
	{
		ConnectionToBase connectionToBase = SS.CTB;
		private Training tr;

		public frmMembersTraining()
		{
			InitializeComponent();
			LoadMembers();
			dgvMembersOnTraining.AutoGenerateColumns = false;
		}

		public frmMembersTraining(Training tr):this()
		{
			this.tr = tr;
			
		}

		private void MembersTraining_Load(object sender, EventArgs e)
		{
			lbDate.Text = tr.Date.ToString();
			LoadData();
		}

		private void LoadMembers()
		{
			try
			{
				cmbMembers.DataSource = connectionToBase.Member.ToList();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + " " + ex.InnerException);
			}

			
		}

		private void LoadData()
		{
			dgvMembersOnTraining.DataSource = null;
			dgvMembersOnTraining.DataSource = tr.MemberOnTraining;
		
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Member member = cmbMembers.SelectedItem as Member;
			MemberTraining newMember = new MemberTraining();
			newMember.Member = member;
			newMember.Note = txtNote.Text;

			tr.MemberOnTraining.Add(newMember);
			connectionToBase.SaveChanges();

		
			LoadData();
			
			MessageBox.Show("Succesfully!");
		}

		private void dgvMembersOnTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 2)
			{
				DialogResult response = MessageBox.Show("Are you sure?", "Delete",
						 MessageBoxButtons.YesNo,
						 MessageBoxIcon.Question,
						 MessageBoxDefaultButton.Button2);

				if (response == DialogResult.Yes)
				{

					tr.MemberOnTraining.RemoveAt(dgvMembersOnTraining.CurrentCell.RowIndex);
					connectionToBase.SaveChanges();
					LoadData();
				}
			}
		}
	}
}
