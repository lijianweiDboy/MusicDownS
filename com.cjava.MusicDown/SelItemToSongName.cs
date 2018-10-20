using System;
using System.Globalization;
using System.Windows.Data;

namespace com.winne.MusicDown
{
	public class SelItemToSongName : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			SongInfo songInfo = value as SongInfo;
			if (songInfo == null)
			{
				return "停止";
			}
			return "正在播放:" + songInfo.Name + " - " + songInfo.SingerName;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
