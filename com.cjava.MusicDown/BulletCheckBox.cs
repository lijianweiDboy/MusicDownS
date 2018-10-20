using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace com.winne.MusicDown
{
	public class BulletCheckBox : CheckBox, IComponentConnector
	{
		public static readonly DependencyProperty TextProperty;

		public static readonly DependencyProperty CheckedTextProperty;

		public static readonly DependencyProperty CheckedForegroundProperty;

		public static readonly DependencyProperty CheckedBackgroundProperty;

		private bool _contentLoaded;

		public string Text
		{
			get
			{
				return (string)base.GetValue(BulletCheckBox.TextProperty);
			}
			set
			{
				base.SetValue(BulletCheckBox.TextProperty, value);
			}
		}

		public string CheckedText
		{
			get
			{
				return (string)base.GetValue(BulletCheckBox.CheckedTextProperty);
			}
			set
			{
				base.SetValue(BulletCheckBox.CheckedTextProperty, value);
			}
		}

		public Brush CheckedForeground
		{
			get
			{
				return (Brush)base.GetValue(BulletCheckBox.CheckedForegroundProperty);
			}
			set
			{
				base.SetValue(BulletCheckBox.CheckedForegroundProperty, value);
			}
		}

		public Brush CheckedBackground
		{
			get
			{
				return (Brush)base.GetValue(BulletCheckBox.CheckedBackgroundProperty);
			}
			set
			{
				base.SetValue(BulletCheckBox.CheckedBackgroundProperty, value);
			}
		}

		public BulletCheckBox()
		{
			this.InitializeComponent();
		}

		static BulletCheckBox()
		{
			BulletCheckBox.TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(BulletCheckBox), new PropertyMetadata("Off"));
			BulletCheckBox.CheckedTextProperty = DependencyProperty.Register("CheckedText", typeof(string), typeof(BulletCheckBox), new PropertyMetadata("On"));
			BulletCheckBox.CheckedForegroundProperty = DependencyProperty.Register("CheckedForeground", typeof(Brush), typeof(BulletCheckBox), new PropertyMetadata(Brushes.WhiteSmoke));
			BulletCheckBox.CheckedBackgroundProperty = DependencyProperty.Register("CheckedBackground", typeof(Brush), typeof(BulletCheckBox), new PropertyMetadata(Brushes.LimeGreen));
			FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(BulletCheckBox), new FrameworkPropertyMetadata(typeof(BulletCheckBox)));
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/com.winne.MusicDown;component/controls/bulletcheckbox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}
	}
}
