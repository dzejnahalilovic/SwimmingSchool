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
	public partial class frmSystemUsers : Form
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public frmSystemUsers()
		{
			InitializeComponent();
			dgvUsers.AutoGenerateColumns = false;
		}

		private void frmSystemUsers_Load(object sender, EventArgs e)
		{
			LoadData();
			LoadCity();
			LoadGender();
			txtPassword.Text = SetPassword(6);
		}

		private void LoadGender()
		{
			cmbGender.DataSource = connectionToBase.Gender.ToList();
			cmbGender.SelectedIndex = -1;
		}

		private void LoadCity()
		{
			cmbCity.DataSource = connectionToBase.City.ToList();
			cmbCity.SelectedIndex = -1;
		}

		private string SetPassword(int v)
		{
			string newPassword = string.Empty;
			string characters = "as#$kdjas94oighs2387239058aijfh!%&/()";
			Random random = new Random();
			int temp = 0;
			for (int i = 0; i < v; i++)
			{
				temp = random.Next(0, characters.Length);
				newPassword += characters[temp];
			}

			return newPassword;
		}

		private void LoadData()
		{
			try
			{
				dgvUsers.DataSource = null;
				dgvUsers.DataSource = connectionToBase.User.ToList();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + " " + ex.InnerException);
			}
		}

		private void txtFirstName_TextChanged(object sender, EventArgs e)
		{
			txtUsername.Text = $"{txtFirstName.Text}.{txtLastName.Text}";
		}

		private void txtLastName_TextChanged(object sender, EventArgs e)
		{
			txtUsername.Text = $"{txtFirstName.Text}.{txtLastName.Text}";
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			User user = new User();
			user.FirstName = txtFirstName.Text;
			user.LastName = txtLastName.Text;
			user.Username = txtUsername.Text;
			user.Password = txtPassword.Text;
			user.DateOfBirth = dtpBirth.Value.ToString();
			user.HireDate = dtpHire.Value.ToString();
			Gender gender = cmbGender.SelectedItem as Gender;
			user.Gender = gender;
			City city = cmbCity.SelectedItem as City;
			user.City = city;

			connectionToBase.User.Add(user);
			connectionToBase.SaveChanges();
			MessageBox.Show("Successully!");
			LoadData();
		}

		private void pbAddCity_Click(object sender, EventArgs e)
		{
			frmAddCity frm = new frmAddCity();
			frm.ShowDialog();
		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			User user = dgvUsers.SelectedRows[0].DataBoundItem as User;
			if (e.ColumnIndex == 8)
			{
				DialogResult response = MessageBox.Show("Are you sure?", "Delete",
							 MessageBoxButtons.YesNo,
							 MessageBoxIcon.Question,
							 MessageBoxDefaultButton.Button2);

				if (response == DialogResult.Yes)
				{

					connectionToBase.User.Remove(user);
					connectionToBase.SaveChanges();
					LoadData();
				}
			}
		}
	}
}
