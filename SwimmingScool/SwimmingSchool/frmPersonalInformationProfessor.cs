using Microsoft.Reporting.WinForms;
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
	public partial class frmPersonalInformationProfessor : Form
	{
		private Professor professor;

		public frmPersonalInformationProfessor()
		{
			InitializeComponent();
		}

		public frmPersonalInformationProfessor(Professor professor):this()
		{
			this.professor = professor;
		}

		private void frmPersonalInformationProfessor_Load(object sender, EventArgs e)
		{
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("CardNumber", professor.CardNumber.ToString()));



            DSSwimm.tblProfessorDataTable tbl = new DSSwimm.tblProfessorDataTable();


            List<object> list = new List<object>();
            list.Add(new
            {
                FirstName = professor.FirstName,
                LastName = professor.LastName,
                DateofBirth = professor.DateOfBirth,
                HireDate = professor.HireDate,
                City = professor.City.ToString(),
                Gender = professor.Gender.ToString(),
            }) ;




            ReportDataSource rds = new ReportDataSource();
            rds.Name = "PersonalInformationProfessor";
            rds.Value = list;

            rvProfessor.LocalReport.SetParameters(rpc);
            rvProfessor.LocalReport.DataSources.Add(rds);

            this.rvProfessor.RefreshReport();
		}
	}
}
