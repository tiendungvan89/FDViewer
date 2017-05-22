namespace FDViewer
{
	partial class frmHelp
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvHotKey = new FDViewer.ExDataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvHotKey)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHotKey
			// 
			this.dgvHotKey.AllowUserToAddRows = false;
			this.dgvHotKey.AllowUserToDeleteRows = false;
			this.dgvHotKey.AllowUserToResizeRows = false;
			this.dgvHotKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHotKey.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvHotKey.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHotKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHotKey.ColumnHeadersVisible = false;
			this.dgvHotKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHotKey.EnableHeadersVisualStyles = false;
			this.dgvHotKey.Location = new System.Drawing.Point(0, 0);
			this.dgvHotKey.Name = "dgvHotKey";
			this.dgvHotKey.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvHotKey.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvHotKey.RowHeadersVisible = false;
			this.dgvHotKey.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
			this.dgvHotKey.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvHotKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvHotKey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHotKey.Size = new System.Drawing.Size(492, 183);
			this.dgvHotKey.TabIndex = 13;
			// 
			// frmHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 183);
			this.Controls.Add(this.dgvHotKey);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Help";
			this.Load += new System.EventHandler(this.frmHelp_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHelp_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dgvHotKey)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ExDataGridView dgvHotKey;
	}
}