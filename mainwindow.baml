   M S B A M L   `   `   `  ���� U  Qcom.winne.MusicDown, Version=3.2.6859.39188, Culture=neutral, PublicKeyToken=null9!clr-namespace:com.winne.MusicDowncom.winne.MusicDown  $    com.winne.MusicDown.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     3local!clr-namespace:com.winne.MusicDown     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  无损音乐下载器��$	��600��$	��770�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . ���#0FD3D3&   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�$��微软雅黑)� � Icon$ Images/Music.ico����Z�  � 	Resources (   "com.winne.MusicDown.BulletCheckBox �� 
TargetType �� Property	 �� Value
 �� 
TargetType (� Stretch ��Name J� SnapsToDevicePixels �� CornerRadius �� Orientation T� X ��Name   Text �� TextAlignment �� Triggers P� Property P� Value �� 
TargetName �� RelativeSource �� Mode �� Path N� EnterActions �� 
TargetName �� TargetProperty	 W� To g� Duration  N� ExitActions&    com.winne.MusicDown.LengthToBool   	textLen2b-   'com.winne.MusicDown.SelItemToSongUrlStr  sel2Uri+   %com.winne.MusicDown.SelItemToSongName  sel2Name-   'com.winne.MusicDown.SliderValueToVolume  sliderValue2Volume'   !com.winne.MusicDown.SizeToVisible  sizeToVisible'   !com.winne.MusicDown.VidToMvVisibl  vidToMvVisibl  MusicBtnStyle! �� Padding" ��Name# �� Color  TextBoxStyle$ �� BasedOn% ��Name& ��Name  CloseBtnStyle 	 TextBoxPathStyle' �� Value( �� Binding) �� 	Converter* �� Self 
 PlayerPlayBtnStyle+ ��Name3	  -System.Windows.Media.Effects.DropShadowEffect, 	  
BlurRadius- 	  ShadowDepth. 	  Color  PlayerRepeatBtnStyle  PlayerPrevBtnStyle  PlayerNextBtnStyle/ � ColumnDefinitions0 � RowDefinitions1 �� AllowsColumnReorder!2 �� ColumnHeaderContainerStyle3 �� ColumnHeaderToolTip4 �� ColumnHeaderStringFormat5 �� ColumnHeaderContextMenu6 �� ColumnHeaderTemplate7 �� Columns#8 �� ColumnHeaderTemplateSelector9 ��Name: �� CanContentScroll-
  'System.Windows.Input.KeyboardNavigation; 
  DirectionalNavigation< ��Name= � Cursor> �� ScrollableWidth? � Maximum@ � MinimumA �� Orientation,B �� %ComputedHorizontalScrollBarVisibilityC �� ViewportWidthD �� ViewportSize  ScrollBarStyleE � ValueF �� ModeG �� ScrollableHeight*H �� #ComputedVerticalScrollBarVisibilityI �� ViewportHeight  ListViewStyle1J ]� 
ConditionsK �� PropertyL �� Value  ListViewItemStyleM ��NameN �� Content 	 aaaaaO �� ContentStringFormatP �� ContentStringFormatQ n�Name  VerticalScrollBarPageButton  VerticalScrollBarThumb  HorizontalScrollBarThumb ! HorizontalScrollBarPageButton ! VerticalScrollBarButtomButtonR F�Name  VerticalScrollBarTopButton ! HorizontalScrollBarLeftButton " HorizontalScrollBarRightButtonS �NameT �� LineUpCommandU J� IsMouseOverV ]�NameW ]� DecreaseRepeatButtonX �� PageUpCommandY ]� IncreaseRepeatButtonZ �� PageDownCommand[ ]� Thumb\ �� LineDownCommand] �� Triggers^ �� LineLeftCommand_ �� PageLeftCommand` �� PageRightCommanda �� LineRightCommand  SimpleProgressBar  RadioButtonFocusVisual  NormalBrush  NormalBorderBrushb �� 
Backgroundc �� Bulletd A�Name  DisabledBackgroundBrush  SliderBackgrounde �� 
StartPointf �� EndPointg � Offseth � Color   
SliderText��%9/  '        &	  �    &	 �    &	 �    &	 �    &	      &	     &	 
    &	 =    7  7  &		 /	    7   &	
 �    &	     &	 k    &	 �    (��     *'%GridView.GridViewScrollViewerStyleKey+)&	 E    &	 a    &	 &    '�� 0    &	     &	 �    &	 �    &	 �    &	 6     &	 �!    &	 f#    &	 �$    &	 �&    7  7  7  7  7  7  7  7  7  7  &	 )    '	� �)    &	 �,    &	  H-    �� "  .���  � ��	 �	#FF666666��  � ��	 �#DDE8E1��  �@ CheckedBackground
	 �������  �@ CheckedForeground	 �	#FF136E66��  � ��$	 16(���  �@�Cursor$
	 Hand����  � ��$	 1q���  � ��	 �� "
  .R�(� $ Uniform=�$��Center=�$��Center=�.���� $ border��$��90��$��28��#��z�� . #��z��$ 14��._��� $ 
Horizontal=�.+��� $ state��$��24��$��24��$��3,2,1,2q�$ 12�� . #��z��z�T� 
transState��$ 0Q��� $	 txt��$��60��#��z��#��z $��Center=�$ Center=�z�T� transTxt��$ 0Q� P�  �@d�	IsChecked$
 TrueY�. ��� $	 txt��	 ��  �� $ TemplatedParent=�$ CheckedText� � ���� $ state��	 ��  �� $ TemplatedParent=�$ CheckedForeground� � ���� $	 txt��	 ��  �� $ TemplatedParent=�$ CheckedForeground� � ���� $ border��	 ��  �� $ TemplatedParent=�$ CheckedBackground� � �� �� .���� .��W� $ 
transState��$ X�$ 60X�$ 0:0:0.2D�W� $ transTxt��$ X�$	 -30X�$ 0:0:0.2D�  �� .���� .��W� $ 
transState��$ X�$ 0X�$ 0:0:0.2D�W� $ transTxt��$ X�$ 0X�$ 0:0:0.2D�P�  � {� .              �� " ��.���  � ��$	 2q���  � ��	 �� "
 ��.R�� .+��� $ CloseBtnBackRec��
�������$��1q�$! 1q�._��� $" CloseContent��# z #��z��#��z����.  P�  �@J�IsMouseOver . . ��� $ CloseBtnBackRec�� � ��	 �� $# White����  �@�Cursor$
	 Hand���� " ��$ Z� .���  � ��#	 � ����  � ��
	 ���� ��  � ��
	 �������  � ��
	 �������  � ��$	 1q���  � ��$	 1q���  �@J�	AllowDrop	 . ��  �@�FocusVisualStyle	 Z� ��  �@��PanningMode$	 VerticalFirst=���  �@��IsFlicksEnabled	 .  ��  � ��	 �� "
 ��.R��� $ Bd��#��z��#��z��#��z�� . $ 13��$! 	15,0,15,0q�._�� .+��� $% PART_ContentHost��# z �� $ 
Horizontal=�$��1��$��Right=�.+��� $& 	btnSearch��-   $	��4,0q�8��  .���� $��/Images/search.png��$��16��$��16���� $& 	btnHotTop��-   $	��4,0q�8�� .���� $��/Images/hottop.png��$��20��$��20�� P�  � {� .  . ��� $ Bd��#	 � �� � ���� #	 � �� � ���� " ��$ Z� .���  � ��#	 � ����  � ��
	 ���� ��  � ��
	 �������  � ��
	 ��� ���  � ��$	 1q���  � ��$	 1q���  �@J�	AllowDrop	 . ��  �@�FocusVisualStyle	 Z� ��  �@��PanningMode$	 VerticalFirst=���  �@��IsFlicksEnabled	 .  ��  � ��	 �� "
 ��.R��� $ Bd��
������ #��z��#��z�� . $! 	15,0,15,0q�._�� .+��� $% PART_ContentHost��# z  P�  � {� .  . ��� $ Bd��#	 � �� � ���� #	 � �� � ��P�  �@J�	IsFocused . . ��� $ Bd��#	 � �� � ���� $
' true��( �� *Text.Length+8)   # Z* .a��� $ Bd�� � ��
	 ��� ��� " ��.���  � ��
	 �������  � |�	 .  ��  � ��	 �� "
 ��.R�� .+��� $
+ icon��$��/Images/play.png��$��24��$��16���� $" CloseContent��# z #��z��#��z����.  P�  �@J�IsMouseOver . . ���  �@�Cursor$
	 Hand����  �@J�Effect	 	  $, 16Q�$- 1Q�$. White���� " ��.���  � ��
	 �������  � |�	 .  ��  � ��	 �� "
 ��.R�� .+��� $
+ icon��$��/Images/repeatOFF.png��$��24��$��16���� $" CloseContent��# z #��z��#��z����.  P�  �@J�IsMouseOver . . ���  �@�Cursor$
	 Hand����  �@J�Effect	 	  $, 16Q�$- 1Q�$. White���� " ��.���  � ��
	 �������  � |�	 .  ��  � ��	 �� "
 ��.R�� .+��� $
+ icon��$��/Images/prev.png��$��24��$��16���� $" CloseContent��# z #��z��#��z����.  P�  �@J�IsMouseOver . . ���  �@�Cursor$
	 Hand����  �@J�Effect	 	  $, 16Q�$- 1Q�$. White���� " ��.���  � ��
	 �������  � |�	 .  ��  � ��	 �� "
 ��.R�� .+��� $
+ icon��$��/Images/next.png��$��24��$��16���� $" CloseContent��# z #��z��#��z����.  P�  �@J�IsMouseOver . . ���  �@�Cursor$
	 Hand����  �@J�Effect	 	  $, 16Q�$- 1Q�$. White���� " ��.���  � |�	 .  ��  � ��	 �� "
 ��.R�� #��z�� . / �� $��* ��� $
��Auto �0 �� $��* ��� $
��Auto �.+�]� #��z��.+��� $	��Top=�|�.  $��Hidden=�$��Hidden=�.���� # z 1 �� **(TemplatedParent.View.AllowsColumnReorder+ �� *TemplatedParent+2 �� *1/TemplatedParent.View.ColumnHeaderContainerStyle+ �� *TemplatedParent+3 �� **(TemplatedParent.View.ColumnHeaderToolTip+ �� *TemplatedParent+4 �� */-TemplatedParent.View.ColumnHeaderStringFormat+ �� *TemplatedParent+5 �� *.,TemplatedParent.View.ColumnHeaderContextMenu+ �� *TemplatedParent+6 �� *+)TemplatedParent.View.ColumnHeaderTemplate+ �� *TemplatedParent+7 �� *TemplatedParent.View.Columns+ �� *TemplatedParent+8 �� *31TemplatedParent.View.ColumnHeaderTemplateSelector+ �� *TemplatedParent+�� $!9 PART_ScrollContentPresenter��#: z��#��z��#��z��$; Local=�# z �� $< PART_HorizontalScrollBar��$= Arrow��#? z> $	@ 0.0Q�$A 
Horizontal=�$��1��#y�zB #D zC #���  E �� *HorizontalOffset+$F OneWay=� �� *TemplatedParent+�� $< PART_VerticalScrollBar��$= Arrow��$��1��#? zG $	@ 0.0Q�$A Vertical=�#y�zH #D zI #���  E �� *VerticalOffset+$F OneWay=� �� *TemplatedParent+�� " ��.���  � ��$
	 Auto=���  � ��$
	 Auto=���  � ��	 . ��  �@��PanningMode$
	 Both=���  �@��IsFlicksEnabled	 .  ��  � ��	 �� "
 ��.R��� #��z��#��� $�.���� # z  ]� J �� K �@��
IsGroupingL . ./���  � ��	 .  �� " ��.���  � ��$	 Center=���  � ��	 . ��  � ��
	 �������  � ��	 �� "
 ��.R�� .+��� $M 	backgroud��
������ �� $��Center=�#N z��# z  P�  �@��
IsSelected . . ��� $ 	backgroud�� � ��	 �	#aa1C6072P�  �@J�IsMouseOver . . ��� $ 	backgroud�� � ��	 �	#88888888P�  � ��$
 Auto��. ���  � ��$	 35��P�  � {� .  . ���  �@J�Opacity$		 0.5Q��� " ���� " ��.���  � ��	 �	#00555555��  � ��	 �#0FD3D3��  � ��$	 16(���  � ��	 Z� ��  � ��	 �� "
 ��.R��  . .+��� $ HeaderBorder��#��z��#��z��._�� 0 �� $��7���� .+��� #! z��$��2��._��� $" HeaderContent��#��z��#��z��#P zO #��z����. # z #��z���� .+�n� $Q PART_HeaderGripper������ " n�.���  �@��Right$	 -9����  � ��$	 18����  � ��	 �� *ActualHeight+ �� *TemplatedParent+��  � ��$	 0q���  � ��
	 �������  � ��	 �� "
 n�.R��� 
������ #! z��._��� ���	#00555555$��Center=�$��1�� P�  �@J�IsMouseOver . . ��� $ HeaderBorder�� � ��	 �#444444�� $ PART_HeaderGripper�� � ��
	 ���� P�  � �� . . ��� $ HeaderBorder�� � ��	 �#FF866B�� $ PART_HeaderGripper�� � y�$	 Hidden=�P�  � ��$
 Auto��. ���  � ��$	 35��P�  � {� .  . ���  �@J�Opacity$		 0.5Q��� " ��.���  �@�OverridesDefaultStyle	 . ��  � ��
	 ���� ��  � |�	 .  ��  � ��	 .  ��  � ��	 �� "
 ��.R��� #��z��#��z��#��z���� " n�.���  �@�OverridesDefaultStyle	 . ��  � ��	 .  ��  � ��	 �� "
 n�.R��� $ bd��$��9��$ 5�����#D3D3D3 P�  �@J�IsMouseOver . . ��� $ bd�� � ��
	 ������� " n�.���  �@�OverridesDefaultStyle	 . ��  � ��	 .  ��  � ��	 �� "
 n�.R��� $ bd��$��9��$ 5�����#D3D3D3 P�  �@J�IsMouseOver . . ��� $ bd�� � ��
	 ������� " ��.���  �@�OverridesDefaultStyle	 . ��  � ��
	 ���� ��  � |�	 .  ��  � ��	 .  ��  � ��	 �� "
 ��.R��� #��z��#��z��#��z���� " ��.���  �@�OverridesDefaultStyle	 . ��  � |�	 .  ��  � ��	 .  ��  � ��	 �� "
 ��.R�F� $
R path��"���� 	= ��[ �@]� ��[ � �� @]� 	���#D3D3D3���#D3D3D3 P�  �@J�IsMouseOver . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 �����P�  � �� . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 ������� " ��.���  �@�OverridesDefaultStyle	 . ��  � |�	 .  ��  � ��	 .  ��  � ��	 �� "
 ��.R�F� $
R path��"���� 	= ��� �@]� ��� � �� ��- 	���#D3D3D3���#D3D3D3 P�  �@J�IsMouseOver . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 �����P�  � �� . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 ������� " ��.���  �@�OverridesDefaultStyle	 . ��  � |�	 .  ��  � ��	 .  ��  � ��	 �� "
 ��.R�F� $
R path��"�������  	= р�� @]� ���-  �� 	���#D3D3D3���#D3D3D3 P�  �@J�IsMouseOver . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 �����P�  � �� . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 ������� " ��.���  �@�OverridesDefaultStyle	 . ��  � |�	 .  ��  � ��	 .  ��  � ��	 �� "
 ��.R�F� $
R path��"������[  	= р�[ @]� �@]�  �� 	���#D3D3D3���#D3D3D3 P�  �@J�IsMouseOver . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 �����P�  � �� . . ��� $
 path�� � ��
	 ������� $
 path�� � ��
	 ������� " ��.���  � ��
	 ���� ��  � ��	 �� "
 ��.R�� $S Bg��#��z�� . 0 �� #��� q��� $��0.00001* ��� #��� q�.+��� #��ZT #{�zU 8��  ]� $V 
PART_Track����. #{�zU $��1��W �� #��ZX 8�� Y �� #��ZZ 8�� [ n� 8�� �� #��Z\ #{�zU $��2��8�� ] P�  �@��Orientation$ 
Horizontal=�. ���  � ��
	 ���� ��  � ��	 �� "
 ��.R�� $S Bg��#��z�� . / �� #��� ���� $��0.00001* ��� #��� ��.+��� #��Z^ #{�zU 8�� ]� $V 
PART_Track��$��1��#{�zU W �� #��Z_ 8�� Y �� #��Z` 8�� [ n� 8�� �� $��2��#��Za #{�zU 8��	 �� " �.���  � ��	 �� "
 �.R�� .+��� $M 
PART_Track��#��z���� $M PART_Indicator��$
��Left=����#1ABCBF�� " 	�.���  �@J�SnapsToDevicePixels	 . ��  �@�FocusVisualStyle#	 �  ��  � ��#	 �  ��  � ��#	 �  ��  �@�Cursor$
	 Hand����  � ��	 �� "
 	�.R��� 
b ���� c � $��13��$��13��.+�A� $d Ellipse_Border��#��z��#��z��$��1��A� $d 	CheckMark��$��4q�
�������._��� #��z��#��z��#��z����.  P�  �@d�	IsChecked$ falseY�. ��� $ 	CheckMark�� � y�$	 	Collapsed=��� $ 	CheckMark�� � ��
	 ���� P�  �@J�IsMouseOver . . ��� $ Ellipse_Border�� � ��	 �#C46C1AP�  � �� . . ��� $ Ellipse_Border�� � ��	 �#12C1B7�� $ Ellipse_Border�� � ��	 �#222222P�  � {� .  . ��� #	 �  $ Ellipse_Border�� � ���� $ Ellipse_Border�� � ��	 �	#40000000��  � ��	 �	#80000000�� $	e 0,0&�$	f 0,1&�.��� $g 0Q�$h #59ccfc��� $	g 0.5Q�$h #00b3fe��� $g 1Q�$h #59ccfc���� $	e 0,0&�$	f 0,1&�.��� $g 0Q�$h #7cce45��� $g 1Q�$h #4ea017��.���� $ 5��
����� �$��1q����� i �� ImageSource$i Images\macpro.jpg��j �� Opacity$	j 0.8Q�._�� ���	#995555550 �� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto �/ �� �� $
��auto �.+��� -   $ WinTitle��$��10,5,0,0q�$��16(��� -   $ 
Horizontal=�$��1��$��0,0,6,0q�.+��� -   k ��Name$k UpdateVersion��$	��新��$��Center=� ! LabelUI#��[! �� -   $& btnMin��#��[ $��20��$��18(�$	��Top=�$	��3,0q�.���� $��/Images/Min.png���� -   $& btnClose��#��[ $��20��$��18(�$	��Top=�$	��3,0q�.���� $��/Images/Close.png���� -	   l ��Name$l 
searchWord��$��1��$��20q�$��2��#��[ $��18(�m �� 
CaretBrush
m ������� -
   n ��Name$n SongListView��$��2��$��2��
������ #��[ o �� SelectionMode$o Single=���Z� p �� Viewp �� .P��� $��歌曲��q �� Width$	q 160��r �� CellTemplater �� .R��� .+��� $
��Left=����� *Name+�� $��10(����#888888$��Center=����� *ContinuedTime+�� $��歌手��$	q 180��s �� DisplayMemberBindings �� *
SingerName+�� $��专辑��$	q 125��r �� .R��� -   
�������$
= Hand������ *	AlbumName+
t � Tagt �� *
AlbumMID+�� $��音质��$	q 140��r �� .R��� -   $ 
Horizontal=�.+��� y��� *
FlacSize+#) [ .+��� $
��FLAC��
��� ���#��[ $
��flac���� $��10(�
�������$��Center=����� *
FlacSize+u �� StringFormat$u {0:F}���� y��� *	ApeSize+#) [ .+��� $	��APE��
��� ���#��[ $	��ape���� $��10(�
�������$��Center=����� *	ApeSize+$u {0:F}���� y��� *	Mp3Size+#) [ .+��� $	��MP3��
�������#��[ $	��mp3���� $��10(�
�������$��Center=����� *	Mp3Size+$u {0:F}���� $��MV��$q 40��r �� .R��� -   $��MV�����#03E3A5#��[ y��� *MV+#) [ �� $��下载进度��$	q 100��r �� .R�� $��Center=�$	��100��.+�� v �Name$v 
processBar��$��10�����	#99555555#��[ $@ 0Q�? �� *PD.MaxValue+E �� *PD.CurrentValue+�� $ 
tbPerecent�����#222222$��Center=����� *PD.DownPercent+w �� Triggersw �� $' 请切换格式重试��( �� *Text+x �� ElementName$x 
tbPerecent��.a��� $ 
tbPerecent�� � ��
	 �  ���� $ 
processBar�� �@�Value$	 0Q�� $��3��$��2��/ �� $
��auto ��� �� $
��auto �.+�r� -   y r�Name$y player��$
��auto��$
��auto��z r� Sourcez �� *SelectedItem+#) [ $x SongListView��{ r� Volume{ �� *Value+#) [ $x sliderPlayVolume��$F TwoWay=��� $��1��$��4q�.+��� 
��� ������� *SelectedItem+#) [ $x SongListView���� -   | ��Name$| 
sliderPlay��$	? 100Q�$��0�� " Slider_CustomStyleVolume#��[" } �� IsMoveToPointEnabled} . $
= Hand���� -   $ 	TbLrcLine��
�������~ � Triggers~ :�  :� RoutedEvent$ Loaded��.[��� .���� .���� $ CurrentLrcColor��$ Color�� �� From$� WhiteX�	� �� To$
� LimeX�� g� 	BeginTime$� 00:00:00X�$ 0:0:1D�� g� AutoReverse� . � g� RepeatBehavior$� 1���� -   � ��Name$� CurrentLrcTxt��$��16(�.����� $
# Gray��-   CurrentLrcColor��.� �� -   $� 
NextLrcTxt��
�������$��12(��� $��2��$��4q�$��Center=�.+��� -   $ textDuration��$��4q�
��� ���$��00:00/00:00��]� $��4��$��2����. 
������ .+��� -   $ 
Horizontal=�.+��� -   $& btnPlay��#��[
 $
t play��$	��2,0q��� -   $& btnPrev��#��[ $��pause��$	��2,0q��� -   $& btnNext��#��[ $��pause��$	��2,0q��� -   $& 	btnRepeat��#��[ $	t off��$	��2,0q��� $��/Images/volume.png��$��3��$��16��$��16��$
��Left=�$	��4,0q��� -   $| sliderPlayVolume��$	? 100Q�$��0��$��40��#��[" $@ 0Q�$E 40Q�} . $
= Hand���� $��存储路径:��$��14,0,5,0q�$��Center=�
��� ����� $	��赏��
�������$��Center=�$��Right=�$��16(�� ^� ShowDuration$� 60000��� � ToolTip� _� 
������ .���� $��Center=�$ Vertical=�.+��� $��技术交流 谢谢支持�����#33dd77$��Center=��� $ 
Horizontal=�.+��� $��/Images/wxds.png��$	��168��$	��240���� $��/Images/zfbhb.jpg��$	��168��$	��240���� $��/Images/zfbzf.jpg��$	��168��$	��240��  -   �  Name$� LrcDown��$��Right=�$��Center=��   CheckedText$� 	下词开��$ 	下词关��$��20���� -   $l 
SaveFloder��#��[	 $��6q