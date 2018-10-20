using com.winne.MusicDown.Models;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace com.winne.MusicDown
{
	public class MVWindown : Window, IComponentConnector
	{
		public delegate void MvEventHandler(object sender, RoutedMvEnectArgs e);

		private static MVWindown mvWin;

		private DispatcherTimer timer;

		private int currentIndex;

		private bool isPause;

		internal Label WindowTitle;

		internal Button btnMin;

		internal Button btnMax;

		internal Button btnClose;

		internal MediaElement MvPlayer;

		internal Button btnPause;

		internal Slider sliderPlay;

		internal TextBlock textDuration;

		private bool _contentLoaded;

		public event MVWindown.MvEventHandler OnMvPlayFinish;

		public static MVWindown CreateIntestance(Uri uri, int index, string winTitle)
		{
			if (MVWindown.mvWin == null)
			{
				MVWindown.mvWin = new MVWindown(uri, index, winTitle);
			}
			MVWindown.mvWin.WindowTitle.Content = winTitle;
			MVWindown.mvWin.currentIndex = index;
			MVWindown.mvWin.MvPlayer.Source = uri;
			MVWindown.mvWin.sliderPlay.Value = 0.0;
			MVWindown.mvWin.WindowState = WindowState.Maximized;
			MVWindown.mvWin.Hide();
			return MVWindown.mvWin;
		}

		private MVWindown()
		{
			this.InitializeComponent();
		}

		private MVWindown(Uri uri, int index, string winTitle) : this()
		{
			this.MvPlayer.Source = uri;
			this.currentIndex = index;
			this.WindowTitle.Content = winTitle;
		}

		private void sliderPlay_DragCompleted(object sender, DragCompletedEventArgs e)
		{
			if (this.MvPlayer.Source != null)
			{
				this.MvPlayer.Position = TimeSpan.FromSeconds(this.sliderPlay.Value);
			}
			if (this.timer != null)
			{
				this.MvPlayer.Play();
				this.timer.Start();
			}
		}

		private void sliderPlay_DragStarted(object sender, DragStartedEventArgs e)
		{
			if (this.timer != null)
			{
				this.MvPlayer.Pause();
				this.timer.Stop();
			}
		}

		private void sliderPlay_DragDelta(object sender, DragDeltaEventArgs e)
		{
		}

		private void sliderPlay_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			this.MvPlayer.Position = TimeSpan.FromSeconds(e.NewValue);
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			base.Visibility = Visibility.Collapsed;
			this.MvPlayer.Source = null;
		}

		private void btnMin_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		private void WindowDrag(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			WindowState arg_08_0 = base.WindowState;
		}

		private void player_MediaOpened(object sender, RoutedEventArgs e)
		{
			try
			{
				if (this.sliderPlay.Value != 0.0)
				{
					this.MvPlayer.Position = TimeSpan.FromSeconds(this.sliderPlay.Value);
				}
				this.MvPlayer.LoadedBehavior = MediaState.Manual;
				this.MvPlayer.Play();
				this.sliderPlay.Maximum = this.MvPlayer.NaturalDuration.TimeSpan.TotalSeconds;
				this.textDuration.Text = "00:00 / " + CommonHelper.IntToTimeString((int)this.MvPlayer.NaturalDuration.TimeSpan.TotalSeconds);
				if (this.timer == null)
				{
					this.timer = new DispatcherTimer();
					this.timer.Interval = TimeSpan.FromSeconds(1.0);
					this.timer.Tick += new EventHandler(this.timer_tick);
				}
				this.timer.Start();
			}
			catch
			{
			}
		}

		private void timer_tick(object sender, EventArgs e)
		{
			if (this.MvPlayer.NaturalDuration.HasTimeSpan)
			{
				this.textDuration.Text = CommonHelper.IntToTimeString((int)this.MvPlayer.Position.TotalSeconds) + " / " + CommonHelper.IntToTimeString((int)this.MvPlayer.NaturalDuration.TimeSpan.TotalSeconds);
				this.sliderPlay.Value = this.MvPlayer.Position.TotalSeconds;
			}
		}

		private void MvPlayer_MediaEnded(object sender, RoutedEventArgs e)
		{
			this.timer.Stop();
			if (this.OnMvPlayFinish != null)
			{
				RoutedMvEnectArgs routedMvEnectArgs = new RoutedMvEnectArgs();
				routedMvEnectArgs.CurrentIndex = this.currentIndex;
				this.OnMvPlayFinish(sender, routedMvEnectArgs);
			}
		}

		private void btnMax_Click(object sender, RoutedEventArgs e)
		{
			if (base.WindowState == WindowState.Maximized)
			{
				base.WindowState = WindowState.Normal;
				Uri uriSource = new Uri("Images/Max.png", UriKind.RelativeOrAbsolute);
				BitmapImage source = new BitmapImage(uriSource);
				Image image = this.btnMax.Content as Image;
				if (image != null)
				{
					image.Source = source;
					return;
				}
			}
			else
			{
				base.WindowState = WindowState.Maximized;
				Uri uriSource2 = new Uri("Images/Nomal.png", UriKind.RelativeOrAbsolute);
				BitmapImage source2 = new BitmapImage(uriSource2);
				Image image2 = this.btnMax.Content as Image;
				if (image2 != null)
				{
					image2.Source = source2;
				}
			}
		}

		private void btnPause_Click(object sender, RoutedEventArgs e)
		{
			if (!this.isPause)
			{
				this.MvPlayer.Pause();
				this.isPause = true;
				this.timer.Stop();
				return;
			}
			this.MvPlayer.Play();
			this.isPause = false;
			this.timer.Start();
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/com.winne.MusicDown;component/mvwindown.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((MVWindown)target).MouseLeftButtonDown += new MouseButtonEventHandler(this.WindowDrag);
				((MVWindown)target).SizeChanged += new SizeChangedEventHandler(this.Window_SizeChanged);
				return;
			case 2:
				this.WindowTitle = (Label)target;
				return;
			case 3:
				this.btnMin = (Button)target;
				this.btnMin.Click += new RoutedEventHandler(this.btnMin_Click);
				return;
			case 4:
				this.btnMax = (Button)target;
				this.btnMax.Click += new RoutedEventHandler(this.btnMax_Click);
				return;
			case 5:
				this.btnClose = (Button)target;
				this.btnClose.Click += new RoutedEventHandler(this.btnClose_Click);
				return;
			case 6:
				this.MvPlayer = (MediaElement)target;
				this.MvPlayer.MediaOpened += new RoutedEventHandler(this.player_MediaOpened);
				this.MvPlayer.MediaEnded += new RoutedEventHandler(this.MvPlayer_MediaEnded);
				return;
			case 7:
				this.btnPause = (Button)target;
				this.btnPause.Click += new RoutedEventHandler(this.btnPause_Click);
				return;
			case 8:
				this.sliderPlay = (Slider)target;
				this.sliderPlay.AddHandler(Thumb.DragCompletedEvent, new DragCompletedEventHandler(this.sliderPlay_DragCompleted));
				this.sliderPlay.AddHandler(Thumb.DragStartedEvent, new DragStartedEventHandler(this.sliderPlay_DragStarted));
				this.sliderPlay.AddHandler(Thumb.DragDeltaEvent, new DragDeltaEventHandler(this.sliderPlay_DragDelta));
				this.sliderPlay.ValueChanged += new RoutedPropertyChangedEventHandler<double>(this.sliderPlay_ValueChanged);
				return;
			case 9:
				this.textDuration = (TextBlock)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}
	}
}
