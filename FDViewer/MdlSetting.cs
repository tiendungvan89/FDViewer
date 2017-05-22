using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FDViewer
{
	public class MdlSetting
	{
		private string loc;

		/// <summary>
		/// </summary>
		/// <param name="fileName">拡張子のないファイル名</param>
		public MdlSetting(string fileName)
		{
			init(fileName);
		}

		/// <summary>
		/// 初期処理
		/// </summary>
		/// <param name="fileName">拡張子のないファイル名</param>
		private void init(string fileName)
		{
			Type t = typeof(MdlSetting);
			string location = t.Assembly.Location;
			loc = Path.GetDirectoryName(location) + @"\" + fileName;
		}

		/// <summary>
		/// 設定キー(key)からデータを取得する
		/// </summary>
		/// <param name="fileName">ファイル名</param>
		/// <param name="key">設定キー</param>
		/// <returns>設定値</returns>
		public string GetSettingData(string fileName, string key)
		{
			var setting = GetSetting(key);
			if (setting == null)
			{
				return "";
			}
			return setting.Value;
		}

		/// <summary>
		/// 設定キー(key)のデータを書き換える。
		/// </summary>
		/// <param name="fileName">ファイル名</param>
		/// <param name="key">キー</param>
		/// <param name="value">設定値</param>
		/// <returns></returns>
		public bool SetSettingData(string fileName, string key, string value)
		{
			try
			{
				var config = GetConfig(loc);

				var setting = config.AppSettings.Settings[key];
				if (setting == null)
				{
					// 新規追加
					config.AppSettings.Settings.Add(key, value);
					config.Save();
					return false;
				}

				// 上書き
				setting.Value = value;
				config.Save();
				return true;
			}
			catch
			{
				return false;
			}
		}

		private KeyValueConfigurationElement GetSetting(string key)
		{
			var config = GetConfig(loc);

			if (config == null)
			{
				return null;
			}

			return config.AppSettings.Settings[key];
		}

		private Configuration GetConfig(string loca)
		{
			string dll_config_path = loca + ".config";

			if (!File.Exists(dll_config_path))
			{
				return null;
			}
			var file_map = new ExeConfigurationFileMap();
			file_map.ExeConfigFilename = dll_config_path;
			System.Configuration.Configuration config =
				   ConfigurationManager.OpenMappedExeConfiguration(file_map, ConfigurationUserLevel.None);
			return config;
		}
	}

}
