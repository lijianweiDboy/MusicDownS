using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Data;

namespace com.winne.MusicDown
{
	public class SelItemToSongUrlStr : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			object result;
			try
			{
				SongInfo songInfo = value as SongInfo;
				if (songInfo == null)
				{
					result = null;
				}
				else
				{
					Func<object, PlayInfo> function = new Func<object, PlayInfo>(HttpHelper.GetSongListenNew);
					Task<PlayInfo> task = Task.Factory.StartNew<PlayInfo>(function, songInfo);
					PlayInfo result2 = task.Result;
					MainWindow.lrc = result2.Lyrics;
					result = new Uri((result2 == null) ? "" : result2.SongUrl);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
