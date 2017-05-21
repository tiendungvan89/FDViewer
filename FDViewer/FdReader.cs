using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FDViewer
{
	public class FdReader
	{
		public const string FD_START = "FD";
		public const string FD_END = "/END";
		public const string FD_TABLE_DEF_ROW = "/FILE";
		public const string FD_COMMENT_CHAR = "'";
		public const string FD_EQUAL_SIGN = "=";

		public const int FD_DEF_COL_COUNT = 6;
		public const int FD_TITLE_COL_IDX = 0;
		public const int FD_FIELD_NM_COL_IDX = 1;
		public const int FD_DATA_TYPE_COL_IDX = 2;
		public const int FD_ATTRIBUTE_COL_IDX = 3;
		public const int FD_KEY_COL_IDX = 4;
		public const int FD_REMARK_COL_IDX = 5;
		public const string FD_FILE_ENDCODING = "shift-jis";

		public List<FD> readFD(FileInfo x_fInfo)
		{
			List<FD> p_fds = new List<FD>();
			if (x_fInfo == null || !x_fInfo.Exists)
				return p_fds;
			try
			{
				string p_fd_str = File.ReadAllText(x_fInfo.FullName, Encoding.GetEncoding(FD_FILE_ENDCODING));
				p_fds = readFD(p_fd_str);
			}
			catch (Exception ex)
			{
				// TODO: write log
				Console.WriteLine(ex.Message);
			}
			return p_fds;
		}

		public List<FD> readFD(string x_fdStr)
		{
			List<FD> p_fds = new List<FD>();
			FD p_current_fd = null;

			string p_table_id, p_table_nm;
			int p_no = 0;

			if (string.IsNullOrWhiteSpace(x_fdStr))
				return p_fds;
			string[] p_strFds = x_fdStr.Split('\n');

            try
            {
                for (int i = 0; i < p_strFds.Length; i++)
                {

                    string p_current_row = Utils.getDefault(p_strFds[i], "");

                    // Skip comment row
                    if (p_current_row.StartsWith(FD_COMMENT_CHAR))
                        continue;

                    // Definition START
                    if (p_current_row.StartsWith(FD_START))
                    {
                        p_current_fd = new FD();
                        p_no = 0;
                        List<FDItems> p_fd_items = new List<FDItems>();
                        p_current_fd.FDItems = p_fd_items;

                        p_fds.Add(p_current_fd);
                    }

                    // Definition END
                    if (p_current_row.StartsWith(FD_END))
                    {
                        p_current_fd = null;
                    }

                    // read definition
                    if (p_current_fd != null)
                    {
                        string[] p_current_cols = p_current_row.Replace('\r', '\n').Split(',');
                        if (p_current_row.StartsWith(FD_TABLE_DEF_ROW))
                        {
                            p_table_id = p_current_cols[0].Replace(FD_TABLE_DEF_ROW, "");
                            p_table_id = p_table_id.Replace(FD_EQUAL_SIGN, "").Trim();
                            p_table_nm = p_current_cols[1].Trim();

                            p_current_fd.TableID = p_table_id;
                            p_current_fd.TableName = p_table_nm;
                        }

                        if (p_current_cols.Length < FD_DEF_COL_COUNT)
                            continue;

                        FDItems p_fdItem = new FDItems();
                        p_fdItem.NO = ++p_no;
                        p_fdItem.Title = p_current_cols[FD_TITLE_COL_IDX].Trim();
                        p_fdItem.FieldName = p_current_cols[FD_FIELD_NM_COL_IDX].Trim();
                        p_fdItem.DataType = p_current_cols[FD_DATA_TYPE_COL_IDX].Trim();
                        p_fdItem.Attribute = p_current_cols[FD_ATTRIBUTE_COL_IDX].Trim();
                        p_fdItem.KEY = p_current_cols[FD_KEY_COL_IDX].Trim();
                        p_fdItem.Remarks = p_current_cols[FD_REMARK_COL_IDX].Trim();
                        p_current_fd.FDItems.Add(p_fdItem);
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: write log 
            }

            return p_fds;
		}

		public List<TC> readTC(string x_findStr)
		{
			char[] p_ary_field_separators = { '.', '\t', '・', '．' }; // TODO: ADD CONSTANT
			char p_row_separator = '\n';

			string[] p_ary_find_str;
			List<TC> p_lst_result = new List<TC>();
			if (string.IsNullOrWhiteSpace(x_findStr))
				return p_lst_result;


			p_ary_find_str = x_findStr.Split(p_row_separator);

			foreach (string p_str in p_ary_find_str)
			{
				string p_find_str = p_str.Replace('\r', '\n');
				string [] p_ary_tc = p_find_str.Split(p_ary_field_separators);
				TC p_tc = new TC();
				
				if (p_ary_tc.Length == 1 && string.IsNullOrWhiteSpace(p_ary_tc[0]))
				{
					p_tc.Field = "";
					p_tc.Table = "";
					p_lst_result.Add(p_tc);
					continue;
				}

				// TODO: write function to detimine text is column nm or table nm
				if (p_ary_tc.Length == 1 && !string.IsNullOrWhiteSpace(p_ary_tc[0]))
				{
					//p_tc.TableNm = p_ary_tc[0];
					//p_lst_result.Add(p_tc);
					continue;
				}

				p_tc.Table = p_ary_tc[0];
				p_tc.Field = p_ary_tc[1];
				p_lst_result.Add(p_tc);
			}
			return p_lst_result;
		}

		public TC getPhysicalNm(List<FD> x_fds, TC x_logical)
		{
			TC p_tc_rs = new TC();
			string p_table_nm = Utils.Trim(x_logical.Table);
			string p_field_nm = Utils.Trim(x_logical.Field);
			string p_table_id = "";
			string p_field_id = "";
			//if (string.IsNullOrWhiteSpace(p_table_nm) && string.IsNullOrWhiteSpace(p_field_nm))
			//{
			//	p_tc_rs.FieldNm = "";
			//	p_tc_rs.TableNm = "";
			//	return p_tc_rs;
			//}

			if (!string.IsNullOrWhiteSpace(p_table_nm) && !string.IsNullOrWhiteSpace(p_field_nm))
			{
				FD p_fd = x_fds.Where(x => string.Equals(x.TableName, p_table_nm)).FirstOrDefault<FD>();
				if (p_fd != null)
				{
					p_table_id = p_fd.TableID;

					FDItems p_fdItem = p_fd.FDItems.Where(
						x => string.Equals(x.Title, p_field_nm)).FirstOrDefault<FDItems>();

					if (p_fdItem != null)
						p_field_id = p_fdItem.FieldName;
				}
			}
			//else if (!string.IsNullOrWhiteSpace(p_table_nm) && string.IsNullOrWhiteSpace(p_field_nm))
			//{

			//}
			//else
			//{

			//}
			p_tc_rs.Field = p_field_id;
			p_tc_rs.Table = p_table_id;

			return p_tc_rs;
		}
	}
}
