   M S B A M L   `   `   `  ���� U  Qcom.winne.MusicDown, Version=3.2.6859.39188, Culture=neutral, PublicKeyToken=null9!clr-namespace:com.winne.MusicDowncom.winne.MusicDown      com.winne.MusicDown.App   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     3loacl!clr-namespace:com.winne.MusicDown       �� ShutdownMode$  OnMainWindowClose=� �� 	Resources  �� 
TargetType   CloseBtnStyle �� Property �� Value �� 
TargetType ��Name ��Name J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value �� 
TargetName �� Color �� Opacity  LabelUI  Slider_RepeatButton �� CornerRadius  Slider_RepeatButton1  SliderThumb �� 
StartPoint �� EndPoint � Offset � Color  Slider_Thumb � ColumnDefinitions  Slider_CustomStyle J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth   Color ]�Name ]� DecreaseRepeatButton ]� IncreaseRepeatButton ]� Thumb  Slider_CustomStyleVolume��%�  &	        &	 ,    &	 
    &	 i    &	 �    &	 �    7  &	 �    7  7  7  &	 �    7  7  7  �� " ��.���  � ��
 �������  � �� �� " ��.R�� .+��� $ CloseBtnBackRec��
������ �� $ CloseContent��# z #��z��#��z����. 	 P� 
 �@J�IsMouseOver . . ��� $ CloseBtnBackRec�� � �� �� $
 Teal��$	 0.5Q���  �@�Cursor$
 Hand���� " ��.���  � ��
 � �����  � �� �� " ��.R��� .+��� $ UpdateContent��# z #��z��#��z����. 	 P� 
 �@J�IsMouseOver . . ���  � ��
 �������  �@�Cursor$
 Hand���� " ��.���  � |� .  ��  � �� �� " ��.R��� $��3��
��� ���$ 0���� " ��.���  � |� .  ��  � �� �� " ��.R��� ���#666666$��3���� $	 0,0&�$	 0,1&�.��� $ 0Q�$ #0FD3D3���� " n�.���  � |� .  ��  �@�Cursor$
 Hand����  � �� �� " n�.R��  �� �� .+��� $��2��$ 4��$��8��8��  $��8���� " ��.���  � |� .  ��  � �� �� " ��.R��    $ 10Q�$ 1Q�$ White��.+��� $��1��
�������$��1q�$ 8��._�]� $ 
PART_Track��$��1�� �� 8��  $��Slider.DecreaseLarge�� �� 8�� $��Slider.IncreaseLarge�� n� 8�� �� " ��.���  � |� .  ��  � �� �� " ��.R�� .+�]� $ 
PART_Track��$��1�� �� 8��  $��Slider.DecreaseLarge�� �� 8�� $��Slider.IncreaseLarge�� n� 8�� 