   M S B A M L   `   `   `  ����N  JTestExerciser.Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TestExerciser.Diary.ControlsTestExerciser.Diary.Controls  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   WindowButton �� Property �� Value  WindowCloseButtonStyle �� BasedOn �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property P� Value	 �� 
TargetName  WindowRestoreButtonStyle  WindowMinButtonStyle  WindowMaxButtonStyle
 �� CornerRadius  SubmitButton  ShowHistoryButton  ShowPropertyButton ]� 
Conditions �� Property �� Value0    *TestExerciser.Diary.Controls.LoadingButton J� Opacity    ImageSource N� EnterActions ��Name g� RepeatBehavior �� 
TargetName �� TargetProperty	 W� To g� Duration N� ExitActions �� BeginStoryboardName  
SaveButton 	 SearchButton 
 DeleteKeywordsButton�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      7controls*clr-namespace:TestExerciser.Diary.Controls  5      %�&  &	        &	 �     7   &	 g    7   &	 @    7   &	 	    7   '�� �    &	     &	 �    &	 �    '   �    &	 �    7  &		 �    &	
 c"    �� 5      "  ��6   .�5   
   ��  � ��$ 20��6"   �� 5   
    � ��$ 20��6#   �� 5   
    � ��$ Center=�6.   5      �� 5
      "  ��6   8   .�5   
   ��  �@�ToolTip$ 关闭��6$   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $��bdPanel��6    . ._�5      �� $��
imgContent��6    $G��A/TestExerciser.Diary;component/Assets/Images/Buttons/btnClose.png��62   $��20��6}   $��20��6�   5       5      P� 5       �@J�IsMouseOver . . �5      �� $	 
imgContent��67    � ��$M G/TestExerciser.Diary;component/Assets/Images/Buttons/btnClose_Hover.png��6O   5      P� 5       � �� . . �5      �� $	 
imgContent��67    � ��$M G/TestExerciser.Diary;component/Assets/Images/Buttons/btnClose_Press.png��6O   5      5      5      5      �� 5       "  ��6   8   .�5!   
   ��  �@�ToolTip$ 还原��6$   �� 5"   
    � �� 5#      �� 5$      " ��6"   .R�5%      �� $��bdPanel��6    . ._�5&      �� $��
imgContent��6    $I��C/TestExerciser.Diary;component/Assets/Images/Buttons/btnRestore.png��62   $��20��6   $��20��6�   5'       5)      P� 5*       �@J�IsMouseOver . . �5+      �� $	 
imgContent��67    � ��$O I/TestExerciser.Diary;component/Assets/Images/Buttons/btnRestore_Hover.png��6O   5,      P� 5-       � �� . . �5.      �� $	 
imgContent��67    � ��$O I/TestExerciser.Diary;component/Assets/Images/Buttons/btnRestore_Press.png��6O   5/      51      53      54      �� 56      "  ��6   8   .�57   
   ��  �@�ToolTip$ 	最小化��6$   �� 58   
    � �� 59      �� 5:      " ��6"   .R�5;      �� $��bdPanel��6    . ._�5<      �� $��
imgContent��6    $E��?/TestExerciser.Diary;component/Assets/Images/Buttons/btnMin.png��62   $��20��6{   $��20��6�   5=       5?      P� 5@       �@J�IsMouseOver . . �5A      �� $	 
imgContent��67    � ��$K E/TestExerciser.Diary;component/Assets/Images/Buttons/btnMin_Hover.png��6O   5B      P� 5C       � �� . . �5D      �� $	 
imgContent��67    � ��$K E/TestExerciser.Diary;component/Assets/Images/Buttons/btnMin_Press.png��6O   5E      5G      5I      5J      �� 5L      "  ��6   8   .�5M   
   ��  �@�ToolTip$ 	最大化��6$   �� 5N   
    � �� 5O      �� 5P      " ��6"   .R�5Q      �� $��bdPanel��6    . ._�5R      �� $��
imgContent��6    $E��?/TestExerciser.Diary;component/Assets/Images/Buttons/btnMax.png��62   $��20��6{   $��20��6�   5S       5U      P� 5V       �@J�IsMouseOver . . �5W      �� $	 
imgContent��67    � ��$K E/TestExerciser.Diary;component/Assets/Images/Buttons/btnMax_Hover.png��6O   5X      P� 5Y       � �� . . �5Z      �� $	 
imgContent��67    � ��$K E/TestExerciser.Diary;component/Assets/Images/Buttons/btnMax_Press.png��6O   5[      5]      5_      5`      �� 5b      "  ��6   .�5c   
   ��  � �� 5d      �� 5e      " ��6"   .R�5f      �� $��Bd��6   $
 2��6'   $��1q�68   #��z��6L   #��z��6l   ���	#FF96999C���	#FFF2F4F5._�5g      �� $��Center=�6+   $��Center=�6H   5h       5i      P� 5j       � {� .  . �5k      �� $	 Bd��6;    � �� �	#FFF6F6F66_   �� 5l       � �� �	#EEC5C5C56E   5m      P� 5n       � �� . . �5o      �� $	 Bd��6;    � �� �	#FFE0E2E46K   5p      5r      5t      5u      �� 5w      "  ��6   .�5x   
   ��  � ��$	 100��6"   �� 5y   
    � ��$ 24��6#   �� 5z   
    � �� 5{      �� 5|      " ��6"   .R�5}      �� $��Bd��6:   
