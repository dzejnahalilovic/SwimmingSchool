namespace SwimmingSchool
{
	partial class frmReportMembers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rvMembers = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rvMembers
			// 
			this.rvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rvMembers.LocalReport.ReportEmbeddedResource = "SwimmingSchool.rptMembers.rdlc";
			this.rvMembers.Location = new System.Drawing.Point(0, 0);
			this.rvMembers.Name = "rvMembers";
			this.rvMembers.ServerReport.BearerToken = null;
			this.rvMembers.Size = new System.Drawing.Size(707, 403);
			this.rvMembers.TabIndex = 0;
			// 
			// frmReportMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 403);
			this.Controls.Add(this.rvMembers);
			this.Name = "frmReportMembers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmReportMembers";
			this.Load += new System.EventHandler(this.frmReportMembers_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rvMembers;
	}
}