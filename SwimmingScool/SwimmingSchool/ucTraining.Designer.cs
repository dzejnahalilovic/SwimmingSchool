namespace SwimmingSchool
{
	partial class ucTraining
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
			this.dgvTraining = new System.Windows.Forms.DataGridView();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ShowMembers = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.cmbGroup = new System.Windows.Forms.ComboBox();
			this.cmbProfessor = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvTraining
			// 
			this.dgvTraining.AllowUserToAddRows = false;
			this.dgvTraining.AllowUserToDeleteRows = false;
			this.dgvTraining.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Group,
            this.Professor,
            this.ShowMembers,
            this.Delete});
			this.dgvTraining.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvTraining.Location = new System.Drawing.Point(14, 134);
			this.dgvTraining.Name = "dgvTraining";
			this.dgvTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTraining.Size = new System.Drawing.Size(468, 150);
			this.dgvTraining.TabIndex = 0;
			this.dgvTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraining_CellContentClick);
			// 
			// Date
			// 
			this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Date.DataPropertyName = "Date";
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			// 
			// Group
			// 
			this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Group.DataPropertyName = "Group";
			this.Group.HeaderText = "Group";
			this.Group.Name = "Group";
			// 
			// Professor
			// 
			this.Professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Professor.DataPropertyName = "Professor";
			this.Professor.HeaderText = "Professor";
			this.Professor.Name = "Professor";
			// 
			// ShowMembers
			// 
			this.ShowMembers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ShowMembers.HeaderText = "Show members";
			this.ShowMembers.Name = "ShowMembers";
			this.ShowMembers.Text = "Show members";
			this.ShowMembers.UseColumnTextForButtonValue = true;
			// 
			// Delete
			// 
			this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(14, 55);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(138, 20);
			this.dtpDate.TabIndex = 1;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
			// 
			// cmbGroup
			// 
			this.cmbGroup.FormattingEnabled = true;
			this.cmbGroup.Location = new System.Drawing.Point(194, 55);
			this.cmbGroup.Name = "cmbGroup";
			this.cmbGroup.Size = new System.Drawing.Size(121, 21);
			this.cmbGroup.TabIndex = 2;
			this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
			// 
			// cmbProfessor
			// 
			this.cmbProfessor.FormattingEnabled = true;
			this.cmbProfessor.Location = new System.Drawing.Point(361, 55);
			this.cmbProfessor.Name = "cmbProfessor";
			this.cmbProfessor.Size = new System.Drawing.Size(121, 21);
			this.cmbProfessor.TabIndex = 3;
			this.cmbProfessor.SelectedIndexChanged += new System.EventHandler(this.cmbProfessor_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Date:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(191, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Group:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(358, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Professor:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnSave.Location = new System.Drawing.Point(14, 81);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(468, 25);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Search or add new  training";
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnPrint.Location = new System.Drawing.Point(14, 290);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(468, 25);
			this.btnPrint.TabIndex = 9;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnRefresh.Location = new System.Drawing.Point(14, 106);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(468, 25);
			this.btnRefresh.TabIndex = 10;
			this.btnRefresh.Text = "Refresh ... View all data";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// ucTraining
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbProfessor);
			this.Controls.Add(this.cmbGroup);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.dgvTraining);
			this.Name = "ucTraining";
			this.Size = new System.Drawing.Size(504, 323);
			this.Load += new System.EventHandler(this.ucTraining_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.ComboBox cmbGroup;
		private System.Windows.Forms.ComboBox cmbProfessor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnPrint;
		public System.Windows.Forms.DataGridView dgvTraining;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Group;
		private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
		private System.Windows.Forms.DataGridViewButtonColumn ShowMembers;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
		private System.Windows.Forms.Button btnRefresh;
	}
}
