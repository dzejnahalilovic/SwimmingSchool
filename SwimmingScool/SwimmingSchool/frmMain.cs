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

namespace SwimmingSchool
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnTraining_Click(object sender, EventArgs e)
		{
			ucTraining uc = new ucTraining();
			panel3.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panel3.Controls.Add(uc);
		}

		private void btnProfessor_Click(object sender, EventArgs e)
		{
			ucProfessor uc = new ucProfessor();
			panel3.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panel3.Controls.Add(uc);
		}

		private void btnAddProfessor_Click(object sender, EventArgs e)
		{
			ucAddProfessor uc = new ucAddProfessor();
			panel3.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panel3.Controls.Add(uc);
		}

		private void btnMembers_Click(object sender, EventArgs e)
		{
			ucMembers uc = new ucMembers();
			panel3.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panel3.Controls.Add(uc);
		}

		private void btnAddMember_Click(object sender, EventArgs e)
		{
			ucAddMember uc = new ucAddMember();
			panel3.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panel3.Controls.Add(uc);
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Controls.Add(btnPrint);
		}

		private void pbLogOut_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Close();
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			ucChooseReport uc = new ucChooseReport();
			panel3.Controls.Clear();
			uc.Dock = DockStyle.Fill;
			panel3.Controls.Add(uc);
		}

		private void btnSystemUser_Click(object sender, EventArgs e)
		{
			frmSystemUsers frm = new frmSystemUsers();
			frm.ShowDialog();
		}
	}
}