�������$
 2��6D   $��1q�6U   #��z��6i   #��z��6�   ���	#FF2C84DD���	#FF499FEF._�5~      �� $��Center=�6+   $��Center=�6H   5       5�      P� 5�       � {� .  . �5�      �� $	 Bd��6;    � �� �	#FFF6F6F66_   �� 5�      $	 Bd��6<    � �� �	#FFD1D5D66`   �� 5�      $	 Bd��6E    � �� �	#FF9E9E9E6U   5�      P� 5�       � �� . . �5�      �� $	 Bd��6;    � �� �	#FF3590E56K   �� 5�      $	 Bd��6<    � �� �	#FF1370CE6L   5�      5�      5�      5�      �� 5�      "  ��6   .�5�   
   ��  � ��$ 24��6"   �� 5�   
    � ��$ 24��6#   �� 5�   
    �@�ToolTip$ 历史版本��6$   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $��bdPanel��6    . ._�5�      �� $��
imgContent��6    $I��C/TestExerciser.Diary;component/Assets/Images/Buttons/btnHistory.png��62   5�       5�      P� 5�       �@J�IsMouseOver . . �5�      �� $	 
imgContent��67    � ��$O I/TestExerciser.Diary;component/Assets/Images/Buttons/btnHistory_Hover.png��6O   5�      P� 5�       � �� . . �5�      �� $	 
imgContent��67    � ��$O I/TestExerciser.Diary;component/Assets/Images/Buttons/btnHistory_Press.png��6O   5�      P� 5�       � {� .  . �5�      �� $	 
imgContent��67    � ��$R L/TestExerciser.Diary;component/Assets/Images/Buttons/btnHistory_Disabled.png��6O   5�      5�      5�      5�      �� 5�      "  d�6   .�5�   
   ��  � ��$ 30��6"   �� 5�   
    � ��$ 24��6#   �� 5�   
    �@�ToolTip$ 显示笔记属性��6$   �� 5�   
    � �� 5�      �� 5�      " d�6"   .R�5�      �� $��bdPanel��6    . ._�5�      �� $��
imgContent��6    $N��H/TestExerciser.Diary;component/Assets/Images/Buttons/btnShowProperty.png��62   5�       5�      P� 5�       �@d�	IsChecked$
 trueY�67   . �5�      �� $	 
imgContent��67    � ��$N H/TestExerciser.Diary;component/Assets/Images/Buttons/btnHideProperty.png��6O   �� 5�       �@�ToolTip$ 隐藏笔记属性��68   5�      ]� 5�       5�      �� 5�   "    �@d�	IsChecked$ falseY�6A   �� 5�   "    �@J�IsMouseOver . 6C   /�5�      �� 5�   "   $	 
imgContent��6;    � ��$T N/TestExerciser.Diary;component/Assets/Images/Buttons/btnShowProperty_Hover.png��6S   5�      ]� 5�       5�      �� 5�   "    �@d�	IsChecked$ falseY�6A   �� 5�   "    � �� . 6A   /�5�      �� 5�   "   $	 
imgContent��6;    � ��$T N/TestExerciser.Diary;component/Assets/Images/Buttons/btnShowProperty_Press.png��6S   5�      ]� 5�       5�      �� 5�   "    �@d�	IsChecked$
 trueY�6A   �� 5�   "    �@J�IsMouseOver . 6C   /�5�      �� 5�   "   $	 
