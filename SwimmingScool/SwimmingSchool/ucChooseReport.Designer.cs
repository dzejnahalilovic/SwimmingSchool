namespace SwimmingSchool
{
	partial class ucChooseReport
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPersonalInformationProfessor = new System.Windows.Forms.Button();
			this.btnPrintPersonalInformationMember = new System.Windows.Forms.Button();
			this.btnPrintAllMembers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPersonalInformationProfessor
			// 
			this.btnPersonalInformationProfessor.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPersonalInformationProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPersonalInformationProfessor.Location = new System.Drawing.Point(34, 148);
			this.btnPersonalInformationProfessor.Name = "btnPersonalInformationProfessor";
			this.btnPersonalInformationProfessor.Size = new System.Drawing.Size(389, 34);
			this.btnPersonalInformationProfessor.TabIndex = 6;
			this.btnPersonalInformationProfessor.Text = "Personal information about professor";
			this.btnPersonalInformationProfessor.UseVisualStyleBackColor = false;
			this.btnPersonalInformationProfessor.Click += new System.EventHandler(this.btnPersonalInformationProfessor_Click);
			// 
			// btnPrintPersonalInformationMember
			// 
			this.btnPrintPersonalInformationMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPrintPersonalInformationMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintPersonalInformationMember.Location = new System.Drawing.Point(34, 92);
			this.btnPrintPersonalInformationMember.Name = "btnPrintPersonalInformationMember";
			this.btnPrintPersonalInformationMember.Size = new System.Drawing.Size(389, 34);
			this.btnPrintPersonalInformationMember.TabIndex = 5;
			this.btnPrintPersonalInformationMember.Text = "Personal information about member";
			this.btnPrintPersonalInformationMember.UseVisualStyleBackColor = false;
			this.btnPrintPersonalInformationMember.Click += new System.EventHandler(this.btnPrintPersonalInformationMember_Click);
			// 
			// btnPrintAllMembers
			// 
			this.btnPrintAllMembers.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPrintAllMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintAllMembers.Location = new System.Drawing.Point(34, 39);
			this.btnPrintAllMembers.Name = "btnPrintAllMembers";
			this.btnPrintAllMembers.Size = new System.Drawing.Size(389, 34);
			this.btnPrintAllMembers.TabIndex = 4;
			this.btnPrintAllMembers.Text = "Print all members";
			this.btnPrintAllMembers.UseVisualStyleBackColor = false;
			this.btnPrintAllMembers.Click += new System.EventHandler(this.btnPrintAllMembers_Click);
			// 
			// ucChooseReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Controls.Add(this.btnPersonalInformationProfessor);
			this.Controls.Add(this.btnPrintPersonalInformationMember);
			this.Controls.Add(this.btnPrintAllMembers);
			this.Name = "ucChooseReport";
			this.Size = new System.Drawing.Size(467, 253);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnPersonalInformationProfessor;
		private System.Windows.Forms.Button btnPrintPersonalInformationMember;
		private System.Windows.Forms.Button btnPrintAllMembers;
	}
}
