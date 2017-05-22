namespace FDViewer
{
	partial class frmFindTable
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
			this.lblSearchText = new System.Windows.Forms.Label();
			this.txtSearchText = new System.Windows.Forms.TextBox();
			this.lbResult = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblSearchText
			// 
			this.lblSearchText.AutoSize = true;
			this.lblSearchText.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblSearchText.Location = new System.Drawing.Point(9, 15);
			this.lblSearchText.Name = "lblSearchText";
			this.lblSearchText.Size = new System.Drawing.Size(137, 13);
			this.lblSearchText.TabIndex = 12;
			this.lblSearchText.Text = "Table ID or Table Name";
			// 
			// txtSearchText
			// 
			this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtSearchText.Location = new System.Drawing.Point(12, 33);
			this.txtSearchText.Name = "txtSearchText";
			this.txtSearchText.Size = new System.Drawing.Size(577, 22);
			this.txtSearchText.TabIndex = 11;
			this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
			this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
			// 
			// lbResult
			// 
			this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbResult.ForeColor = System.Drawing.Color.Black;
			this.lbResult.FormattingEnabled = true;
			this.lbResult.ItemHeight = 16;
			this.lbResult.Location = new System.Drawing.Point(12, 61);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(577, 276);
			this.lbResult.TabIndex = 13;
			this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
			this.lbResult.DoubleClick += new System.EventHandler(this.lbResult_DoubleClick);
			this.lbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbResult_KeyDown);
			// 
			// frmFindTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 361);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.lblSearchText);
			this.Controls.Add(this.txtSearchText);
			this.MinimizeBox = false;
			this.Name = "frmFindTable";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Find Table";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSearchText;
		private System.Windows.Forms.TextBox txtSearchText;
		private System.Windows.Forms.ListBox lbResult;
	}
}