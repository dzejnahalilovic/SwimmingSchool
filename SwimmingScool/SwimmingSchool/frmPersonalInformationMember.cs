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
	public partial class frmPersonalInformationMember : Form
	{
		
        private Member member;
      
        public frmPersonalInformationMember()
		{
			InitializeComponent();
		}

        public frmPersonalInformationMember(Member member) : this()
        {
            this.member = member;
        }

        private void frmPersonalDataMember_Load(object sender, EventArgs e)
		{
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("CardNumber", member.CardNumber.ToString()));



            DSSwimm.tblMembersDataTable tbl = new DSSwimm.tblMembersDataTable();


            List<object> list = new List<object>();
            list.Add(new
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                DateOfBirth = member.DateOfBirth,
                City = member.City.ToString(),
                Group = member.Group.ToString(),
                Gender = member.Gender.ToString()
            });




            ReportDataSource rds = new ReportDataSource();
            rds.Name = "PersonalInformationMember";
            rds.Value = list;

            rvMember.LocalReport.SetParameters(rpc);
            rvMember.LocalReport.DataSources.Add(rds);

            this.rvMember.RefreshReport();
        }

       
    }
}
