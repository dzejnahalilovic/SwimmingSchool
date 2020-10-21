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
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			frmLogin frm = new frmLogin();
			frm.ShowDialog();
		}

		private void btnLogin_Click_1(object sender, EventArgs e)
		{
			frmLogin frm = new frmLogin();
			frm.ShowDialog();
		}
	}
}
