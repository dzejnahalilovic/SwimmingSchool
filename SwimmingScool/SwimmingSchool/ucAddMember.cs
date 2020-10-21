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
	public partial class ucAddMember : UserControl
	{
		ConnectionToBase connectionToBase = SS.CTB;
		public ucAddMember()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				Member member = new Member();
				member.FirstName = txtFirstName.Text;
				member.LastName = txtLastName.Text;
				member.DateOfBirth = dtpBirth.Value.ToString("dd.MM.yyyy");
				Gender gender = cmbGender.SelectedItem as Gender;
				member.Gender = gender;
				City city = cmbCity.SelectedItem as City;
				member.City = city;
				Group group = cmbGroup.SelectedItem as Group;
				member.Group = group;
				if (pbPhoto.Image == null)
					member.Photo = null;
				else
					member.Photo = ImageHelper.FromImageToByte(pbPhoto.Image);
				member.CardNumber = setCardNumber();
				
				connectionToBase.Member.Add(member);
				connectionToBase.SaveChanges();
				MessageBox.Show("Successuflly!");
				
			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.InnerException);
			}
		}

		private int setCardNumber()
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

		private void ucAddMember_Load(object sender, EventArgs e)
		{
			LoadGender();
			LoadGroup();
			LoadCity();
		}

		private void LoadCity()
		{
			cmbCity.DataSource = connectionToBase.City.ToList();
			cmbCity.SelectedIndex = -1;
		}

		private void LoadGroup()
		{
			cmbGroup.DataSource = connectionToBase.Group.ToList();
			cmbGroup.SelectedIndex = -1;
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
				MessageBox.Show($"Error -> {ex.Message}");
			}
		}
	}
}
