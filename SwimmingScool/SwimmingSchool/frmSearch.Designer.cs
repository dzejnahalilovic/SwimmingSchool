namespace SwimmingSchool
{
	partial class frmSearch
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
			this.txtcardNumber = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtcardNumber
			// 
			this.txtcardNumber.Location = new System.Drawing.Point(18, 42);
			this.txtcardNumber.Name = "txtcardNumber";
			this.txtcardNumber.Size = new System.Drawing.Size(202, 20);
			this.txtcardNumber.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Location = new System.Drawing.Point(18, 77);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(202, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input card number:";
			// 
			// frmSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(233, 117);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtcardNumber);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Card number";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtcardNumber;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
	}
}