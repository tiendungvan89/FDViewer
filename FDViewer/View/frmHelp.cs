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
	public partial class frmHelp : Form
	{
		public frmHelp(Form x_parent)
		{
			InitializeComponent();

			int p_top = x_parent.Top;
			int p_left = x_parent.Left;
			int p_width = x_parent.Width;
			int p_height = x_parent.Height;

			Point p_location = new Point(p_left + (p_width - this.Width) / 2,
				p_top + (p_height - this.Height) / 2);
			this.Location = p_location;
		}

		private void frmHelp_Load(object sender, EventArgs e)
		{
			List<Hotkey> p_lst_hotkey = new List<Hotkey>();
			Hotkey p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + O";
			p_hotkey.Value = "Open FD Files";
			p_lst_hotkey.Add(p_hotkey);

			p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + Shift + O";
			p_hotkey.Value = "Open FD Folder";
			p_lst_hotkey.Add(p_hotkey);

			p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + V";
			p_hotkey.Value = "Paste FD's string";
			p_lst_hotkey.Add(p_hotkey);

			p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + F";
			p_hotkey.Value = "Find";
			p_lst_hotkey.Add(p_hotkey);

			p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + D";
			p_hotkey.Value = "Search physical table's name and field's name";
			p_lst_hotkey.Add(p_hotkey);

			p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + Shift + D";
			p_hotkey.Value = "Search physical table's name and field's name";
			p_lst_hotkey.Add(p_hotkey);

			p_hotkey = new Hotkey();
			p_hotkey.Key = "Ctrl + Shift + R";
			p_hotkey.Value = "Find table by physical name";
			p_lst_hotkey.Add(p_hotkey);

			dgvHotKey.DataSource = p_lst_hotkey;
			dgvHotKey.Columns[0].Width = 100;
		}

		private void frmHelp_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
