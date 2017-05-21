using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FDViewer
{
    public partial class frmFDViewer : Form
    {

		#region variable declaration 
		private List<Point> g_lst_matched_pos = new List<Point>();
		#endregion

		#region constructure
		public frmFDViewer()
		{
			InitializeComponent();
			dgvFD.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
		}
		#endregion

		#region Menu's Event
		private void openToolStripMItem_OpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog p_openDlg = new OpenFileDialog();
			p_openDlg.Filter = "FD files (*.fd)|*.fd|All files (*.*)|*.*";
			DialogResult p_dlgRs = p_openDlg.ShowDialog();

			if (p_dlgRs == System.Windows.Forms.DialogResult.OK)
			{
				FileInfo p_fileInfo = new FileInfo(p_openDlg.FileName);

				FdReader p_fdReader = new FdReader();
				List<FD> p_fds = p_fdReader.readFD(p_fileInfo);

				// TODO: Common below code
				if (p_fds == null || p_fds.Count <= 0)
				{
					MessageBox.Show("FD definition is invalid!");
					return;
				}

				cbbTableID.DataSource = p_fds;
				cbbTableID.DisplayMember = "TableID";
			}
		}

		private void openToolStripMItem_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void openToolStripMItem_OpenFolder_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					List<FDFile> p_files = Utils.getFileBelongToFolder(fbd.SelectedPath);
					cbbFDFiles.DataSource = p_files;
					cbbFDFiles.DisplayMember = "FileName";
				}
			}

		}
		#endregion

		#region DataGridView's Event
		private void dgvFD_KeyDown(object sender, KeyEventArgs e)
		{
			// Ctrl + V
			if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
			{
				string strFd = Clipboard.GetText();
				if (strFd != null || strFd != "")
				{
					FdReader p_fdReader = new FdReader();
					List<FD> p_fds = p_fdReader.readFD(strFd);

					// TODO: Common below code
					if (p_fds == null || p_fds.Count <= 0)
					{
						MessageBox.Show("FD definition is invalid!");
						return;
					}

					cbbTableID.DataSource = p_fds;
					cbbTableID.DisplayMember = "TableID";
				}
			}
			// Ctrl + C
			else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
			{
				//if (this.dgvFD.DataSource == null)
				//    return;

				//if (this.dgvFD.SelectedCells.Count > 0)
				//{
				//    int p_max_row = 0;
				//    int p_max_col = 0;
				//    for (int i = this.dgvFD.SelectedCells.Count - 1; i >= 0; i--)
				//    {
				//        if (p_max_row < this.dgvFD.SelectedCells[i].RowIndex)
				//        {
				//            p_max_row = this.dgvFD.SelectedCells[i].RowIndex;
				//        }

				//        if (p_max_col < this.dgvFD.SelectedCells[i].ColumnIndex)
				//        {
				//            p_max_col = this.dgvFD.SelectedCells[i].ColumnIndex;
				//        }
				//    }

				//    string[,] p_selected_values = new string[p_max_row + 1, p_max_col + 1];
				//    for (int i = this.dgvFD.SelectedCells.Count - 1; i >= 0; i--)
				//    {
				//        int p_row_idx = this.dgvFD.SelectedCells[i].RowIndex;
				//        int p_col_idx = this.dgvFD.SelectedCells[i].ColumnIndex;
				//        p_selected_values[p_row_idx, p_col_idx] = Utils.getDefault(this.dgvFD.SelectedCells[i].Value);
				//    }

				//    StringBuilder p_sb = new StringBuilder();
				//    for (int i = 0; i < p_max_row + 1; i++)
				//    {
				//        for (int j = 0; j < p_max_col + 1; j++)
				//        {
				//            p_sb.Append(p_selected_values[i, j]).Append("\t");
				//        }
				//        p_sb.Append("\n");
				//    }

				//    if (!string.IsNullOrWhiteSpace(p_sb.ToString()))
				//    {
				//        //Clipboard.SetText(p_sb.ToString());
				//    }
				//}
			} // End Of [Ctrl + C]
			else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
			{
				if (this.dgvFD.DataSource == null)
					return;

				this.txtSearchText.Visible = true;
				this.lblSearchText.Visible = true;
				txtSearchText.Focus();
			} // End Of [Ctrl + F]
			else if (e.KeyCode == Keys.Escape)
			{
				this.txtSearchText.Text = string.Empty;
				dgvFD.Focus();
				this.txtSearchText.Visible = false;
				this.lblSearchText.Visible = false;
				g_lst_matched_pos.Clear();
			} // End Of [ESC]
			  // [Ctrl + Shift + D]
			else if (e.KeyCode == Keys.D && e.Control && e.Shift)
			{
				if (cbbTableID.DataSource == null)
					return;
				List<FD> p_lst_fd = (List<FD>)cbbTableID.DataSource;
				frmDefs p_frmDefs = new frmDefs(p_lst_fd, this);
				p_frmDefs.ShowDialog();
			}
			// [Ctrl + D]
			else if (e.KeyCode == Keys.D && e.Control)
			{
				if (cbbTableID.DataSource == null)
					return;
				List<FD> p_lst_fd = (List<FD>)cbbTableID.DataSource;
				frmDef p_frmSearch = new frmDef(p_lst_fd, this);
				p_frmSearch.ShowDialog();
			}
		}

		private void dgvFD_Resize(object sender, EventArgs e)
		{
			this.dgvFD.AllowUserToResizeColumns = true;
			if (this.dgvFD.DataSource != null)
			{
				this.dgvFD.Columns[0].Width = 50;
			}
		}

		private void dgvFD_SelectionChanged(object sender, EventArgs e)
		{
			//g_lst_matched_pos.Clear();
		}

		private void dgvFD_Click(object sender, EventArgs e)
		{
			g_lst_matched_pos.Clear();
		}
		#endregion

		#region Button's event
		private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
			if (cbbTableID.DataSource != null && cbbTableID.SelectedItem != null)
			{
				FD p_fd = (FD)cbbTableID.SelectedItem;
				string p_text = p_fd.ToString();
				if (!string.IsNullOrWhiteSpace(p_text)) 
					Clipboard.SetText(p_fd.ToString());
			}
		}
		#endregion

		#region Combobox's Event
		private void cbbTableID_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				List<FD> p_fds = (List<FD>)cbbTableID.DataSource;
				if (p_fds == null)
					return;
				if (cbbTableID.SelectedIndex < 0 || cbbTableID.SelectedIndex > p_fds.Count)
					return;
				FD p_selected_fd = p_fds[cbbTableID.SelectedIndex];
				cbbTableID.Tag = p_selected_fd;
				FillData(p_selected_fd);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbbFDFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbFDFiles.SelectedIndex < 0 || cbbFDFiles.DataSource == null)
				return;

			FDFile p_fdFile = (FDFile)cbbFDFiles.SelectedItem;
			FileInfo p_fileInfo = new FileInfo(p_fdFile.FilePath);

			cbbFDFiles.Tag = p_fdFile;

			FdReader p_fdReader = new FdReader();
			List<FD> p_fds = p_fdReader.readFD(p_fileInfo);

			// TODO: Common below code
			if (p_fds == null || p_fds.Count <= 0)
			{
				MessageBox.Show("FD definition is invalid!");
				return;
			}

			cbbTableID.DataSource = p_fds;
			cbbTableID.DisplayMember = "TableID";

		}

		private void cbbFDFiles_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (cbbFDFiles.DataSource == null)
					return;
				if (cbbFDFiles.Tag == null)
					return;

				FDFile p_fdFile = (FDFile)cbbFDFiles.Tag;
				cbbFDFiles.Text = p_fdFile.FileName;
			}
		}

		private void cbbTableID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (cbbTableID.DataSource == null)
					return;
				if (cbbTableID.Tag == null)
					return;

				FD p_fd = (FD)cbbTableID.Tag;
				cbbTableID.Text = p_fd.TableID;
			}
		}

		private void cbbTableID_DataSourceChanged(object sender, EventArgs e)
		{
			if (cbbTableID.DataSource != null)
				tsBtnGetDef.Enabled = true;
			else
				tsBtnGetDef.Enabled = false;
		}
		#endregion

		#region Toolstrip's Event
		private void tsBtnGetDef_Click(object sender, EventArgs e)
		{
			if (cbbTableID.DataSource == null)
				return;
			List<FD> p_lst_fd = (List<FD>)cbbTableID.DataSource;
			frmDef p_frmSearch = new frmDef(p_lst_fd, this);
			p_frmSearch.ShowDialog();
		}

		private void tsBtnGetDefs_Click(object sender, EventArgs e)
		{
			if (cbbTableID.DataSource == null)
				return;
			List<FD> p_lst_fd = (List<FD>)cbbTableID.DataSource;
			frmDefs p_frmDefs = new frmDefs(p_lst_fd, this);
			p_frmDefs.ShowDialog();
		}
		#endregion

		#region Textbox's Event
		private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
		{
			// [Enter]
			if (e.KeyCode == Keys.Enter)
			{
				if (string.IsNullOrWhiteSpace(txtSearchText.Text))
					return;

				bool p_matched = false;
				string p_search_text = txtSearchText.Text.Trim();
				try
				{

					foreach (DataGridViewRow row in dgvFD.Rows)
					{
						for (int i = 0; i < row.Cells.Count; i++)
						{
							int p_row_idx = row.Cells[i].RowIndex;
							int p_col_idx = row.Cells[i].ColumnIndex;
							Point p_position = new Point(p_row_idx, p_col_idx);

							// Skip old matched.
							if (g_lst_matched_pos.Contains(p_position))
								continue;

							string p_value = Utils.getDefault(row.Cells[i].Value);
							if (p_value.Contains(p_search_text))
							{
								row.Cells[i].Selected = true;
								dgvFD.CurrentCell = row.Cells[i];
								this.txtSearchText.Focus();

								p_matched = true;
								g_lst_matched_pos.Add(p_position);
								return;
							}
						}
					}


				}
				catch
				{
					g_lst_matched_pos.Clear();
				}
				finally
				{
					if (!p_matched)
					{
						g_lst_matched_pos.Clear();
						MessageBox.Show("Can't find the text: '" + p_search_text + "'");
					}
				}

			}       // end of Keys.Enter
					// [ESC]
			else if (e.KeyCode == Keys.Escape)
			{
				this.txtSearchText.Text = string.Empty;
				dgvFD.Focus();
				this.txtSearchText.Visible = false;
				this.lblSearchText.Visible = false;
				g_lst_matched_pos.Clear();
			}
			// [Ctrl + F]
			else if (e.KeyCode == Keys.F && e.Control)
			{
				this.txtSearchText.SelectAll();
			}
		}

		private void txtSearchText_TextChanged(object sender, EventArgs e)
		{
			g_lst_matched_pos.Clear();
		}

		private void txtSearchText_Click(object sender, EventArgs e)
		{
			this.txtSearchText.SelectAll();
		}
		#endregion

		private void FillData(FD x_fd)
		{
			this.txtTableName.Text = x_fd.TableName;
			this.dgvFD.DataSource = x_fd.FDItems;
			this.dgvFD.Columns[0].Width = 50;

            // Clear matched position
            this.g_lst_matched_pos.Clear();
		}

	} // END OF CLASS
}
