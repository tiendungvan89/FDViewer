using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FDViewer
{
	public class FDFile
	{
		public string FilePath { get; set; }

		public string FileName {
			get {
				if (string.IsNullOrWhiteSpace(FilePath))
					return string.Empty;
				try
				{
					FileInfo p_fileInfo = new FileInfo(FilePath);
					if (!p_fileInfo.Exists)
						return string.Empty;
					return p_fileInfo.Name;
				}
				catch
				{
					return string.Empty;
				}
			}
		}
	}
}
