using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchool
{
	public partial class frmChangeInformationOfMember_Professor : Form
	{
		private Member member;
		private bool mm { get; set; }
		private bool pp { get; set; }

		ConnectionToBase connectionToBase = SS.CTB;
		private Professor professor;

		public frmChangeInformationOfMember_Professor()
		{
			InitializeComponent();
			LoadGender();
			LoadGroup();
			LoadCity();
		}

		public frmChangeInformationOfMember_Professor(Member member):this()
		{
			this.member = member;
			LoadDataOfMember();
			mm = true;
		}

		public frmChangeInformationOfMember_Professor(Professor professor) : this()
		{
			this.professor = professor;
			LoadDateOfProfessor();
			pp = true;
		}

		private void LoadDateOfProfessor()
		{
			try
			{
				txtFirstName.Text = professor.FirstName;
				txtLastName.Text = professor.LastName;
				dtpBirth.Value = DateTime.Parse(professor.DateOfBirth);
				dtpHire.Value = DateTime.Parse(professor.HireDate);
				txtCardNumber.Text = professor.CardNumber.ToString();
				cmbCity.SelectedValue = professor.City.Id;
				cmbGender.SelectedValue = professor.Gender.Id;
				if (professor.Photo == null)
					pbPhoto.Image = null;
				else
					pbPhoto.Image = ImageHelper.FromByteToImage(professor.Photo);
				cmbGroup.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " " + ex.InnerException);
			}
		}

		private void LoadDataOfMember()
		{
			try
			{
				if (member != null)
				{
					txtFirstName.Text = member.FirstName;
					txtLastName.Text = member.LastName;
					dtpBirth.Value = DateTime.Parse(member.DateOfBirth);
					dtpHire.Enabled = false;
					txtCardNumber.Text = member.CardNumber.ToString();
					cmbCity.SelectedValue = member.City.Id;
					cmbGender.SelectedValue = member.Gender.Id;
					cmbGroup.SelectedValue = member.Group.Id;
					if (member.Photo == null)
						pbPhoto.Image = null;
					else
						pbPhoto.Image = ImageHelper.FromByteToImage(member.Photo);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + " " + ex.InnerException);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (mm)
			{
				member.FirstName = txtFirstName.Text;
				member.LastName = txtLastName.Text;
				member.DateOfBirth = dtpBirth.Value.ToString();
				member.CardNumber = int.Parse(txtCardNumber.Text);
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

				connectionToBase.Entry(member).State = EntityState.Modified;
				connectionToBase.SaveChanges();
				MessageBox.Show("Successfully!");
			}
			if (pp)
			{
				professor.FirstName = txtFirstName.Text;
				professor.LastName = txtLastName.Text;
				professor.DateOfBirth = dtpBirth.Value.ToString();
				professor.HireDate = dtpHire.Value.ToString();
				professor.CardNumber = int.Parse(txtCardNumber.Text);
				Gender gender = cmbGender.SelectedItem as Gender;
				professor.Gender = gender;
				City city = cmbCity.SelectedItem as City;
				professor.City = city;
				if (pbPhoto.Image == null)
					professor.Photo = null;
				else
					professor.Photo = ImageHelper.FromImageToByte(pbPhoto.Image);

				connectionToBase.Entry(professor).State = EntityState.Modified;
				connectionToBase.SaveChanges();
				MessageBox.Show("Successfully!");
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void LoadCity()
		{
			cmbCity.DataSource = connectionToBase.City.ToList();
			cmbCity.DisplayMember = "Name";
			cmbCity.ValueMember = "Id";
		}

		private void LoadGroup()
		{
			cmbGroup.DataSource = connectionToBase.Group.ToList();
			cmbGroup.DisplayMember = "Name";
			cmbGroup.ValueMember = "Id";
		}

		private void LoadGender()
		{
			cmbGender.DataSource = connectionToBase.Gender.ToList();
			cmbGender.DisplayMember = "Name";
			cmbGender.ValueMember = "Id";
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (mm)
			{
				frmPersonalInformationMember report = new frmPersonalInformationMember(member);
				report.ShowDialog();
			}
			if (pp)
			{
				frmPersonalInformationProfessor report = new frmPersonalInformationProfessor(professor);
				report.ShowDialog();
			}
		}

		private void pbAddCity_Click(object sender, EventArgs e)
		{
			frmAddCity frm = new frmAddCity();
			frm.ShowDialog();
			LoadCity();
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

		private void frmChangeInformationOfMember_Professor_Load(object sender, EventArgs e)
		{

		}
	}
}
