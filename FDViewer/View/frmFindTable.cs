using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDViewer
{
	public partial class frmFindTable : Form
	{
		private List<FD> g_lst_fd = null;
		private Form g_parent;

		public frmFindTable(List<FD> x_lst_fd, Form x_parent)
		{
			InitializeComponent();

			this.g_lst_fd = x_lst_fd;
			this.g_parent = x_parent;

			int p_top = x_parent.Top;
			int p_left = x_parent.Left;
			int p_width = x_parent.Width;
			int p_height = x_parent.Height;

			Point p_location = new Point(p_left + (p_width - this.Width) / 2,
				p_top + (p_height - this.Height) / 2);
			this.Location = p_location;
		}

		private void txtSearchText_TextChanged(object sender, EventArgs e)
		{
			if (Utils.isEmpty(g_lst_fd))
				return;

			string p_searchStr = txtSearchText.Text.Trim();
			var p_rs = g_lst_fd.Where(
				x => x.TableID.Contains(p_searchStr) || x.TableName.Contains(p_searchStr)
			);

			if (p_rs == null)
				return;

			List<FD> p_lst_rs = p_rs.OrderBy(x => x.TableID).ToList<FD>();
			lbResult.DataSource = p_lst_rs;
			lbResult.DisplayMember = "TableID";
		}

		private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				lbResult.Focus();
			}
			else if (e.KeyCode == Keys.Enter)
			{
				OpenFD();
			}
		}

		private void lbResult_Click(object sender, EventArgs e)
		{
		}

		private void lbResult_DoubleClick(object sender, EventArgs e)
		{
			OpenFD();
		}

		private void OpenFD()
		{
			if (lbResult.DataSource == null)
				return;

			if (lbResult.SelectedIndex < 0)
				return;

			FD p_fd = lbResult.SelectedValue as FD;
			frmFDViewer p_frmFdViewer = g_parent as frmFDViewer;
			p_frmFdViewer.ShowFD(p_fd);
			this.Close();
		}

		private void lbResult_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				OpenFD();
			}
		}

		private void frmFindTable_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
