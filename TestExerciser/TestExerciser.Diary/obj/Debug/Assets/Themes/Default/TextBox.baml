   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35X TXceed.Wpf.Toolkit, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DefaultTextBoxTemplate  �� 
TargetType,    &Microsoft.Windows.Themes.ListBoxChrome   Name    BorderThickness    BorderBrush    
Background    RenderMouseOver    RenderFocused J� SnapsToDevicePixels ��Name	 �� Triggers
 P� Property P� Value �� Property �� Value �� 
TargetType  DefaultBorderBrush(  "Xceed.Wpf.Toolkit.WatermarkTextBox  LikeLabelTextBox �� BasedOn ��Name �� CornerRadius J� Opacity ��Name   	Watermark   WatermarkTemplate J� IsHitTestVisible ]� 
Conditions �� Property �� Value �� 
TargetName �� Triggers#  Xceed.Wpf.Toolkit.RichTextBox  SearchTextBox�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    UThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      5xceed)http://schemas.xceed.com/wpf/xaml/toolkit  5      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      %K  &	        '�� �    7   &	 �    7 'G� -	    '  �    7   &	 �    7���� 5      "  ��65   .R�5   
      $ Bd��6S   # z��6   # z��6_   # z��6�    .   .   . ._�5      �� $ PART_ContentHost��6>   #��z��6   #��z��6n   # z 6�   ��6X   Z� 6�   5      	 5	   
   P� 5
      
 � {� .  . �5      ��  � ��$ 0q�64   �� 5      # � ��6/    � ��5      P� 5      
 �@J�IsMouseOver . 5      5      �� 5      " ��6   .�5   
   ��  � ��$ 1q�6,   �� 5   
    � ��# �  6(   �� 5   
    �@J�	AllowDrop . 6&   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    � ��$ Center=�65   �� 5   
    � ��8   6W   5      �� 5      "  6   8   .�5   
   ��  � ��$ 2,0,2,0q�6$   �� 5   
    � ��$ 25��6#   �� 5    
    � |� . 6&   �� 5!   
    � ��
 ���� 6'   �� 5"   
    � ��$ 1q�6,   �� 5#   
    � ��
 ���� 6(   �� 5$   
    � ��$ Center=�65   �� 5&   
    � �� 5'      �� 5(      "   6"   .R�5)         $ Bd��6_   # z��6+   # z��6k   # z��6�    .   .   . ._�5*      � .+�5+      �� $ Border��6%   $��0q�65   $ 1��6I   #��z��6Z   �� 5,      $ MouseOverVisual��6%   $ 0Q�6>   $��0q�6J   $ 1��6^   �� 5-      $ FocusVisual��6%   $ 0Q�6:   $��0q�6F   $ 1��6Z   �� 5.      $ PART_ContentHost��6N   #��z��6+   #��z��6~   # z 6�   ��6h   Z� 6�   �� 5/      $ PART_WatermarkHost��6/   #��z 50   %   #��z 51   %   #��z��52   %   #��z��53   %    .  #��z��55   %   $y�	Collapsed=�56   %   57      58      	 59      ]� 5:       5;      �� 5<   "    �@J�	IsFocused .  6A   �� 5=   "    � ��$  ��6<   /�5?      �� 5@   "   $ PART_WatermarkHost��6?    � y�$ Visible=�6_   5B      P� 5D      
 � {� .  . �5E      ��  � ��$ 0q�6@   �� 5F      $ PART_WatermarkHost��6;    � y�$ 	Collapsed=�6[   �� 5G      # � ��6;    � ��5H      P� 5I      
 �@J�IsMouseOver . 5K      5M      5O       5Q   
   P� 5R      
 �@J�IsMouseOver . . �5S      ��  � �� �	#FFB6C5CC60   5T      P� 5U      
 �@J�	IsFocused . . �5V      ��  � ��
 �����6/   �� 5W       � �� �	#FFDEDEDE60   5X      5Z      �� 5\      " G�6   .�5]   
   ��  � ��$ 1q�6,   �� 5^   
    �@J�	AllowDrop . 6&   �� 5_   
    �@�FocusVisualStyle 6-   Z� �� 5`   
    � �� 5a      �� 5b      "  G�6"   .R�5c         $ Bd��6_   # z��6+   # z��6k   # z��6�    .   .   . ._�5d      �� $ PART_ContentHost��6J   #��z��6'   #��z��6z   # z 6�   ��6d   Z� 6�   5e      	 5f      P� 5g      
 � {� .  . �5h      �� $ Bd��6;   # � ��6K    �@  
Background�� 5i      # � ��6;    � ��5j      P� 5k      
 �@J�IsMouseOver . 5m      5o      5q      5r      �� 5t      "  6   .�5u   
   ��  � ��$ 1q�6,   �� 5v   
    � ��# �  6(   �� 5w   
    �@��	UndoLimit$	 100��6&   �� 5x   
    � ��$ 5q�6$   �� 5y   
    � ��8   6W   5z      �� 5|      " ��6   8   .�5}   
   ��  � ��
 �����6'   �� 5~   
    � ��$ 5,0,5,0q�6$   5      5�      