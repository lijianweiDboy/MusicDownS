   M S B A M L   `   `   `  ����   com.winne.MusicDown#    com.winne.MusicDown.MVWindown   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  MV观看�� � WindowStyle$
 None=� � AllowsTransparency . ���#0FD3D3 � ShowInTaskbar .  J� SnapsToDevicePixels .  � WindowStartupLocation$ CenterOwner=���Z� .����  �� CornerRadius$ 5�����#000000
����� �$��1q�._��  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �$��20��.+��� -    ��Name$ WindowTitle��
��������� 	 �� Orientation$	 
Horizontal=�$��Right=�$��0,0,6,0q�.+��� -   
 ��Name$
 btnMin��   CloseBtnStyle#��[  $��20��$��18(�$	��Top=�$	��3,0q�.���� $��/Images/Min.png���� -   $
 btnMax��#��[  $��20��$��18(�$	��Top=�$	��3,0q�.���� $��/Images/Max.png���� -   $
 btnClose��#��[  $��20��$��18(�$	��Top=�$	��3,0q�.���� $��/Images/Close.png��r� -    r�Name$ MvPlayer��$��1�� J� 	CacheMode &   System.Windows.Media.BitmapCache     RenderAtScale$ 1Q�   EnableClearType .     SnapsToDevicePixels .  �� -   $
 btnPause��$��1�� J� Opacity$ 0Q�� $��2�� � ColumnDefinitions �� $��* ��� $
��auto �.+��� -    ��Name$ 
sliderPlay��$
��Left=� � Maximum$	 100Q�$��0��  Slider_CustomStyleVolume#��[ $��0�� �� IsMoveToPointEnabled .  � Cursor$
 Hand��$	��5,0q��� -	    ��Name$ textDuration��$��4q�
��� ���$��00:00 / 00:00��$��1��