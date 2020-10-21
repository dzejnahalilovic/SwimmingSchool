namespace SwimmingSchool
{
	partial class ucAddProfessor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddProfessor));
			this.dtpHire = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.dtpBirth = new System.Windows.Forms.DateTimePicker();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pbAddCity = new System.Windows.Forms.PictureBox();
			this.lbCardNumber = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAddCity)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpHire
			// 
			this.dtpHire.Location = new System.Drawing.Point(264, 133);
			this.dtpHire.Name = "dtpHire";
			this.dtpHire.Size = new System.Drawing.Size(125, 20);
			this.dtpHire.TabIndex = 54;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(177, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 53;
			this.label9.Text = "Hire date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(319, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 51;
			this.label8.Text = "Card number:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(264, 215);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(125, 23);
			this.btnSave.TabIndex = 50;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cmbGender
			// 
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Location = new System.Drawing.Point(264, 188);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(125, 21);
			this.cmbGender.TabIndex = 48;
			// 
			// cmbCity
			// 
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(264, 159);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(125, 21);
			this.cmbCity.TabIndex = 47;
			// 
			// dtpBirth
			// 
			this.dtpBirth.Location = new System.Drawing.Point(264, 104);
			this.dtpBirth.Name = "dtpBirth";
			this.dtpBirth.Size = new System.Drawing.Size(125, 20);
			this.dtpBirth.TabIndex = 46;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(264, 79);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(125, 20);
			this.txtLastName.TabIndex = 45;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(264, 53);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(125, 20);
			this.txtFirstName.TabIndex = 44;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(177, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "Gender:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(177, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 41;
			this.label5.Text = "City:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(177, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Date of birth:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(177, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 39;
			this.label3.Text = "Last name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(177, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "First name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 37;
			this.label1.Text = "Photo";
			// 
			// pbPhoto
			// 
			this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPhoto.Location = new System.Drawing.Point(18, 44);
			this.pbPhoto.Name = "pbPhoto";
			this.pbPhoto.Size = new System.Drawing.Size(126, 151);
			this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPhoto.TabIndex = 36;
			this.pbPhoto.TabStop = false;
			this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(148, 17);
			this.label7.TabIndex = 55;
			this.label7.Text = "Add new professor:";
			// 
			// pbAddCity
			// 
			this.pbAddCity.Image = ((System.Drawing.Image)(resources.GetObject("pbAddCity.Image")));
			this.pbAddCity.Location = new System.Drawing.Point(404, 159);
			this.pbAddCity.Name = "pbAddCity";
			this.pbAddCity.Size = new System.Drawing.Size(22, 21);
			this.pbAddCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAddCity.TabIndex = 56;
			this.pbAddCity.TabStop = false;
			this.pbAddCity.Click += new System.EventHandler(this.pbAddCity_Click);
			// 
			// lbCardNumber
			// 
			this.lbCardNumber.AutoSize = true;
			this.lbCardNumber.Location = new System.Drawing.Point(404, 27);
			this.lbCardNumber.Name = "lbCardNumber";
			this.lbCardNumber.Size = new System.Drawing.Size(0, 13);
			this.lbCardNumber.TabIndex = 57;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(264, 244);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(125, 23);
			this.btnClear.TabIndex = 58;
			this.btnClear.Text = "Clear all";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// ofd
			// 
			this.ofd.FileName = "openFileDialog1";
			// 
			// ucAddProfessor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lbCardNumber);
			this.Controls.Add(this.pbAddCity);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dtpHire);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.cmbCity);
			this.Controls.Add(this.dtpBirth);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbPhoto);
			this.Name = "ucAddProfessor";
			this.Size = new System.Drawing.Size(486, 274);
			this.Load += new System.EventHandler(this.ucAddProfessor_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAddCity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpHire;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.ComboBox cmbCity;
		private System.Windows.Forms.DateTimePicker dtpBirth;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbPhoto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pbAddCity;
		private System.Windows.Forms.Label lbCardNumber;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.OpenFileDialog ofd;
	}
}
