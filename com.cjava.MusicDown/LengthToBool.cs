using System;
using System.Globalization;
using System.Windows.Data;

namespace com.winne.MusicDown
{
	public class LengthToBool : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			long num;
			if (!long.TryParse(value.ToString(), out num))
			{
				return false;
			}
			if (num == 0L)
			{ 
				return true;
			}
			return false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
