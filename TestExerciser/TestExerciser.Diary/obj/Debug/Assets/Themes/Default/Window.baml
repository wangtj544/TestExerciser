   M S B A M L   `   `   `  ����U  QTestExerciser.Diary.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullVclr-namespace:TestExerciser.Diary.Common.Behaviors;assembly=TestExerciser.Diary.Common$TestExerciser.Diary.Common.Behaviors  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35b ^Microsoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source �� 
TargetType   NormalWindowStyle �� Property �� Value  WindowContentBackground �� 
TargetType � RowDefinitions �� CornerRadius  WindowTitleBackground � ColumnDefinitions	 � Title  WindowTitleForeground*   $Microsoft.Windows.Shell.WindowChrome
    IsHitTestVisibleInChrome
 � Tag  WindowMinButtonStyle.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName.  (System.Windows.Interactivity.TriggerBase   ActionsB  <Microsoft.Expression.Interactivity.Core.ChangePropertyAction   PropertyName   Value8  2System.Windows.Interactivity.TargetedTriggerAction   TargetObject �� RelativeSource �� Mode �� AncestorType  WindowRestoreButtonStyle  WindowMaxButtonStyle  WindowCloseButtonStyle>  8Microsoft.Expression.Interactivity.Core.CallMethodAction   
MethodName   TargetObject  DefaultBorderBrush �� Triggers P� Property P� Value �� 
TargetName    CaptionHeight    GlassFrameThickness    CornerRadius    UseAeroCaptionButtons 	 ChildWindowStyle �� BasedOn�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    Kshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Bei9http://schemas.microsoft.com/expression/2010/interactions  5      jcommonBehaviorsVclr-namespace:TestExerciser.Diary.Common.Behaviors;assembly=TestExerciser.Diary.Common  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5        5      �� 5   
   $G A/TestExerciser.Diary;component/Assets/Themes/Default/Brushes.xaml?�6   %,  &	        7  7  7  7  7  &		 r    7   �� 5      " �6   .�5   
   ��  � ��$ 0q�6#   �� 5   
    � ��$ 0q�6$   �� 5   
    � ��8   6'   �� 5   
    �@�WindowStyle$
 None=�6(   �� 5   
    �@�AllowsTransparency . 6/   �� 5   
    � �� 5      �� 5      " �6"   .R�5      �  5      �� 5      $��30 �6,   �� 5      $��* �6,   .+�5      �� $��bdTitle��6!   $ 5,5,0,0��60   $��1q�6G   8�� 8�� ._�5      � $��	10,0,10,0q�6#    5   "   �� 5   &   $
��Auto �67   �� 5    &   $��* �67   �� 5!   &   $
��Auto �67   �� 5"   &   $
��Auto �67   �� 5#   &   $
��Auto �67   �� 5$   &   $
��Auto �67   .+�5'   "   �� #��z	 6,   $��1��6K   $
��Left=�6[   $��Center=�6v   8�� 6�   �� 5*   "   
 . $��2��6f   #��z 6v   $��0,0,10,0q�6�   �� 5-   "   $��btnMin��6)   #���  67   $��3��6f   $��0,0,5,0q�6v   
 .  5.   &     5/   *   $ Click��69   . 50   .     $ WindowState��6F   $ 	Minimized��6a    6s   ��  �� $ FindAncestor=�$ WindowL�51   +   53   #   �� 56   "   $��
btnRestore��6)   #���  6;   $��4��6n   $��0,0,5,0q�6~   
 .  57   &     58   *   $ Click��69   . 59   .     $ WindowState��6F   $ Normal��6a    6p   ��  �� $ FindAncestor=�$ WindowL�5:   +   5<   #   �� 5?   "   $��btnMax��6)   #���  67   $��4��6f   $��0,0,5,0q�6v   
 .  5@   &     5A   *   $ Click��69   . 5B   .     $ WindowState��6F   $ 	Maximized��6a    6s   ��  �� $ FindAncestor=�$ WindowL�5C   +   5E   #   �� 5H   "   $��btnClose��6)   #���  69   $��5��6j   
 .  5I   &     5J   *   $ Click��69   . 5K   .     $ Close��6B    6U   ��  �� $ FindAncestor=�$ WindowL�5L   +   5N   #   5O      5P      �� 5S      $��	bdContent��6!   $ 0,0,5,5��62   $��1q�6I   #��z��6]   $��1��6�   8�� ._�5T      �� 5U      5W       5X      P� 5Y       �@�WindowState$ 	Maximized=�69   . �5Z      �� $ btnMax��6%    � y�$ 	Collapsed=�6O   �� 5[      $ 
btnRestore��6%    � y�$ Visible=�6S   �� 5\      $ bdTitle��6%    �@��CornerRadius$ 0��6R   �� 5]      $ 	bdContent��6%    �@��CornerRadius$ 0��6T   5^      P� 5_       �@�WindowState$ Normal=�69   . �5`      �� $ btnMax��6%    � y�$ Visible=�6O   �� 5a      $ 
btnRestore��6%    � y�$ 	Collapsed=�6S   5b      P� 5c       �@�
ResizeMode$ NoResize=�68   . �5d      �� $ btnMin��6M    � y�$ 	Collapsed=�6;   6M   �� 5e      $ 
btnRestore��6M    � y�$ 	Collapsed=�6;   6M   �� 5f      $ btnMax��6M    � y�$ 	Collapsed=�6;   6M   5g      5i      5k      �� 5m   
    �@  WindowChrome 5n         5o      $ 27Q�6%   $ 0q�68   $ 0��6P    .  6a   5q      5r      �� 5t      " �6   8   .�5u   
   ��  �@�
ResizeMode$ NoResize=�6'   �� 5v   
    �@�ShowInTaskbar .  6*   5w      5x      