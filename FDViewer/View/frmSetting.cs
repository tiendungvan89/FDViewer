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
	public partial class frmSetting : Form
	{
		private MdlSetting g_mdlSetting;
		public const string FD_FOLDER_PATH = "FD_FOLDER_PATH";
		public const string TB_FIELD_SEPARATOR = "TB_FIELD_SEPARATOR";
		public const string SETTING_FILE_NAME = "settings";

		public frmSetting(Form x_parent)
		{
			InitializeComponent();

			g_mdlSetting = new MdlSetting(SETTING_FILE_NAME);

			int p_top = x_parent.Top;
			int p_left = x_parent.Left;
			int p_width = x_parent.Width;
			int p_height = x_parent.Height;

			Point p_location = new Point(p_left + (p_width - this.Width) / 2,
				p_top + (p_height - this.Height) / 2);
			this.Location = p_location;
		}

		private void frmSetting_Load(object sender, EventArgs e)
		{
			// Load FD_FOLDER_PATH
			string p_folderPath = g_mdlSetting.GetSettingData(FD_FOLDER_PATH);
			if (!Utils.isExistFolder(p_folderPath))
			{
				p_folderPath = string.Empty;
				g_mdlSetting.SetSettingData(FD_FOLDER_PATH, p_folderPath);
			}
			this.txtFdFolder.Text = p_folderPath;

			// Load TB_FIELD_SEPARATOR
			string p_separator = g_mdlSetting.GetSettingData(TB_FIELD_SEPARATOR);
			if (Utils.isEmpty(p_separator))
			{
				g_mdlSetting.SetSettingData(TB_FIELD_SEPARATOR, p_separator);
			}
			this.txtSeparator.Text = p_separator;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string p_folderPath = this.txtFdFolder.Text.Trim();
			int p_err_cnt = 0;

			if (Utils.isEmpty(p_folderPath) || Utils.isExistFolder(p_folderPath))
			{
				g_mdlSetting.SetSettingData(FD_FOLDER_PATH, p_folderPath);

				this.lblFdFolder_err.Visible = false;
				this.lblFdFolder_err.Text = string.Empty;
			}
			else
			{
				this.lblFdFolder_err.Visible = true;
				this.lblFdFolder_err.Text = "Folder is not existed!";
				p_err_cnt++;
			}
			

			string p_separator = this.txtSeparator.Text.Trim();
			if (!Utils.isEmpty(p_separator))
			{
				g_mdlSetting.SetSettingData(TB_FIELD_SEPARATOR, p_separator);

				this.lblSeparator_err.Visible = false;
				this.lblSeparator_err.Text = string.Empty;
			}
			else
			{
				this.lblSeparator_err.Visible = true;
				this.lblSeparator_err.Text = "Separator is empty!";
				p_err_cnt++;
			}

			if (p_err_cnt == 0)
				this.Close();
		}

		public static string GetFdFolder()
		{
			MdlSetting p_mdlSetting = new MdlSetting(SETTING_FILE_NAME);
			string p_folderPath = p_mdlSetting.GetSettingData(FD_FOLDER_PATH);
			if (!Utils.isExistFolder(p_folderPath))
			{
				p_folderPath = string.Empty;
			}
			return p_folderPath;
		}

		public static void SetFdFolder(string x_folder)
		{
			MdlSetting p_mdlSetting = new MdlSetting(SETTING_FILE_NAME);
			if (Utils.isExistFolder(x_folder))
			{
				p_mdlSetting.SetSettingData(FD_FOLDER_PATH, x_folder);
			}
		}
	}
}
