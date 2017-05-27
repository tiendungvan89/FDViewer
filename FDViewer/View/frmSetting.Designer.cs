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
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSeparator = new System.Windows.Forms.TextBox();
			this.lblFdFolder_err = new System.Windows.Forms.Label();
			this.lblSeparator_err = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblFdFolder
			// 
			this.lblFdFolder.AutoSize = true;
			this.lblFdFolder.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblFdFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblFdFolder.Location = new System.Drawing.Point(12, 14);
			this.lblFdFolder.Name = "lblFdFolder";
			this.lblFdFolder.Size = new System.Drawing.Size(61, 13);
			this.lblFdFolder.TabIndex = 11;
			this.lblFdFolder.Text = "FD Folder";
			// 
			// txtFdFolder
			// 
			this.txtFdFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFdFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtFdFolder.Location = new System.Drawing.Point(15, 30);
			this.txtFdFolder.Name = "txtFdFolder";
			this.txtFdFolder.Size = new System.Drawing.Size(468, 22);
			this.txtFdFolder.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(408, 127);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(12, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Separator of table and field";
			// 
			// txtSeparator
			// 
			this.txtSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtSeparator.Location = new System.Drawing.Point(15, 79);
			this.txtSeparator.Name = "txtSeparator";
			this.txtSeparator.Size = new System.Drawing.Size(468, 22);
			this.txtSeparator.TabIndex = 2;
			// 
			// lblFdFolder_err
			// 
			this.lblFdFolder_err.AutoSize = true;
			this.lblFdFolder_err.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblFdFolder_err.ForeColor = System.Drawing.Color.Red;
			this.lblFdFolder_err.Location = new System.Drawing.Point(79, 14);
			this.lblFdFolder_err.Name = "lblFdFolder_err";
			this.lblFdFolder_err.Size = new System.Drawing.Size(36, 13);
			this.lblFdFolder_err.TabIndex = 11;
			this.lblFdFolder_err.Text = "error";
			this.lblFdFolder_err.Visible = false;
			// 
			// lblSeparator_err
			// 
			this.lblSeparator_err.AutoSize = true;
			this.lblSeparator_err.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSeparator_err.ForeColor = System.Drawing.Color.Red;
			this.lblSeparator_err.Location = new System.Drawing.Point(176, 63);
			this.lblSeparator_err.Name = "lblSeparator_err";
			this.lblSeparator_err.Size = new System.Drawing.Size(36, 13);
			this.lblSeparator_err.TabIndex = 11;
			this.lblSeparator_err.Text = "error";
			this.lblSeparator_err.Visible = false;
			// 
			// frmSetting
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 160);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtSeparator);
			this.Controls.Add(this.txtFdFolder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSeparator_err);
			this.Controls.Add(this.lblFdFolder_err);
			this.Controls.Add(this.lblFdFolder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSetting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Setting";
			this.Load += new System.EventHandler(this.frmSetting_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFdFolder;
		private System.Windows.Forms.TextBox txtFdFolder;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSeparator;
		private System.Windows.Forms.Label lblFdFolder_err;
		private System.Windows.Forms.Label lblSeparator_err;
	}
}