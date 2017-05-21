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
	public partial class frmDef : Form
	{
        private List<FD> g_lst_fd = null;

		public frmDef(List<FD> x_lst_fd, Form x_parent)
		{
			InitializeComponent();

			this.g_lst_fd = x_lst_fd;
            this.txtDefinition.Focus();

			int p_top = x_parent.Top;
			int p_left = x_parent.Left;
			int p_width = x_parent.Width;
			int p_height = x_parent.Height;

			Point p_location = new Point(p_left + (p_width - this.Width) / 2, 
				p_top + (p_height - this.Height) / 2);
			this.Location = p_location;
		}

        private void txtDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            // [ESC]
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            // [Enter]
            else if (e.KeyCode == Keys.Enter)
            {
                if (g_lst_fd == null || g_lst_fd.Count <= 0)
                {
                    return;
                }

				FD p_fd = null;
				string p_find_text = txtDefinition.Text.Trim();
				string[] p_find_text_array = { };
				string p_table_nm = "";
				string p_field_nm = "";
				string p_table_id;
				string p_field_id;
				// TODO: add as constant or in configuration files
				char[] p_ary_field_separators = { '.', '\t', '・', '．' }; 

				FDItems p_fd_item;
				string p_result = "";

				if (string.IsNullOrWhiteSpace(p_find_text))
					return;

				p_find_text_array = p_find_text.Split(p_ary_field_separators);
				if (p_find_text_array.Length <= 1)
					return;

				p_table_nm = p_find_text_array[0].Trim();
				p_field_nm = p_find_text_array[1].Trim();

				p_fd = g_lst_fd.Where(x => string.Equals(x.TableName, p_table_nm)).FirstOrDefault<FD>();
				if (p_fd == null)
					return;

				p_table_id = p_fd.TableID;

				p_fd_item = p_fd.FDItems.Where(x => string.Equals(x.Title, p_field_nm)).FirstOrDefault<FDItems>();
				if (p_fd_item == null)
					return;

				p_field_id = p_fd_item.FieldName;
				p_result = p_table_id + "." + p_field_id;
				if (string.IsNullOrWhiteSpace(p_result))
					return;

				Clipboard.SetText(p_result);
				this.txtDefinitionDst.Text = p_result;
			}
        }

        private void frmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
