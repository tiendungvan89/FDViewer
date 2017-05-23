using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FDViewer
{
	public class Utils
	{
		public static string getDefault(string x_str)
		{
			if (x_str == null)
				return string.Empty;
			return x_str;
		}

		public static string getDefault(object x_obj)
		{
			if (x_obj == null)
				return string.Empty;
			return x_obj.ToString();
		}

		public static string getDefault(string x_str, string x_value)
		{
			if (x_str == null)
				return x_value;
			return x_str;
		}

		public static string Trim(string x_str)
		{
			if (x_str == null)
				return string.Empty;
			return x_str.Trim();
		}

		public static List<FDFile> getFileBelongToFolder(string x_folder)
		{
			List<FDFile> p_fd_files = new List<FDFile>();
			try
			{
				if (!Directory.Exists(x_folder))
					return p_fd_files;

				List<string> files = Directory.EnumerateFiles(
					x_folder,
					Constants.FD_FILE_EXT,
					SearchOption.AllDirectories).ToList<string>();

				foreach (string f in files)
				{
					FDFile p_fd_file = new FDFile();
					p_fd_file.FilePath = f;
					p_fd_files.Add(p_fd_file);
				}

			}
			catch (Exception ex)
			{
				// TODO: write log
				Console.WriteLine(ex.Message);
			}
			return p_fd_files;
		}
		
		public static bool isEmpty<T>(List<T> x_lst)
        {
            if (x_lst == null || x_lst.Count == 0)
                return true;
            return false;
        }

        public static bool isEmpty(string x_str)
        {
            return string.IsNullOrWhiteSpace(x_str);
        }

		public static bool isExistFolder(string x_path)
		{
			try
			{
				return Directory.Exists(x_path);
			}
			catch
			{
				return false;
			}
		}
	}
}
