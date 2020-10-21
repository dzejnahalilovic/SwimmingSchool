namespace SwimmingSchool
{
	partial class ucProfessor
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
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProfessors = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(350, 43);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(180, 20);
			this.txtLastName.TabIndex = 9;
			this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(78, 43);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(173, 20);
			this.txtFirstName.TabIndex = 8;
			this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(285, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Last name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "First name:";
			// 
			// dgvProfessors
			// 
			this.dgvProfessors.AllowUserToAddRows = false;
			this.dgvProfessors.AllowUserToDeleteRows = false;
			this.dgvProfessors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProfessors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.DateOfBirth,
            this.HireDate,
            this.City,
            this.CardNumber,
            this.Group,
            this.Gender,
            this.Delete});
			this.dgvProfessors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvProfessors.Location = new System.Drawing.Point(14, 75);
			this.dgvProfessors.Name = "dgvProfessors";
			this.dgvProfessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProfessors.Size = new System.Drawing.Size(516, 172);
			this.dgvProfessors.TabIndex = 5;
			this.dgvProfessors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessors_CellContentClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Search professor:";
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			this.DateOfBirth.HeaderText = "DateOfBirth";
			this.DateOfBirth.Name = "DateOfBirth";
			// 
			// HireDate
			// 
			this.HireDate.DataPropertyName = "HireDate";
			this.HireDate.HeaderText = "HireDate";
			this.HireDate.Name = "HireDate";
			// 
			// City
			// 
			this.City.DataPropertyName = "City";
			this.City.HeaderText = "City";
			this.City.Name = "City";
			// 
			// CardNumber
			// 
			this.CardNumber.DataPropertyName = "CardNumber";
			this.CardNumber.HeaderText = "CardNumber";
			this.CardNumber.Name = "CardNumber";
			// 
			// Group
			// 
			this.Group.DataPropertyName = "Group";
			this.Group.HeaderText = "Group";
			this.Group.Name = "Group";
			// 
			// Gender
			// 
			this.Gender.DataPropertyName = "Gender";
			this.Gender.HeaderText = "Gender";
			this.Gender.Name = "Gender";
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// ucProfessor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvProfessors);
			this.Name = "ucProfessor";
			this.Size = new System.Drawing.Size(546, 270);
			this.Load += new System.EventHandler(this.ucProfessor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProfessors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvProfessors;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Group;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}
