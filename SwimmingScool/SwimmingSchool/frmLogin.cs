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
	public partial class frmLogin : Form
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public frmLogin()
		{
			InitializeComponent();
		}


		private bool Validation()
		{
			if (string.IsNullOrEmpty(txtUsername.Text))
			{
				err.SetError(txtUsername, "Username is required!");
				return false;
			}
			if (string.IsNullOrEmpty(txtPassword.Text))
			{
				err.SetError(txtPassword, "Password is required!");
				return false;
			}
			return true;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			bool temp = false;
			if (Validation())
			{
				foreach (var u in connectionToBase.User)
				{
					if (u.Username == username && u.Password == password)
					{
						this.Hide();
						frmMain frm = new frmMain(); 
						frm.ShowDialog();
						temp = true;
						this.Close();
					}
				}
				if (!temp)
					MessageBox.Show("Invalid username or password.");
			}
		}
	}
}
