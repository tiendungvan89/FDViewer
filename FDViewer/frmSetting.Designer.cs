namespace FDViewer
{
	partial class frmSetting
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
			this.lblFdFolder = new System.Windows.Forms.Label();
			this.txtFdFolder = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFdFolder
			// 
			this.lblFdFolder.AutoSize = true;
			this.lblFdFolder.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblFdFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblFdFolder.Location = new System.Drawing.Point(12, 20);
			this.lblFdFolder.Name = "lblFdFolder";
			this.lblFdFolder.Size = new System.Drawing.Size(61, 13);
			this.lblFdFolder.TabIndex = 11;
			this.lblFdFolder.Text = "FD Folder";
			// 
			// txtFdFolder
			// 
			this.txtFdFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFdFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtFdFolder.Location = new System.Drawing.Point(91, 15);
			this.txtFdFolder.Name = "txtFdFolder";
			this.txtFdFolder.Size = new System.Drawing.Size(324, 22);
			this.txtFdFolder.TabIndex = 12;
			this.txtFdFolder.Visible = false;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(420, 14);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(32, 23);
			this.btnBrowse.TabIndex = 13;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			// 
			// frmSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 199);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFdFolder);
			this.Controls.Add(this.lblFdFolder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSetting";
			this.Text = "Setting";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFdFolder;
		private System.Windows.Forms.TextBox txtFdFolder;
		private System.Windows.Forms.Button btnBrowse;
	}
}