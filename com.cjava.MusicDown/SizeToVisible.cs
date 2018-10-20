using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace com.winne.MusicDown
{
	public class SizeToVisible : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double num = double.Parse(value.ToString());
			if (num == 0.0)
			{
				return Visibility.Hidden;
			}
			return Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
