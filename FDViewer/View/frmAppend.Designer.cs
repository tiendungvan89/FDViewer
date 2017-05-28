namespace FDViewer
{
	partial class frmAppend
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
			this.rtbStr = new System.Windows.Forms.RichTextBox();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.txtSuffix = new System.Windows.Forms.TextBox();
			this.lblPrefix = new System.Windows.Forms.Label();
			this.lblSuffix = new System.Windows.Forms.Label();
			this.chkTrim = new System.Windows.Forms.CheckBox();
			this.chkSkipEmptyRow = new System.Windows.Forms.CheckBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbStr
			// 
			this.rtbStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.rtbStr.Location = new System.Drawing.Point(12, 56);
			this.rtbStr.Name = "rtbStr";
			this.rtbStr.Size = new System.Drawing.Size(649, 348);
			this.rtbStr.TabIndex = 0;
			this.rtbStr.Text = "";
			this.rtbStr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbStr_KeyDown);
			// 
			// txtPrefix
			// 
			this.txtPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrefix.ForeColor = System.Drawing.Color.Navy;
			this.txtPrefix.Location = new System.Drawing.Point(12, 28);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(161, 22);
			this.txtPrefix.TabIndex = 1;
			// 
			// txtSuffix
			// 
			this.txtSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSuffix.ForeColor = System.Drawing.Color.Navy;
			this.txtSuffix.Location = new System.Drawing.Point(182, 28);
			this.txtSuffix.Name = "txtSuffix";
			this.txtSuffix.Size = new System.Drawing.Size(161, 22);
			this.txtSuffix.TabIndex = 2;
			// 
			// lblPrefix
			// 
			this.lblPrefix.AutoSize = true;
			this.lblPrefix.ForeColor = System.Drawing.Color.Navy;
			this.lblPrefix.Location = new System.Drawing.Point(9, 9);
			this.lblPrefix.Name = "lblPrefix";
			this.lblPrefix.Size = new System.Drawing.Size(33, 13);
			this.lblPrefix.TabIndex = 2;
			this.lblPrefix.Text = "Prefix";
			// 
			// lblSuffix
			// 
			this.lblSuffix.AutoSize = true;
			this.lblSuffix.ForeColor = System.Drawing.Color.Navy;
			this.lblSuffix.Location = new System.Drawing.Point(179, 9);
			this.lblSuffix.Name = "lblSuffix";
			this.lblSuffix.Size = new System.Drawing.Size(33, 13);
			this.lblSuffix.TabIndex = 2;
			this.lblSuffix.Text = "Suffix";
			// 
			// chkTrim
			// 
			this.chkTrim.AutoSize = true;
			this.chkTrim.Checked = true;
			this.chkTrim.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkTrim.ForeColor = System.Drawing.Color.Navy;
			this.chkTrim.Location = new System.Drawing.Point(361, 30);
			this.chkTrim.Name = "chkTrim";
			this.chkTrim.Size = new System.Drawing.Size(54, 20);
			this.chkTrim.TabIndex = 3;
			this.chkTrim.Text = "Trim";
			this.chkTrim.UseVisualStyleBackColor = true;
			// 
			// chkSkipEmptyRow
			// 
			this.chkSkipEmptyRow.AutoSize = true;
			this.chkSkipEmptyRow.Checked = true;
			this.chkSkipEmptyRow.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSkipEmptyRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSkipEmptyRow.ForeColor = System.Drawing.Color.Navy;
			this.chkSkipEmptyRow.Location = new System.Drawing.Point(421, 30);
			this.chkSkipEmptyRow.Name = "chkSkipEmptyRow";
			this.chkSkipEmptyRow.Size = new System.Drawing.Size(118, 20);
			this.chkSkipEmptyRow.TabIndex = 3;
			this.chkSkipEmptyRow.Text = "Skip empty row";
			this.chkSkipEmptyRow.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.ForeColor = System.Drawing.Color.Navy;
			this.btnClear.Location = new System.Drawing.Point(545, 27);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmAppend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 416);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.chkSkipEmptyRow);
			this.Controls.Add(this.chkTrim);
			this.Controls.Add(this.lblSuffix);
			this.Controls.Add(this.lblPrefix);
			this.Controls.Add(this.txtSuffix);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.rtbStr);
			this.Name = "frmAppend";
			this.Text = "Append";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbStr;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.TextBox txtSuffix;
		private System.Windows.Forms.Label lblPrefix;
		private System.Windows.Forms.Label lblSuffix;
		private System.Windows.Forms.CheckBox chkTrim;
		private System.Windows.Forms.CheckBox chkSkipEmptyRow;
		private System.Windows.Forms.Button btnClear;
	}
}