imgContent��6;    � ��$T N/TestExerciser.Diary;component/Assets/Images/Buttons/btnHideProperty_Hover.png��6S   5�      ]� 5�       5�      �� 5�   "    �@d�	IsChecked$
 trueY�6A   �� 5�   "    � �� . 6A   /�5�      �� 5�   "   $	 
imgContent��6;    � ��$T N/TestExerciser.Diary;component/Assets/Images/Buttons/btnHideProperty_Press.png��6S   5�      5�      5�      5�      �� 5�      "    6   .�5�   
   ��  � �� 5�      �� 5�      "   6"   .R�5�      �� $	��Img��6   $��16��6'   $��16��62   # z 6>   #��z 6b   z�5�      �� 5�      RotateTransform��6.   5�       5�      P� 5�       �@  	IsLoading .  5�      �� 5�   "   $ loadingStoryboard��62   .��5�   &   �� $ Forever��61   .��5�   *   W� $ RotateTransform��6:   $ Angle�6b   $	 360X�6�   $ 0:0:1D�6�   5�   '   5�   #    5�      �� 5�   "   $ loadingStoryboard��61   6[   5�      5�      5      5     �� 5     "    6   8   .�5  
   ��  �@�ToolTip$ 保存��6$   �� 5  
    � ��$ 16��6"   �� 5  
    � ��$ 16��6#   �� 5  
    �@  ImageSource$H B/TestExerciser.Diary;component/Assets/Images/Menu/TopMenu/Sync.png��6(   5     �� 5
     "  ��6   .�5  
   ��  � ��$ 35��6"   �� 5  
    � ��$ 35��6#   �� 5  
    � �� 5     �� 5     " ��6"   .R�5     �� $��bdPanel��6    . ._�5     �� $��
imgContent��6    $H��B/TestExerciser.Diary;component/Assets/Images/Buttons/btnSearch.png��62   5      5     P� 5      �@J�IsMouseOver . . �5     �� $	 
imgContent��67    � ��$N H/TestExerciser.Diary;component/Assets/Images/Buttons/btnSearch_Hover.png��6O   5     P� 5      � �� . . �5     �� $	 
imgContent��67    � ��$N H/TestExerciser.Diary;component/Assets/Images/Buttons/btnSearch_Press.png��6O   5     P� 5      � {� .  . �5     �� $	 
imgContent��67    � ��$Q K/TestExerciser.Diary;component/Assets/Images/Buttons/btnSearch_Disabled.png��6O   5     5     5!     5"     �� 5$     "  ��6   .�5%  
   ��  � ��$ 24��6"   �� 5&  
    � ��$ 24��6#   �� 5'  
    � �� 5(     �� 5)     " ��6"   .R�5*     �� $��bdPanel��6    . ._�5+     �� $��
imgContent��6    $P��J/TestExerciser.Diary;component/Assets/Images/Buttons/btnDeleteKeywords.png��62   5,      5.     P� 5/      �@J�IsMouseOver . . �50     �� $	 
imgContent��67    � ��$V P/TestExerciser.Diary;component/Assets/Images/Buttons/btnDeleteKeywords_Hover.png��6O   51     P� 52      � �� . . �53     �� $	 
imgContent��67    � ��$V P/TestExerciser.Diary;component/Assets/Images/Buttons/btnDeleteKeywords_Press.png��6O   54     P� 55      � {� .  . �56     �� $	 
imgContent��67    � ��$Y S/TestExerciser.Diary;component/Assets/Images/Buttons/btnDeleteKeywords_Disabled.png��6O   57     59     5;     5<     5=     