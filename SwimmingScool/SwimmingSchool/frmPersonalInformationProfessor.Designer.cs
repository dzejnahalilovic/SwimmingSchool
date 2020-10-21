namespace SwimmingSchool
{
	partial class frmPersonalInformationProfessor
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
			this.rvProfessor = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rvProfessor
			// 
			this.rvProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rvProfessor.DocumentMapWidth = 73;
			this.rvProfessor.LocalReport.ReportEmbeddedResource = "SwimmingSchool.rptPersonalInformationProfessor.rdlc";
			this.rvProfessor.Location = new System.Drawing.Point(0, 0);
			this.rvProfessor.Name = "rvProfessor";
			this.rvProfessor.ServerReport.BearerToken = null;
			this.rvProfessor.Size = new System.Drawing.Size(800, 450);
			this.rvProfessor.TabIndex = 0;
			// 
			// frmPersonalInformationProfessor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rvProfessor);
			this.Name = "frmPersonalInformationProfessor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPersonalInformationProfessor";
			this.Load += new System.EventHandler(this.frmPersonalInformationProfessor_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rvProfessor;
	}
}