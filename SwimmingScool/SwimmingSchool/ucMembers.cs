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
	public partial class ucMembers : UserControl
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public ucMembers()
		{
			InitializeComponent();
			dgvMembers.AutoGenerateColumns = false;
		}

		private void ucMembers_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData(List<Member>result = null)
		{
			dgvMembers.DataSource = null;
			dgvMembers.DataSource = result ?? connectionToBase.Member.ToList();
		}

		private void txtFirstName_TextChanged(object sender, EventArgs e)
		{
			string search = txtFirstName.Text.ToLower();
			List<Member> result = new List<Member>();
			foreach(var m in connectionToBase.Member)
			{
				if (m.FirstName.ToLower().Contains(search))
				{
					result.Add(m);
				}
			}
			LoadData(result);
		}

		private void txtLastName_TextChanged(object sender, EventArgs e)
		{
			string search = txtLastName.Text.ToLower();
			List<Member> result = new List<Member>();
			foreach (var m in connectionToBase.Member)
			{
				if (m.LastName.ToLower().Contains(search))
				{
					result.Add(m);
				}
			}
			LoadData(result);
		}

		private void txtCardNumber_TextChanged(object sender, EventArgs e)
		{
			string search = txtCardNumber.Text;
			List<Member> result = new List<Member>();
			foreach (var m in connectionToBase.Member)
			{
				if (m.CardNumber.ToString() == search)
				{
					result.Add(m);
				}
			}
			LoadData(result);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			frmReportMembers report = new frmReportMembers();
			report.ShowDialog();
		}

		private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Member member = dgvMembers.SelectedRows[0].DataBoundItem as Member;
				if (e.ColumnIndex == 7)
				{
					DialogResult response = MessageBox.Show("Are you sure?", "Delete",
						 MessageBoxButtons.YesNo,
						 MessageBoxIcon.Question,
						 MessageBoxDefaultButton.Button2);

					if (response == DialogResult.Yes)
					{

						connectionToBase.Member.Remove(member);
						connectionToBase.SaveChanges();
						LoadData();
					}
				}
				else
				{
					frmChangeInformationOfMember_Professor frm = new frmChangeInformationOfMember_Professor(member);
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
