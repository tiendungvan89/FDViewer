namespace FDViewer
{
    partial class frmFDViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFDViewer));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMItem_OpenFolder = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMItem_help = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.btnCopyToClipboard = new System.Windows.Forms.Button();
			this.cbbTableID = new System.Windows.Forms.ComboBox();
			this.txtSearchText = new System.Windows.Forms.TextBox();
			this.lblTableID = new System.Windows.Forms.Label();
			this.lblTableNm = new System.Windows.Forms.Label();
			this.lblSearchText = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tsBtnGetDef = new System.Windows.Forms.ToolStripButton();
			this.tsBtnGetDefs = new System.Windows.Forms.ToolStripButton();
			this.cbbFDFiles = new System.Windows.Forms.ComboBox();
			this.lblFdFile = new System.Windows.Forms.Label();
			this.pbFDLoading = new System.Windows.Forms.ProgressBar();
			this.lblFdFileCount = new System.Windows.Forms.Label();
			this.lblTableCount = new System.Windows.Forms.Label();
			this.dgvFD = new FDViewer.ExDataGridView();
			this.fbdFDFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFD)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(947, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMItem_OpenFile,
            this.openToolStripMItem_OpenFolder,
            this.openToolStripMItem_Exit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMItem_OpenFile
			// 
			this.openToolStripMItem_OpenFile.Name = "openToolStripMItem_OpenFile";
			this.openToolStripMItem_OpenFile.Size = new System.Drawing.Size(137, 22);
			this.openToolStripMItem_OpenFile.Text = "Open file";
			this.openToolStripMItem_OpenFile.Click += new System.EventHandler(this.openToolStripMItem_OpenFile_Click);
			// 
			// openToolStripMItem_OpenFolder
			// 
			this.openToolStripMItem_OpenFolder.Name = "openToolStripMItem_OpenFolder";
			this.openToolStripMItem_OpenFolder.Size = new System.Drawing.Size(137, 22);
			this.openToolStripMItem_OpenFolder.Text = "Open folder";
			this.openToolStripMItem_OpenFolder.Click += new System.EventHandler(this.openToolStripMItem_OpenFolder_Click);
			// 
			// openToolStripMItem_Exit
			// 
			this.openToolStripMItem_Exit.Name = "openToolStripMItem_Exit";
			this.openToolStripMItem_Exit.Size = new System.Drawing.Size(137, 22);
			this.openToolStripMItem_Exit.Text = "Exit";
			this.openToolStripMItem_Exit.Click += new System.EventHandler(this.openToolStripMItem_Exit_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.compareToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.configurationToolStripMenuItem.Text = "Configuration";
			// 
			// compareToolStripMenuItem
			// 
			this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
			this.compareToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.compareToolStripMenuItem.Text = "Compare";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMItem_help});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutToolStripMItem_help
			// 
			this.aboutToolStripMItem_help.Name = "aboutToolStripMItem_help";
			this.aboutToolStripMItem_help.Size = new System.Drawing.Size(99, 22);
			this.aboutToolStripMItem_help.Text = "Help";
			this.aboutToolStripMItem_help.Click += new System.EventHandler(this.aboutToolStripMItem_help_Click);
			// 
			// txtTableName
			// 
			this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtTableName.Location = new System.Drawing.Point(112, 122);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.ReadOnly = true;
			this.txtTableName.Size = new System.Drawing.Size(325, 22);
			this.txtTableName.TabIndex = 6;
			// 
			// btnCopyToClipboard
			// 
			this.btnCopyToClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopyToClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnCopyToClipboard.Location = new System.Drawing.Point(459, 92);
			this.btnCopyToClipboard.Name = "btnCopyToClipboard";
			this.btnCopyToClipboard.Size = new System.Drawing.Size(53, 52);
			this.btnCopyToClipboard.TabIndex = 7;
			this.btnCopyToClipboard.Text = "Copy";
			this.btnCopyToClipboard.UseVisualStyleBackColor = true;
			this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
			// 
			// cbbTableID
			// 
			this.cbbTableID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbbTableID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbbTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbTableID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cbbTableID.FormattingEnabled = true;
			this.cbbTableID.IntegralHeight = false;
			this.cbbTableID.ItemHeight = 16;
			this.cbbTableID.Location = new System.Drawing.Point(112, 92);
			this.cbbTableID.MaxDropDownItems = 10;
			this.cbbTableID.Name = "cbbTableID";
			this.cbbTableID.Size = new System.Drawing.Size(325, 24);
			this.cbbTableID.TabIndex = 8;
			this.cbbTableID.SelectedIndexChanged += new System.EventHandler(this.cbbTableID_SelectedIndexChanged);
			this.cbbTableID.DataSourceChanged += new System.EventHandler(this.cbbTableID_DataSourceChanged);
			this.cbbTableID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbTableID_KeyDown);
			// 
			// txtSearchText
			// 
			this.txtSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtSearchText.Location = new System.Drawing.Point(531, 122);
			this.txtSearchText.Name = "txtSearchText";
			this.txtSearchText.Size = new System.Drawing.Size(314, 22);
			this.txtSearchText.TabIndex = 9;
			this.txtSearchText.Visible = false;
			this.txtSearchText.Click += new System.EventHandler(this.txtSearchText_Click);
			this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
			this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
			// 
			// lblTableID
			// 
			this.lblTableID.AutoSize = true;
			this.lblTableID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTableID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblTableID.Location = new System.Drawing.Point(9, 97);
			this.lblTableID.Name = "lblTableID";
			this.lblTableID.Size = new System.Drawing.Size(52, 13);
			this.lblTableID.TabIndex = 10;
			this.lblTableID.Text = "Table ID";
			// 
			// lblTableNm
			// 
			this.lblTableNm.AutoSize = true;
			this.lblTableNm.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTableNm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblTableNm.Location = new System.Drawing.Point(9, 127);
			this.lblTableNm.Name = "lblTableNm";
			this.lblTableNm.Size = new System.Drawing.Size(72, 13);
			this.lblTableNm.TabIndex = 10;
			this.lblTableNm.Text = "Table Name";
			// 
			// lblSearchText
			// 
			this.lblSearchText.AutoSize = true;
			this.lblSearchText.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSearchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblSearchText.Location = new System.Drawing.Point(528, 104);
			this.lblSearchText.Name = "lblSearchText";
			this.lblSearchText.Size = new System.Drawing.Size(60, 13);
			this.lblSearchText.TabIndex = 10;
			this.lblSearchText.Text = "Find what";
			this.lblSearchText.Visible = false;
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnGetDef,
            this.tsBtnGetDefs});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(947, 25);
			this.toolStrip.TabIndex = 11;
			this.toolStrip.Text = "toolStrip1";
			// 
			// tsBtnGetDef
			// 
			this.tsBtnGetDef.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnGetDef.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGetDef.Image")));
			this.tsBtnGetDef.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnGetDef.Name = "tsBtnGetDef";
			this.tsBtnGetDef.Size = new System.Drawing.Size(23, 22);
			this.tsBtnGetDef.Text = "Get Definition";
			this.tsBtnGetDef.Click += new System.EventHandler(this.tsBtnGetDef_Click);
			// 
			// tsBtnGetDefs
			// 
			this.tsBtnGetDefs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBtnGetDefs.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnGetDefs.Image")));
			this.tsBtnGetDefs.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnGetDefs.Name = "tsBtnGetDefs";
			this.tsBtnGetDefs.Size = new System.Drawing.Size(23, 22);
			this.tsBtnGetDefs.Text = "toolStripButton1";
			this.tsBtnGetDefs.Click += new System.EventHandler(this.tsBtnGetDefs_Click);
			// 
			// cbbFDFiles
			// 
			this.cbbFDFiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbbFDFiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbbFDFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbFDFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cbbFDFiles.FormattingEnabled = true;
			this.cbbFDFiles.IntegralHeight = false;
			this.cbbFDFiles.Location = new System.Drawing.Point(112, 62);
			this.cbbFDFiles.MaxDropDownItems = 10;
			this.cbbFDFiles.Name = "cbbFDFiles";
			this.cbbFDFiles.Size = new System.Drawing.Size(325, 24);
			this.cbbFDFiles.TabIndex = 8;
			this.cbbFDFiles.SelectedIndexChanged += new System.EventHandler(this.cbbFDFiles_SelectedIndexChanged);
			this.cbbFDFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbFDFiles_KeyDown);
			// 
			// lblFdFile
			// 
			this.lblFdFile.AutoSize = true;
			this.lblFdFile.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblFdFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblFdFile.Location = new System.Drawing.Point(11, 67);
			this.lblFdFile.Name = "lblFdFile";
			this.lblFdFile.Size = new System.Drawing.Size(52, 13);
			this.lblFdFile.TabIndex = 10;
			this.lblFdFile.Text = "FD Files";
			// 
			// pbFDLoading
			// 
			this.pbFDLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbFDLoading.Location = new System.Drawing.Point(0, 52);
			this.pbFDLoading.Name = "pbFDLoading";
			this.pbFDLoading.Size = new System.Drawing.Size(945, 1);
			this.pbFDLoading.TabIndex = 12;
			this.pbFDLoading.Value = 100;
			this.pbFDLoading.Visible = false;
			// 
			// lblFdFileCount
			// 
			this.lblFdFileCount.AutoSize = true;
			this.lblFdFileCount.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblFdFileCount.ForeColor = System.Drawing.Color.Red;
			this.lblFdFileCount.Location = new System.Drawing.Point(62, 67);
			this.lblFdFileCount.Name = "lblFdFileCount";
			this.lblFdFileCount.Size = new System.Drawing.Size(29, 13);
			this.lblFdFileCount.TabIndex = 10;
			this.lblFdFileCount.Text = "(15)";
			// 
			// lblTableCount
			// 
			this.lblTableCount.AutoSize = true;
			this.lblTableCount.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblTableCount.ForeColor = System.Drawing.Color.Red;
			this.lblTableCount.Location = new System.Drawing.Point(60, 97);
			this.lblTableCount.Name = "lblTableCount";
			this.lblTableCount.Size = new System.Drawing.Size(36, 13);
			this.lblTableCount.TabIndex = 10;
			this.lblTableCount.Text = "(570)";
			// 
			// dgvFD
			// 
			this.dgvFD.AllowUserToAddRows = false;
			this.dgvFD.AllowUserToDeleteRows = false;
			this.dgvFD.AllowUserToResizeRows = false;
			this.dgvFD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFD.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFD.EnableHeadersVisualStyles = false;
			this.dgvFD.Location = new System.Drawing.Point(12, 163);
			this.dgvFD.Name = "dgvFD";
			this.dgvFD.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFD.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
			this.dgvFD.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvFD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvFD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvFD.Size = new System.Drawing.Size(923, 354);
			this.dgvFD.TabIndex = 5;
			this.dgvFD.SelectionChanged += new System.EventHandler(this.dgvFD_SelectionChanged);
			this.dgvFD.Click += new System.EventHandler(this.dgvFD_Click);
			this.dgvFD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFD_KeyDown);
			this.dgvFD.Resize += new System.EventHandler(this.dgvFD_Resize);
			// 
			// frmFDViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 529);
			this.Controls.Add(this.pbFDLoading);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.lblTableNm);
			this.Controls.Add(this.lblSearchText);
			this.Controls.Add(this.lblTableCount);
			this.Controls.Add(this.lblFdFileCount);
			this.Controls.Add(this.lblFdFile);
			this.Controls.Add(this.lblTableID);
			this.Controls.Add(this.txtSearchText);
			this.Controls.Add(this.cbbFDFiles);
			this.Controls.Add(this.cbbTableID);
			this.Controls.Add(this.btnCopyToClipboard);
			this.Controls.Add(this.txtTableName);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.dgvFD);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmFDViewer";
			this.Text = "FDViewer";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFDViewer_KeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMItem_Exit;
        private ExDataGridView dgvFD;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Button btnCopyToClipboard;
		private System.Windows.Forms.ComboBox cbbTableID;
		private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Label lblTableNm;
        private System.Windows.Forms.Label lblSearchText;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMItem_help;
		private System.Windows.Forms.ToolStripButton tsBtnGetDef;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tsBtnGetDefs;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMItem_OpenFolder;
		private System.Windows.Forms.ComboBox cbbFDFiles;
		private System.Windows.Forms.Label lblFdFile;
		private System.Windows.Forms.ProgressBar pbFDLoading;
		private System.Windows.Forms.Label lblFdFileCount;
		private System.Windows.Forms.Label lblTableCount;
		private System.Windows.Forms.FolderBrowserDialog fbdFDFolder;
	}
}

