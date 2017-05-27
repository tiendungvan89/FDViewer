using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDViewer
{
    public class FD
    {
        public string TableID { get; set; }
        public string TableName { get; set; }
        public List<FDItems> FDItems { get; set; }
        public string ExcelText { get; set; }

		public override string ToString()
		{
			StringBuilder p_sb = new StringBuilder();
			p_sb.Append('\t').Append(this.TableID).Append('\n');
			p_sb.Append('\t').Append(this.TableName).Append('\n');

			if (this.FDItems != null && this.FDItems.Count > 0)
			{
				for (int i = 0; i < this.FDItems.Count; i++)
				{
					FDItems p_item = FDItems[i];
					p_sb.Append(p_item.NO).Append('\t');
					p_sb.Append(p_item.Title).Append('\t');
					p_sb.Append(p_item.FieldName).Append('\t');
					p_sb.Append(p_item.DataType).Append('\t');
					p_sb.Append(p_item.Attribute).Append('\t');
					p_sb.Append(p_item.KEY).Append('\t');
					p_sb.Append(p_item.Remarks);
					p_sb.Append('\n');
				}
			}
			return p_sb.ToString();
		}
	}
}
