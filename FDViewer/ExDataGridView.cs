using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDViewer
{
	public class ExDataGridView : DataGridView
	{
		public ExDataGridView()
		{
			DoubleBuffered = true;
		}

		protected override void OnRowHeaderMouseClick(DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (this.Rows.Count < 0)
				return;

			this.ClearSelection();
			this.CurrentCell = this.Rows[e.RowIndex].Cells[0];
			for (int i = 0; i < this.Rows[e.RowIndex].Cells.Count; i++)
			{
				this.Rows[e.RowIndex].Cells[i].Selected = true;
			}
		}

		protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
		{
			if (e.ColumnIndex < 0)
				return;
			if (this.Rows.Count < 0)
				return;
			this.ClearSelection();
			for (int i = 0; i < this.Rows.Count; i++)
			{
				this.Rows[i].Cells[e.ColumnIndex].Selected = true;
			}
		}

	}
}
