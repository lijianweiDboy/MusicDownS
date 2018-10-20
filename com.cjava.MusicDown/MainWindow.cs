using com.winne.MusicDown.Models;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace com.winne.MusicDown
{
	public class MainWindow : Window, IComponentConnector, IStyleConnector
	{
		private delegate void DownFile(string s, string s1);

		private string qqUrlHeader = "https://y.qq.com/n/yqq/song/";

		private DispatcherTimer timer;

		public static ObservableCollection<Lyric> lrc;

		private bool Repeat;

		private bool DEBUG;

		internal TextBlock WinTitle;

		internal System.Windows.Controls.Label UpdateVersion;

		internal System.Windows.Controls.Button btnMin;

		internal System.Windows.Controls.Button btnClose;

		internal System.Windows.Controls.TextBox searchWord;

		internal System.Windows.Controls.ListView SongListView;

		internal MediaElement player;

		internal Slider sliderPlay;

		internal TextBlock TbLrcLine;

		internal Run CurrentLrcTxt;

		internal SolidColorBrush CurrentLrcColor;

		internal Run NextLrcTxt;

		internal TextBlock textDuration;

		internal System.Windows.Controls.Button btnPlay;

		internal System.Windows.Controls.Button btnPrev;

		internal System.Windows.Controls.Button btnNext;

		internal System.Windows.Controls.Button btnRepeat;

		internal Slider sliderPlayVolume;

		internal BulletCheckBox LrcDown;

		internal System.Windows.Controls.TextBox SaveFloder;

		private bool _contentLoaded;

		public MainWindow()
		{
			this.InitializeComponent();
		}

		private void WindowDrag(object sender, MouseButtonEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				base.DragMove();
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.Button button = e.OriginalSource as System.Windows.Controls.Button;
			if (button != null)
			{
				if (button.Name == "btnClose")
				{
					base.Close();
					return;
				}
				if (button.Name == "btnMin")
				{
					base.WindowState = WindowState.Minimized;
					return;
				}
				if (button.Name == "btnSearch")
				{
					this.SongListView.ItemsSource = this.SearchSongs(this.searchWord.Text);
				}
			}
		}

		private ObservableCollection<SongInfo> SearchSongs(object word)
		{
			return HttpHelper.GetSongInfoFromNet("https://c.y.qq.com/soso/fcgi-bin/client_search_cp?ct=24&qqmusic_ver=1298&new_json=1&remoteplace=txt.yqq.center&searchid=47105719578687519&t=0&aggr=1&cr=1&catZhida=1&lossless=0&flag_qc=0&p=1&n=200&w=", word.ToString());
		}

		private void searchWord_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.SongListView.ItemsSource = this.SearchSongs(this.searchWord.Text);
			}
		}

		private void SaveFloder_GotFocus(object sender, RoutedEventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = true;
			if (this.SaveFloder.Text != "")
			{
				folderBrowserDialog.SelectedPath = this.SaveFloder.Text;
			}
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.SaveFloder.Text = folderBrowserDialog.SelectedPath;
				this.searchWord.Focus();
			}
		}

		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (base.WindowState == WindowState.Maximized)
			{
				base.WindowState = WindowState.Normal;
			}
		}

		private void player_MediaOpened(object sender, RoutedEventArgs e)
		{
			try
			{
				if (this.sliderPlay.Value != 0.0)
				{
					this.player.Position = TimeSpan.FromSeconds(this.sliderPlay.Value);
				}
				this.player.LoadedBehavior = MediaState.Manual;
				this.player.Play();
				this.sliderPlay.Maximum = this.player.NaturalDuration.TimeSpan.TotalSeconds;
				this.textDuration.Text = "00:00 / " + CommonHelper.IntToTimeString((int)this.player.NaturalDuration.TimeSpan.TotalSeconds);
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
			if (this.player.NaturalDuration.HasTimeSpan)
			{
				this.textDuration.Text = CommonHelper.IntToTimeString((int)this.player.Position.TotalSeconds) + "/ " + CommonHelper.IntToTimeString((int)this.player.NaturalDuration.TimeSpan.TotalSeconds);
				this.sliderPlay.Value = this.player.Position.TotalSeconds;
				int num = 0;
				if (MainWindow.lrc == null)
				{
					this.NextLrcTxt.Text = "(暂无匹配歌词)";
					return;
				}
				if (MainWindow.lrc.Count != 0)
				{
					for (int i = num; i < MainWindow.lrc.Count; i++)
					{
						if (this.player.Position >= MainWindow.lrc[i].Time && MainWindow.lrc[i].Text != "")
						{
							if (i + 1 >= MainWindow.lrc.Count)
							{
								this.CurrentLrcTxt.Text = MainWindow.lrc[i].Text;
								return;
							}
							if (this.player.Position < MainWindow.lrc[i + 1].Time)
							{
								if (i < MainWindow.lrc.Count - 1)
								{
									this.CurrentLrcTxt.Text = MainWindow.lrc[i].Text;
									this.NextLrcTxt.Text = MainWindow.lrc[i + 1].Text;
									return;
								}
								this.CurrentLrcTxt.Text = MainWindow.lrc[i].Text;
								return;
							}
						}
					}
				}
			}
		}

		private void player_MediaEnded(object sender, RoutedEventArgs e)
		{
			this.timer.Stop();
			if (this.Repeat)
			{
				this.player.Stop();
				this.player.Play();
				this.timer.Start();
				return;
			}
			if (this.SongListView.SelectedIndex < this.SongListView.Items.Count - 1)
			{
				this.SongListView.SelectedIndex++;
			}
		}

		private void player_MediaFailed(object sender, ExceptionRoutedEventArgs e)
		{
			if (this.SongListView.SelectedIndex < this.SongListView.Items.Count - 1)
			{
				this.SongListView.SelectedIndex++;
			}
		}

		private void SaveFloder_TextChanged(object sender, TextChangedEventArgs e)
		{
			CommonHelper.SaveCurrentPath(this.SaveFloder.Text);
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			this.WinTitle.Text = "[免费]无损音乐下载器-V" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
			this.SaveFloder.Text = CommonHelper.GetLastPathSet();
			if (!this.DEBUG)
			{
				Version version = Assembly.GetExecutingAssembly().GetName().Version;
				string newVersion = HttpHelper.GetNewVersion(version);
				if (newVersion == "当前已经是最新版")
				{
					return;
				}
				string[] array = newVersion.Split(new char[]
				{
					';'
				});
				System.Windows.MessageBox.Show(array[2], "新版本", MessageBoxButton.OK, MessageBoxImage.Asterisk);
				System.Windows.Clipboard.SetDataObject(array[1]);
				Process.Start(array[0]);
			}
		}

		private void sliderPlay_DragCompleted(object sender, DragCompletedEventArgs e)
		{
			if (this.player.Source != null)
			{
				this.player.Position = TimeSpan.FromSeconds(this.sliderPlay.Value);
			}
			if (this.timer != null)
			{
				this.player.Play();
				this.timer.Start();
			}
		}

		private void sliderPlay_DragStarted(object sender, DragStartedEventArgs e)
		{
			if (this.timer != null)
			{
				this.player.Pause();
				this.timer.Stop();
			}
		}

		private void StackPanel_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.Button button = e.OriginalSource as System.Windows.Controls.Button;
			if (button != null)
			{
				if (button.Tag != null && button.Tag.ToString() == "play")
				{
					if (this.SongListView.SelectedItem == null && this.SongListView.Items.Count > 0)
					{
						this.SongListView.SelectedItem = this.SongListView.Items[0];
					}
					this.player.LoadedBehavior = MediaState.Manual;
					this.player.Play();
					Uri uriSource = new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute);
					BitmapImage source = new BitmapImage(uriSource);
					new Image();
					Image image = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(button, 0), 0) as Image;
					if (image != null)
					{    
						image.Source = source; 
						button.Tag = "pause";
						return;
					}
				}
				else if (button.Tag != null && button.Tag.ToString() == "pause")
				{
					this.player.LoadedBehavior = MediaState.Manual;
					this.player.Pause();
					Uri uriSource2 = new Uri("Images\\play.png", UriKind.RelativeOrAbsolute);
					BitmapImage source2 = new BitmapImage(uriSource2);
					new Image();
					Image image2 = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(button, 0), 0) as Image;
					if (image2 != null)
					{
						image2.Source = source2;
						button.Tag = "play";
					}
				}
			}
		}

		private void SongListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.sliderPlay.Value = 0.0;
			this.NextLrcTxt.Text = "歌词匹配中……";
			this.CurrentLrcTxt.Text = "";
			Uri uriSource = new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute);
			System.Windows.Controls.Button button = this.btnPlay;
			BitmapImage source = new BitmapImage(uriSource);
			new Image();
			Image image = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(button, 0), 0) as Image;
			if (image != null)
			{
				image.Source = source; 
				button.Tag = "pause";
			}
		}

		private void sliderPlay_DragDelta(object sender, DragDeltaEventArgs e)
		{
			if (this.player.Source != null)
			{
				this.player.Position = TimeSpan.FromSeconds(this.sliderPlay.Value);
			}
			if (this.timer != null)
			{
				this.player.Play();
				this.timer.Start();
			}
		}

		private void sliderPlay_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			this.player.Position = TimeSpan.FromSeconds(e.NewValue);
		}

		private void StackPanel_Click_1(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.Button button = e.OriginalSource as System.Windows.Controls.Button;
			ContentPresenter contentPresenter = button.TemplatedParent as ContentPresenter;
			SongInfo songInfo = contentPresenter.Content as SongInfo;
			this.qqUrlHeader +=button.CommandParameter.ToString() + ".html";
			string songUrl = HttpHelper.GetSongUrl(songInfo.Mid, button.CommandParameter.ToString());
			if (songUrl != null)
			{
				if (this.SaveFloder.Text != "")
				{
					if (!this.SaveFloder.Text.EndsWith("\\"))
					{
						System.Windows.Controls.TextBox expr_94 = this.SaveFloder;
						expr_94.Text += "\\";
					}
					HttpHelper.DownFile(songUrl, string.Concat(new string[]
					{
						this.SaveFloder.Text,
						songInfo.SingerName,
						" - ",
						songInfo.Name,
						".",
						button.CommandParameter.ToString()
					}), songInfo.PD);
					if (this.LrcDown.IsChecked == true && !File.Exists(string.Concat(new string[]
					{
						this.SaveFloder.Text,
						songInfo.SingerName,
						" - ",
						songInfo.Name,
						".lrc"
					})))
					{
						FileInfo fileInfo = new FileInfo(string.Concat(new string[]
						{
							this.SaveFloder.Text,
							songInfo.SingerName,
							" - ",
							songInfo.Name,
							".lrc"
						}));
						using (StreamWriter streamWriter = fileInfo.CreateText())
						{
							streamWriter.Write(HttpHelper.GetLyric(songInfo));
							streamWriter.Flush();
						}
					}
					return;
				}
				Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
				saveFileDialog.FileName = songInfo.SingerName + " - " + songInfo.Name;
				saveFileDialog.Filter = "歌曲格式|*." + button.CommandParameter.ToString();
				if (saveFileDialog.ShowDialog() == true)
				{
					HttpHelper.DownFile(songUrl, saveFileDialog.FileName, songInfo.PD);
					return;
				}
			}
			else
			{
				System.Windows.MessageBox.Show("此曲目暂无无损格式！，请搜索曲目名称查看更多其它资源");
			}
		}

		private void MvButton_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Controls.Button button = e.OriginalSource as System.Windows.Controls.Button;
			ContentPresenter contentPresenter = button.TemplatedParent as ContentPresenter;
			SongInfo songInfo = contentPresenter.Content as SongInfo;
			if (songInfo.MV.StartsWith(":"))
			{
				return;
			}
			string[] array = songInfo.MV.Split(new char[]
			{
				':'
			});
			string mvFileAddress = HttpHelper.GetMvFileAddress(array[0]);
			if (mvFileAddress != "获取失败")
			{
				this.SetMvSource(new Uri(mvFileAddress), int.Parse(array[1]), songInfo.SingerName + " - " + songInfo.Name);
			}
		}

		private void SetMvSource(Uri uri, int index, string winTitle)
		{
			MVWindown mVWindown = MVWindown.CreateIntestance(uri, index, winTitle);
			mVWindown.OnMvPlayFinish += new MVWindown.MvEventHandler(this.mv_OnMvPlayFinish);
			mVWindown.Show();
		}

		private void mv_OnMvPlayFinish(object sender, RoutedMvEnectArgs e)
		{
			SongInfo songInfo = (SongInfo)this.SongListView.Items[e.CurrentIndex + 1];
			while (songInfo.MV.StartsWith(":"))
			{
				if (this.SongListView.Items.Count - 1 <= e.CurrentIndex)
				{
					return;
				}
				songInfo = (SongInfo)this.SongListView.Items[++e.CurrentIndex];
			}
			string[] array = songInfo.MV.Split(new char[]
			{
				':'
			});
			string mvFileAddress = HttpHelper.GetMvFileAddress(array[0]);
			if (mvFileAddress != "获取失败")
			{
				this.SetMvSource(new Uri(mvFileAddress), int.Parse(array[1]), songInfo.SingerName + " - " + songInfo.Name);
			}
		}

		private void Window_Closing(object sender, CancelEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}

		private void btnPrev_Click(object sender, RoutedEventArgs e)
		{
			if (this.SongListView.Items.Count <= 0)
			{
				return;
			}
			if (this.SongListView.SelectedItem == null)
			{
				this.SongListView.SelectedItem = this.SongListView.Items[0];
				return;
			}
			if (this.SongListView.SelectedIndex == 0)
			{
				this.SongListView.SelectedItem = this.SongListView.Items[this.SongListView.Items.Count - 1];
				return;
			}
			this.SongListView.SelectedIndex = this.SongListView.SelectedIndex - 1;
		}

		private void btnNext_Click(object sender, RoutedEventArgs e)
		{
			if (this.SongListView.Items.Count <= 0)
			{
				return;
			}
			if (this.SongListView.SelectedItem == null)
			{
				this.SongListView.SelectedItem = this.SongListView.Items[0];
				return;
			}
			if (this.SongListView.SelectedIndex == this.SongListView.Items.Count - 1)
			{
				this.SongListView.SelectedItem = 0;
				return;
			}
			this.SongListView.SelectedIndex = this.SongListView.SelectedIndex + 1;
		}

		private void UpdateVersion_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			string newVersion = HttpHelper.GetNewVersion(version);
			if (newVersion == "当前已经是最新版" || newVersion.Contains("版本检测出错"))
			{
				System.Windows.MessageBox.Show(newVersion);
				return;
			}
			string[] array = newVersion.Split(new char[]
			{
				';'
			});
			System.Windows.MessageBox.Show(array[2], "新版本", MessageBoxButton.OK, MessageBoxImage.Asterisk);
			System.Windows.Clipboard.SetDataObject(array[1]);
			Process.Start(array[0]);
		}

		private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			TextBlock textBlock = e.OriginalSource as TextBlock;
			ContentPresenter contentPresenter = textBlock.TemplatedParent as ContentPresenter;
			SongInfo songInfo = contentPresenter.Content as SongInfo;
			this.SongListView.ItemsSource = HttpHelper.GetAlbumSongs(songInfo.AlbumName, songInfo.AlbumMID);
		}

		private void btnRepeat_Click(object sender, RoutedEventArgs e)
		{
			if (this.btnRepeat.Tag.ToString() == "off")
			{
				this.Repeat = true;
				this.btnRepeat.Tag = "on";
				Uri uriSource = new Uri("Images\\repeatON.png", UriKind.RelativeOrAbsolute);
				BitmapImage source = new BitmapImage(uriSource);
				Image image = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(this.btnRepeat, 0), 0) as Image;
				image.Source = source;
				return;
			}
			if (this.btnRepeat.Tag.ToString() == "on")
			{
				this.Repeat = false;
				this.btnRepeat.Tag = "off";
				Uri uriSource2 = new Uri("Images\\repeatOFF.png", UriKind.RelativeOrAbsolute);
				BitmapImage source2 = new BitmapImage(uriSource2);
				Image image2 = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(this.btnRepeat, 0), 0) as Image;
				image2.Source = source2;
			}
		}

		private void btnHotTop_Click(object sender, RoutedEventArgs e)
		{
			this.SongListView.ItemsSource = HttpHelper.GetHotTop(60);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/com.winne.MusicDown;component/mainwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		internal Delegate _CreateDelegate(Type delegateType, string handler)
		{
			return Delegate.CreateDelegate(delegateType, this, handler);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((MainWindow)target).MouseLeftButtonDown += new MouseButtonEventHandler(this.WindowDrag);
				((MainWindow)target).SizeChanged += new SizeChangedEventHandler(this.Window_SizeChanged);
				((MainWindow)target).Loaded += new RoutedEventHandler(this.Window_Loaded);
				((MainWindow)target).Closing += new CancelEventHandler(this.Window_Closing);
				return;
			case 4:
				this.WinTitle = (TextBlock)target;
				return;
			case 5:
				((StackPanel)target).AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new RoutedEventHandler(this.Button_Click));
				return;
			case 6:
				this.UpdateVersion = (System.Windows.Controls.Label)target;
				this.UpdateVersion.MouseDown += new MouseButtonEventHandler(this.UpdateVersion_MouseDown);
				return;
			case 7:
				this.btnMin = (System.Windows.Controls.Button)target;
				return;
			case 8:
				this.btnClose = (System.Windows.Controls.Button)target;
				return;
			case 9:
				this.searchWord = (System.Windows.Controls.TextBox)target;
				this.searchWord.KeyUp += new System.Windows.Input.KeyEventHandler(this.searchWord_KeyUp);
				return;
			case 10:
				this.SongListView = (System.Windows.Controls.ListView)target;
				this.SongListView.SelectionChanged += new SelectionChangedEventHandler(this.SongListView_SelectionChanged);
				return;
			case 14:
				this.player = (MediaElement)target;
				this.player.MediaOpened += new RoutedEventHandler(this.player_MediaOpened);
				this.player.MediaEnded += new RoutedEventHandler(this.player_MediaEnded);
				this.player.MediaFailed += new EventHandler<ExceptionRoutedEventArgs>(this.player_MediaFailed);
				return;
			case 15:
				this.sliderPlay = (Slider)target;
				this.sliderPlay.AddHandler(Thumb.DragCompletedEvent, new DragCompletedEventHandler(this.sliderPlay_DragCompleted));
				this.sliderPlay.AddHandler(Thumb.DragStartedEvent, new DragStartedEventHandler(this.sliderPlay_DragStarted));
				this.sliderPlay.AddHandler(Thumb.DragDeltaEvent, new DragDeltaEventHandler(this.sliderPlay_DragDelta));
				this.sliderPlay.ValueChanged += new RoutedPropertyChangedEventHandler<double>(this.sliderPlay_ValueChanged);
				return;
			case 16:
				this.TbLrcLine = (TextBlock)target;
				return;
			case 17:
				this.CurrentLrcTxt = (Run)target;
				return;
			case 18:
				this.CurrentLrcColor = (SolidColorBrush)target;
				return;
			case 19:
				this.NextLrcTxt = (Run)target;
				return;
			case 20:
				this.textDuration = (TextBlock)target;
				return;
			case 21:
				((StackPanel)target).AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new RoutedEventHandler(this.StackPanel_Click));
				return;
			case 22:
				this.btnPlay = (System.Windows.Controls.Button)target;
				return;
			case 23:
				this.btnPrev = (System.Windows.Controls.Button)target;
				this.btnPrev.Click += new RoutedEventHandler(this.btnPrev_Click);
				return;
			case 24:
				this.btnNext = (System.Windows.Controls.Button)target;
				this.btnNext.Click += new RoutedEventHandler(this.btnNext_Click);
				return;
			case 25:
				this.btnRepeat = (System.Windows.Controls.Button)target;
				this.btnRepeat.Click += new RoutedEventHandler(this.btnRepeat_Click);
				return;
			case 26:
				this.sliderPlayVolume = (Slider)target;
				return;
			case 27:
				this.LrcDown = (BulletCheckBox)target;
				return;
			case 28:
				this.SaveFloder = (System.Windows.Controls.TextBox)target;
				this.SaveFloder.GotFocus += new RoutedEventHandler(this.SaveFloder_GotFocus);
				this.SaveFloder.TextChanged += new TextChangedEventHandler(this.SaveFloder_TextChanged);
				return;
			}
			this._contentLoaded = true;
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.Button_Click);
				return;
			case 3:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.btnHotTop_Click);
				return;
			default:
				switch (connectionId)
				{
				case 11:
					((TextBlock)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.TextBlock_MouseLeftButtonUp);
					return;
				case 12:
					((StackPanel)target).AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new RoutedEventHandler(this.StackPanel_Click_1));
					return;
				case 13:
					((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.MvButton_Click);
					return;
				default:
					return;
				}
				break;
			}
		}
	}
}
