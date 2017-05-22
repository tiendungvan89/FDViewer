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
	public partial class frmDefs : Form
	{
		private List<FD> g_fds;

		public frmDefs(List<FD> x_fds, Form x_parent)
		{
			InitializeComponent();

			this.dgvLogicalNm.KeyDown += DGV_KeyDown;
			this.dgvPhysicalNm.KeyDown += DGV_KeyDown;
			this.KeyDown += DGV_KeyDown;
			g_fds = x_fds;

			int p_top = x_parent.Top;
			int p_left = x_parent.Left;
			int p_width = x_parent.Width;
			int p_height = x_parent.Height;

			Point p_location = new Point(p_left + (p_width - this.Width) / 2,
				p_top + (p_height - this.Height) / 2);
			this.Location = p_location;
		}

		//private void FrmDefs_KeyDown(object sender, KeyEventArgs e)
		//{
		//	if (e.KeyCode == Keys.Escape)
		//	{
		//		this.Close();
		//	}
		//}

		private void DGV_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
			// Ctrl + V
			else if (e.Control && e.KeyCode == Keys.V)
			{
				string p_find_str = Clipboard.GetText();
				if (string.IsNullOrWhiteSpace(p_find_str))
					return;

				FdReader p_fdReader = new FdReader();
				List<TC> p_lst_find_str = p_fdReader.readTC(p_find_str);

				//if (p_is_Logical)
				//	dgvLogicalNm.DataSource = p_lst_find_str;
				//else
				//	dgvPhysicalNm.DataSource = p_lst_find_str;
				dgvLogicalNm.DataSource = p_lst_find_str;
			}
			// Ctrl + R
			else if (e.Control && e.KeyCode == Keys.Right)
			{
				btnConvert_Click(null, null);
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (dgvPhysicalNm.DataSource == null)
				return;
			List<TC> p_lst_physical = (List<TC>)dgvPhysicalNm.DataSource;
			StringBuilder p_sb = new StringBuilder();
			foreach (TC p_tc in p_lst_physical)
			{
				p_sb.Append(p_tc.ToString()).Append("\n");
			}
			if (string.IsNullOrWhiteSpace(p_sb.ToString()))
				return;

			Clipboard.SetText(p_sb.ToString());
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			if (dgvLogicalNm.DataSource == null)
				return;
			if (g_fds == null | g_fds.Count <= 0)
				return;

			List<TC> p_lst_logical = (List<TC>)dgvLogicalNm.DataSource;
			List<TC> p_lst_physical = new List<TC>();
			FdReader p_fdReader = new FdReader();
			foreach (TC p_tc in p_lst_logical)
			{
				p_lst_physical.Add(p_fdReader.getPhysicalNm(g_fds, p_tc));
			}

			dgvPhysicalNm.DataSource = p_lst_physical;
		}
	}
}
