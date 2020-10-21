namespace SwimmingSchool
{
	partial class frmSystemUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemUsers));
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.pbAddCity = new System.Windows.Forms.PictureBox();
			this.dtpHire = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAddCity)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Username,
            this.Password,
            this.DateOfBirth,
            this.HireDate,
            this.City,
            this.Gender,
            this.Delete});
			this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvUsers.Location = new System.Drawing.Point(12, 12);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(516, 150);
			this.dgvUsers.TabIndex = 6;
			this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
			// 
			// pbAddCity
			// 
			this.pbAddCity.Image = ((System.Drawing.Image)(resources.GetObject("pbAddCity.Image")));
			this.pbAddCity.Location = new System.Drawing.Point(543, 231);
			this.pbAddCity.Name = "pbAddCity";
			this.pbAddCity.Size = new System.Drawing.Size(22, 21);
			this.pbAddCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAddCity.TabIndex = 72;
			this.pbAddCity.TabStop = false;
			this.pbAddCity.Click += new System.EventHandler(this.pbAddCity_Click);
			// 
			// dtpHire
			// 
			this.dtpHire.Location = new System.Drawing.Point(403, 205);
			this.dtpHire.Name = "dtpHire";
			this.dtpHire.Size = new System.Drawing.Size(125, 20);
			this.dtpHire.TabIndex = 71;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(316, 210);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 70;
			this.label9.Text = "Hire date:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(403, 287);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(125, 23);
			this.btnSave.TabIndex = 68;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cmbGender
			// 
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Location = new System.Drawing.Point(403, 260);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(125, 21);
			this.cmbGender.TabIndex = 67;
			// 
			// cmbCity
			// 
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(403, 231);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(125, 21);
			this.cmbCity.TabIndex = 66;
			// 
			// dtpBirth
			// 
			this.dtpBirth.Location = new System.Drawing.Point(403, 179);
			this.dtpBirth.Name = "dtpBirth";
			this.dtpBirth.Size = new System.Drawing.Size(125, 20);
			this.dtpBirth.TabIndex = 65;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(109, 209);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(125, 20);
			this.txtLastName.TabIndex = 64;
			this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(109, 183);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(125, 20);
			this.txtFirstName.TabIndex = 63;
			this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(316, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 62;
			this.label6.Text = "Gender:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(316, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 61;
			this.label5.Text = "City:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(316, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 60;
			this.label4.Text = "Date of birth:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 212);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 59;
			this.label3.Text = "Last name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 58;
			this.label2.Text = "First name:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(109, 261);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(125, 20);
			this.txtPassword.TabIndex = 77;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(109, 235);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(125, 20);
			this.txtUsername.TabIndex = 76;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 75;
			this.label1.Text = "Password:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 235);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 74;
			this.label7.Text = "Username:";
			// 
			// FirstName
			// 
			this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.FirstName.DataPropertyName = "HireDate";
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			this.FirstName.Width = 53;
			// 
			// LastName
			// 
			this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.LastName.DataPropertyName = "LastName";
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			this.LastName.Width = 52;
			// 
			// Username
			// 
			this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Username.DataPropertyName = "Username";
			this.Username.HeaderText = "Username";
			this.Username.Name = "Username";
			this.Username.Width = 53;
			// 
			// Password
			// 
			this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Password.DataPropertyName = "Password";
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			this.Password.Width = 52;
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			this.DateOfBirth.HeaderText = "DateOfBirth";
			this.DateOfBirth.Name = "DateOfBirth";
			this.DateOfBirth.Width = 53;
			// 
			// HireDate
			// 
			this.HireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.HireDate.DataPropertyName = "HireDate";
			this.HireDate.HeaderText = "HireDate";
			this.HireDate.Name = "HireDate";
			this.HireDate.Width = 52;
			// 
			// City
			// 
			this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.City.DataPropertyName = "City";
			this.City.HeaderText = "City";
			this.City.Name = "City";
			this.City.Width = 53;
			// 
			// Gender
			// 
			this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Gender.DataPropertyName = "Gender";
			this.Gender.HeaderText = "Gender";
			this.Gender.Name = "Gender";
			this.Gender.Width = 52;
			// 
			// Delete
			// 
			this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			this.Delete.Width = 53;
			// 
			// frmSystemUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(589, 315);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pbAddCity);
			this.Controls.Add(this.dtpHire);
			this.Controls.Add(this.label9);
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
			this.Controls.Add(this.dgvUsers);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSystemUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "System users";
			this.Load += new System.EventHandler(this.frmSystemUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAddCity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.PictureBox pbAddCity;
		private System.Windows.Forms.DateTimePicker dtpHire;
		private System.Windows.Forms.Label label9;
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
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Username;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}