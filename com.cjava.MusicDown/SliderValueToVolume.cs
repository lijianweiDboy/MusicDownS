using System;
using System.Globalization;
using System.Windows.Data;

namespace com.winne.MusicDown
{
	public class SliderValueToVolume : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double num = double.Parse(value.ToString());
			return num / 100.0;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double num = double.Parse(value.ToString());
			return num * 100.0;
		}
	}
}
