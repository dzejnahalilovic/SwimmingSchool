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
	public partial class ucAddProfessor : UserControl
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public ucAddProfessor()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Professor professor = new Professor();
			professor.FirstName = txtFirstName.Text;
			professor.LastName = txtLastName.Text;
			professor.DateOfBirth = dtpBirth.Value.ToString("dd.MM.yyyy");
			professor.HireDate = dtpHire.Value.ToString("dd.MM.yyyy");
			Gender gender = cmbGender.SelectedItem as Gender;
			professor.Gender = gender;
			City city = cmbCity.SelectedItem as City;
			professor.City = city;
			if (pbPhoto.Image == null)
				professor.Photo = null;
			else
				professor.Photo = ImageHelper.FromImageToByte(pbPhoto.Image);
			professor.CardNumber = SetCardNumber();

			connectionToBase.Professor.Add(professor);
			connectionToBase.SaveChanges();
			MessageBox.Show("Successfully!");
			
		}

		private int SetCardNumber()
		{
			DateTime dt = dtpBirth.Value;
			string dtS = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString();
			DateTime dt1 = DateTime.Now;
			string dtS1 = dt1.Day.ToString();
			string dtf = dtS + dtS1;
			lbCardNumber.Text = dtf;

			int dtI = Convert.ToInt32(dtf);
			return dtI;
		}

	
		private void ucAddProfessor_Load(object sender, EventArgs e)
		{
			LoadGender();
			LoadCity();
		}

		private void LoadCity()
		{
			cmbCity.DataSource = connectionToBase.City.ToList();
			cmbCity.SelectedIndex = -1;
		}

		private void LoadGender()
		{
			cmbGender.DataSource = connectionToBase.Gender.ToList();
			cmbGender.SelectedIndex = -1;
		}

		private void pbAddCity_Click(object sender, EventArgs e)
		{
			frmAddCity frm = new frmAddCity();
			frm.ShowDialog();
			LoadCity();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lbCardNumber.Text = string.Empty;
			txtFirstName.Text = string.Empty;
			txtLastName.Text = string.Empty;
			pbAddCity.Image = null;
			cmbGender.SelectedIndex = -1;
			cmbCity.SelectedIndex = -1;
			pbPhoto.Image = null;
		}

		private void pbPhoto_Click(object sender, EventArgs e)
		{
			try
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string pathToImage = ofd.FileName;
					Image photo = Image.FromFile(pathToImage);
					pbPhoto.Image = photo;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Greska -> {ex.Message}");
			}
		}
	}
}
