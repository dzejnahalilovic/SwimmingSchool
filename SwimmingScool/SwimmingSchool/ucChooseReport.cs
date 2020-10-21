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
	public partial class ucChooseReport : UserControl
	{
		public ucChooseReport()
		{
			InitializeComponent();
		}

		private void btnPrintPersonalInformationMember_Click(object sender, EventArgs e)
		{
			frmSearch frm = new frmSearch();
			frm.ShowDialog();
		}

		private void btnPrintAllMembers_Click(object sender, EventArgs e)
		{
			frmReportMembers frm = new frmReportMembers();
			frm.ShowDialog();
		}

		private void btnPersonalInformationProfessor_Click(object sender, EventArgs e)
		{
			frmSearch frm = new frmSearch();
			frm.ShowDialog();
		}

	}
}
