namespace FDViewer
{
	partial class frmDefs
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnConvert = new System.Windows.Forms.Button();
			this.lblTableID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCopy = new System.Windows.Forms.Button();
			this.dgvPhysicalNm = new FDViewer.ExDataGridView();
			this.dgvLogicalNm = new FDViewer.ExDataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhysicalNm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLogicalNm)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConvert
			// 
			this.btnConvert.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnConvert.Location = new System.Drawing.Point(385, 127);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(58, 56);
			this.btnConvert.TabIndex = 2;
			this.btnConvert.Text = "→";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lblTableID
			// 
			this.lblTableID.AutoSize = true;
			this.lblTableID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTableID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblTableID.Location = new System.Drawing.Point(12, 7);
			this.lblTableID.Name = "lblTableID";
			this.lblTableID.Size = new System.Drawing.Size(81, 13);
			this.lblTableID.TabIndex = 11;
			this.lblTableID.Text = "Logical Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(452, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Physical Name";
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(765, 5);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(49, 23);
			this.btnCopy.TabIndex = 13;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// dgvPhysicalNm
			// 
			this.dgvPhysicalNm.AllowUserToAddRows = false;
			this.dgvPhysicalNm.AllowUserToDeleteRows = false;
			this.dgvPhysicalNm.AllowUserToResizeRows = false;
			this.dgvPhysicalNm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPhysicalNm.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPhysicalNm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvPhysicalNm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhysicalNm.EnableHeadersVisualStyles = false;
			this.dgvPhysicalNm.Location = new System.Drawing.Point(454, 31);
			this.dgvPhysicalNm.Name = "dgvPhysicalNm";
			this.dgvPhysicalNm.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPhysicalNm.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvPhysicalNm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Blue;
			this.dgvPhysicalNm.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvPhysicalNm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvPhysicalNm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvPhysicalNm.Size = new System.Drawing.Size(360, 287);
			this.dgvPhysicalNm.TabIndex = 12;
			// 
			// dgvLogicalNm
			// 
			this.dgvLogicalNm.AllowUserToAddRows = false;
			this.dgvLogicalNm.AllowUserToDeleteRows = false;
			this.dgvLogicalNm.AllowUserToResizeRows = false;
			this.dgvLogicalNm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvLogicalNm.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLogicalNm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvLogicalNm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLogicalNm.EnableHeadersVisualStyles = false;
			this.dgvLogicalNm.Location = new System.Drawing.Point(12, 31);
			this.dgvLogicalNm.Name = "dgvLogicalNm";
			this.dgvLogicalNm.ReadOnly = true;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLogicalNm.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvLogicalNm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Blue;
			this.dgvLogicalNm.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvLogicalNm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvLogicalNm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvLogicalNm.Size = new System.Drawing.Size(360, 287);
			this.dgvLogicalNm.TabIndex = 12;
			// 
			// frmDefs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 326);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.dgvPhysicalNm);
			this.Controls.Add(this.dgvLogicalNm);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTableID);
			this.Controls.Add(this.btnConvert);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDefs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Multi Search";
			((System.ComponentModel.ISupportInitialize)(this.dgvPhysicalNm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLogicalNm)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Label lblTableID;
		private System.Windows.Forms.Label label1;
		private ExDataGridView dgvLogicalNm;
		private ExDataGridView dgvPhysicalNm;
		private System.Windows.Forms.Button btnCopy;
	}
}