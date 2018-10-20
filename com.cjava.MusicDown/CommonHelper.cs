using System;
using System.IO;
using System.Text;

namespace com.winne.MusicDown
{
	public static class CommonHelper
	{
		public static string LrcSearch = "http://www.22lrc.com/search.php?keyword=";

		public static string LrcDownHeader = "http://www.22lrc.com/";

		public static string DownHrefRegexJiuKu = "<tr>.*?</tr>";

		public static string LyricLineRegex = "\\[(\\d+:\\d+\\.\\d+)\\](.*)";

		public static string IntToTimeString(int interval)
		{
			int num = interval / 60;
			int num2 = interval % 60;
			return string.Format("{0:00}", num) + ":" + string.Format("{0:00}", num2);
		}

		public static void SaveCurrentPath(string setPath)
		{
			string tempPath = Path.GetTempPath();
			try
			{
				File.WriteAllText(tempPath + "md.config", setPath, Encoding.UTF8);
			}
			catch
			{
			}
		}

		public static string GetLastPathSet()
		{
			string tempPath = Path.GetTempPath();
			if (File.Exists(tempPath + "md.config"))
			{
				using (TextReader textReader = File.OpenText(tempPath + "md.config"))
				{
					return textReader.ReadLine();
				}
			}
			return "";
		}

		public static double ConvertToMB(int kb)
		{
			return (double)kb / 1024.0 / 1024.0;
		}
	}
}
