namespace SwimmingSchool
{
	partial class frmMembersTraining
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
			this.dgvMembersOnTraining = new System.Windows.Forms.DataGridView();
			this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.cmbMembers = new System.Windows.Forms.ComboBox();
			this.txtNote = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMembersOnTraining)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMembersOnTraining
			// 
			this.dgvMembersOnTraining.AllowUserToAddRows = false;
			this.dgvMembersOnTraining.AllowUserToDeleteRows = false;
			this.dgvMembersOnTraining.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvMembersOnTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMembersOnTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Members,
            this.Note,
            this.Delete});
			this.dgvMembersOnTraining.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvMembersOnTraining.Location = new System.Drawing.Point(12, 42);
			this.dgvMembersOnTraining.Name = "dgvMembersOnTraining";
			this.dgvMembersOnTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMembersOnTraining.Size = new System.Drawing.Size(516, 216);
			this.dgvMembersOnTraining.TabIndex = 0;
			this.dgvMembersOnTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembersOnTraining_CellContentClick);
			// 
			// Members
			// 
			this.Members.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Members.DataPropertyName = "Member";
			this.Members.HeaderText = "Members";
			this.Members.Name = "Members";
			// 
			// Note
			// 
			this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Note.DataPropertyName = "Note";
			this.Note.HeaderText = "Note";
			this.Note.Name = "Note";
			// 
			// Delete
			// 
			this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// cmbMembers
			// 
			this.cmbMembers.FormattingEnabled = true;
			this.cmbMembers.Location = new System.Drawing.Point(12, 312);
			this.cmbMembers.Name = "cmbMembers";
			this.cmbMembers.Size = new System.Drawing.Size(204, 21);
			this.cmbMembers.TabIndex = 1;
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(272, 312);
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(256, 66);
			this.txtNote.TabIndex = 2;
			this.txtNote.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "List of members:";
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Location = new System.Drawing.Point(473, 18);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(0, 13);
			this.lbDate.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 296);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Member:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(276, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Note:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 269);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Add new member and note:";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(12, 387);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(516, 32);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmMembersTraining
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(543, 424);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.cmbMembers);
			this.Controls.Add(this.dgvMembersOnTraining);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMembersTraining";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of members on training";
			this.Load += new System.EventHandler(this.MembersTraining_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMembersOnTraining)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMembersOnTraining;
		private System.Windows.Forms.ComboBox cmbMembers;
		private System.Windows.Forms.RichTextBox txtNote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Members;
		private System.Windows.Forms.DataGridViewTextBoxColumn Note;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}