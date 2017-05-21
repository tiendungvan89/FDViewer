using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDViewer
{
	public class TC
	{
		public string Table { get; set; }
		public string Field { get; set; }

		public override string ToString()
		{
			return Utils.Trim(Table) + "." + Utils.Trim(Field);
		}
	}

}
