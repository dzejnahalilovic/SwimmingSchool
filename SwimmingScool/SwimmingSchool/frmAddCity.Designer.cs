namespace SwimmingSchool
{
	partial class frmAddCity
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
			this.dgvCity = new System.Windows.Forms.DataGridView();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNameCity = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddCity = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCity
			// 
			this.dgvCity.AllowUserToAddRows = false;
			this.dgvCity.AllowUserToDeleteRows = false;
			this.dgvCity.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City});
			this.dgvCity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvCity.Location = new System.Drawing.Point(13, 13);
			this.dgvCity.Name = "dgvCity";
			this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCity.Size = new System.Drawing.Size(245, 167);
			this.dgvCity.TabIndex = 0;
			// 
			// City
			// 
			this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.City.DataPropertyName = "Name";
			this.City.HeaderText = "City";
			this.City.Name = "City";
			// 
			// txtNameCity
			// 
			this.txtNameCity.Location = new System.Drawing.Point(13, 235);
			this.txtNameCity.Name = "txtNameCity";
			this.txtNameCity.Size = new System.Drawing.Size(245, 20);
			this.txtNameCity.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Add new city:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name:";
			// 
			// btnAddCity
			// 
			this.btnAddCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCity.Location = new System.Drawing.Point(13, 262);
			this.btnAddCity.Name = "btnAddCity";
			this.btnAddCity.Size = new System.Drawing.Size(245, 29);
			this.btnAddCity.TabIndex = 4;
			this.btnAddCity.Text = "Add";
			this.btnAddCity.UseVisualStyleBackColor = false;
			this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
			// 
			// frmAddCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(278, 299);
			this.Controls.Add(this.btnAddCity);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNameCity);
			this.Controls.Add(this.dgvCity);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddCity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddCity";
			this.Load += new System.EventHandler(this.frmAddCity_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCity;
		private System.Windows.Forms.TextBox txtNameCity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
	}
}