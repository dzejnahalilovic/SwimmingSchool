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
	public partial class frmReportMembers : Form
	{
        ConnectionToBase connectionToBase = new ConnectionToBase();
		public frmReportMembers()
		{
			InitializeComponent();
		}

		private void frmReportMembers_Load(object sender, EventArgs e)
		{
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("date", DateTime.Now.ToString("dd.MM.yyyy")));



            DSSwimm.tblMembersDataTable tbl = new DSSwimm.tblMembersDataTable();
            int i = 1;

            List<object> list = new List<object>();

            foreach (var m in connectionToBase.Member)
            {

                list.Add(new
                {
                    Number = i++,
                    FirstName = m.FirstName,
                    LastName = m.LastName,
                    DateOfBirth = m.DateOfBirth,
                    City = m.City.ToString(),
                    CardNumber = m.CardNumber.ToString(),
                    Group = m.Group.ToString(),
                    Gender = m.Gender.ToString()
                });
            }



            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Swimm_Members";
            rds.Value = list;

            rvMembers.LocalReport.SetParameters(rpc);
            rvMembers.LocalReport.DataSources.Add(rds);

            this.rvMembers.RefreshReport();
            
        }
    }
}
