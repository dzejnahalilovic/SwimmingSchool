namespace SwimmingSchool
{
	partial class frmPersonalInformationMember
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
			this.rvMember = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rvMember
			// 
			this.rvMember.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rvMember.LocalReport.ReportEmbeddedResource = "SwimmingSchool.rptPersonalInformationMember.rdlc";
			this.rvMember.Location = new System.Drawing.Point(0, 0);
			this.rvMember.Name = "rvMember";
			this.rvMember.ServerReport.BearerToken = null;
			this.rvMember.Size = new System.Drawing.Size(800, 450);
			this.rvMember.TabIndex = 0;
			// 
			// frmPersonalInformationMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rvMember);
			this.Name = "frmPersonalInformationMember";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPersonalDataMember";
			this.Load += new System.EventHandler(this.frmPersonalDataMember_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rvMember;
	}
}