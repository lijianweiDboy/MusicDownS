using System;
using System.ComponentModel;
using System.Windows;

namespace com.winne.MusicDown
{
	public class ProcessData : DependencyObject, INotifyPropertyChanged
	{
		public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register("MaxValueProperty", typeof(long), typeof(ProcessData), new PropertyMetadata(1000L));

		public static readonly DependencyProperty CurrentValueProperty = DependencyProperty.Register("CurrentValueProperty", typeof(long), typeof(ProcessData), new PropertyMetadata(0L));

		public static readonly DependencyProperty DownPercentProperty = DependencyProperty.Register("DownPercent", typeof(string), typeof(ProcessData), new PropertyMetadata(""));

		public event PropertyChangedEventHandler PropertyChanged;

		public long MaxValue
		{
			get
			{
				return (long)base.GetValue(ProcessData.MaxValueProperty);
			}
			set
			{
				base.SetValue(ProcessData.MaxValueProperty, value);
				this.OnPropertyChanged("MaxValue");
			}
		}

		public long CurrentValue
		{
			get
			{
				return (long)base.GetValue(ProcessData.CurrentValueProperty);
			}
			set
			{
				base.SetValue(ProcessData.CurrentValueProperty, value);
				this.OnPropertyChanged("CurrentValue");
			}
		}

		public string DownPercent
		{
			get
			{
				return (string)base.GetValue(ProcessData.DownPercentProperty);
			}
			set
			{
				base.SetValue(ProcessData.DownPercentProperty, value);
				this.OnPropertyChanged("DownPercent");
			}
		}

		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
