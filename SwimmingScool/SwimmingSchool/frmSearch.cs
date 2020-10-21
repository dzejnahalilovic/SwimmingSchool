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
	public partial class frmSearch : Form
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public frmSearch()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			bool temp = false;
			var cardNumber = txtcardNumber.Text;
			foreach (var m in connectionToBase.Member)
			{

				if (cardNumber == m.CardNumber.ToString())
				{
					temp = true;
					frmPersonalInformationMember frm = new frmPersonalInformationMember(m);
					frm.ShowDialog();
				}

			}
			foreach (var p in connectionToBase.Professor)
			{
				if (cardNumber == p.CardNumber.ToString())
				{
					temp = true;
					frmPersonalInformationProfessor frm = new frmPersonalInformationProfessor(p);
					frm.ShowDialog();
				}
			}
			if (!temp)
			{
				MessageBox.Show("It doesn't exist member with that card number. Please try again.");
			}
		}
	}
}
