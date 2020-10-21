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
	public partial class frmReportTraining : Form
	{
		private DataGridView dgvTraining;

		public frmReportTraining()
		{
			InitializeComponent();
		}

		public frmReportTraining(DataGridView dgvTraining):this()
		{
			this.dgvTraining = dgvTraining;
		}

		private void frmReportTraining_Load(object sender, EventArgs e)
		{

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("date", DateTime.Now.ToString("dd.MM.yyyy")));



            DSSwimm.tblTrainingDataTable tbl = new DSSwimm.tblTrainingDataTable();
            

            List<object> list = new List<object>();

            for (var i=0; i<dgvTraining.Rows.Count; i++)
            {

                list.Add(new
                {
                   Date = dgvTraining.Rows[i].Cells[0].Value.ToString(),
                   Group = dgvTraining.Rows[i].Cells[1].Value.ToString(),
                   Professor = dgvTraining.Rows[i].Cells[2].Value.ToString()
                });
            }



            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Swimm_Training";
            rds.Value = list;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
		}
	}
}
