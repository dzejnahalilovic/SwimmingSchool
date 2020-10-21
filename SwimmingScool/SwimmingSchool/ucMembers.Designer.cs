namespace SwimmingSchool
{
	partial class ucMembers
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
			this.dgvMembers = new System.Windows.Forms.DataGridView();
			this.txtCardNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(258, 33);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(111, 20);
			this.txtLastName.TabIndex = 9;
			this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(76, 38);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(105, 20);
			this.txtFirstName.TabIndex = 8;
			this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(193, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Last name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "First name:";
			// 
			// dgvMembers
			// 
			this.dgvMembers.AllowUserToAddRows = false;
			this.dgvMembers.AllowUserToDeleteRows = false;
			this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.DateOfBirth,
            this.City,
            this.CardNumber,
            this.Group,
            this.Gender,
            this.Delete});
			this.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvMembers.Location = new System.Drawing.Point(15, 64);
			this.dgvMembers.Name = "dgvMembers";
			this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMembers.Size = new System.Drawing.Size(553, 164);
			this.dgvMembers.TabIndex = 5;
			this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
			// 
			// txtCardNumber
			// 
			this.txtCardNumber.Location = new System.Drawing.Point(454, 33);
			this.txtCardNumber.Name = "txtCardNumber";
			this.txtCardNumber.Size = new System.Drawing.Size(111, 20);
			this.txtCardNumber.TabIndex = 11;
			this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(378, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Card number:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Search members";
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnPrint.Location = new System.Drawing.Point(11, 234);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(554, 25);
			this.btnPrint.TabIndex = 13;
			this.btnPrint.Text = "Print all members";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
			this.DateOfBirth.HeaderText = "Date of birth";
			this.DateOfBirth.Name = "DateOfBirth";
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
			this.CardNumber.HeaderText = "Card number";
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
			this.Delete.DataPropertyName = "Delete";
			this.Delete.HeaderText = "Delete ";
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// ucMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCardNumber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvMembers);
			this.Name = "ucMembers";
			this.Size = new System.Drawing.Size(579, 287);
			this.Load += new System.EventHandler(this.ucMembers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvMembers;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Group;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}
