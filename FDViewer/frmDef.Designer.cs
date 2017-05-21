namespace FDViewer
{
	partial class frmDef
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
			this.txtDefinition = new System.Windows.Forms.TextBox();
			this.txtDefinitionDst = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtDefinition
			// 
			this.txtDefinition.Location = new System.Drawing.Point(12, 12);
			this.txtDefinition.Name = "txtDefinition";
			this.txtDefinition.Size = new System.Drawing.Size(329, 20);
			this.txtDefinition.TabIndex = 0;
			this.txtDefinition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefinition_KeyDown);
			// 
			// txtDefinitionDst
			// 
			this.txtDefinitionDst.Location = new System.Drawing.Point(12, 46);
			this.txtDefinitionDst.Name = "txtDefinitionDst";
			this.txtDefinitionDst.ReadOnly = true;
			this.txtDefinitionDst.Size = new System.Drawing.Size(329, 20);
			this.txtDefinitionDst.TabIndex = 0;
			this.txtDefinitionDst.TabStop = false;
			this.txtDefinitionDst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefinition_KeyDown);
			// 
			// frmDef
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 79);
			this.Controls.Add(this.txtDefinitionDst);
			this.Controls.Add(this.txtDefinition);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDef";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Search";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearch_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.TextBox txtDefinitionDst;
    }
}