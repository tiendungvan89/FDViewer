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
	public partial class frmAppend : Form
	{
		private string g_origin_str = string.Empty;
		private bool g_modifing = false;

		public frmAppend()
		{
			InitializeComponent();

			this.txtPrefix.TextChanged += Txt_TextChanged;
			this.txtSuffix.TextChanged += Txt_TextChanged;
			this.rtbStr.TextChanged += RtbStr_TextChanged;
		}

		private void RtbStr_TextChanged(object sender, EventArgs e)
		{
			if (g_modifing == false)
				g_origin_str = rtbStr.Text;
		}

		private void Txt_TextChanged(object sender, EventArgs e)
		{
			if (Utils.isEmpty(g_origin_str))
			{
				return;
			} 

			Append(g_origin_str);
		}

		private void Append(string x_str)
		{
			this.rtbStr.ReadOnly = true;
			g_modifing = true;
			bool p_trim_flg = chkTrim.Checked;
			bool p_skip_empty_row = chkSkipEmptyRow.Checked;

			string p_str = x_str;

			string p_prefix = this.txtPrefix.Text;
			string p_suffix = this.txtSuffix.Text;
			string[] p_rows = p_str.Split('\n');
			string p_row_i = string.Empty;
			StringBuilder p_builder = new StringBuilder();

			if (Utils.isEmpty(p_str))
			{
				return;
			}

			for (int i = 0; i < p_rows.Length; i++)
			{
				p_row_i = p_rows[i];

				if (p_skip_empty_row && Utils.isEmpty(p_row_i))
				{
					continue;
				}

				if (p_trim_flg)
				{
					p_row_i = Utils.Trim(p_row_i);
				}

				if (!Utils.isEmpty(p_prefix))
				{
					p_row_i = p_prefix + p_row_i;
				}

				if (!Utils.isEmpty(p_suffix))
				{
					p_row_i = p_row_i + p_suffix;
				}

				p_builder.Append(p_row_i).Append("\n");
			}

			this.rtbStr.Text = p_builder.ToString();
		}

		private void rtbStr_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.txtPrefix.Text = string.Empty;
			this.txtSuffix.Text = string.Empty;
			this.rtbStr.Text = string.Empty;

			this.rtbStr.ReadOnly = false;
			g_modifing = false;
			g_origin_str = string.Empty;
		}
	}
}
