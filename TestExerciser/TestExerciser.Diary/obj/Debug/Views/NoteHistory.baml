   M S B A M L   `   `   `  ����  TestExerciser.Diary+    %TestExerciser.Diary.Views.NoteHistory   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f45xceed)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   $	��660��5   I   $	��980��6V      ChildWindowStyle#��[  5   	     � WindowStartupLocation$  CenterOwner=�63    � Title 5   	   �� *CurrentNote.Title+ �� StringFormat$ {0}--历史版本��.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5	   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5
      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedCommand+5       � 	Resources 5       �� 
TargetType	 �� Property
 �� Value  DefaultBorderBrush  DisplayText  HeaderBackground �� Color��%O  '��       7  &	 g     &	 
    �� 5   
   " ��6   .�5      �� 	 � ��$
 1q�60   �� 5      	 � ��8
   6,   5      �� 5   
   " �6   .�5      �� 	 �@J�Opacity$	
 0.7Q�6(   �� 5      	 � ��$
 Center=�62   �� 5      	 � ��$
 10,0,0,0q�6'   5      �� 5   
   $ 	#FFEDEFF0��63   5      .��5      � $��	5,25,5,25q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $��* �6   .+�5#   
   �� $	��420��6   ._�5$      �  � RowDefinitions 5%      �� 5&      $��30 �6$   �� 5'      $��30 �6$   �� 5(      $��* �6$   .+�5+      � #��[ 6   .+�5,      �� $��当前版本��6    $
��Bold"�6,   #��[ 6>   �� 5-      $��1��6    $��Bottom=�6+   #��[ 6F   5.      �� 51       �� Orientation$ 
Horizontal=�6   $��Center=�66   $��1��6Q   .+�52      �� $��修改时间:��6    #��[ 6-   �� 53      #��[ 6g   ��6    �� *CurrentNote.ModifyDate+$ yyyy/MM/dd HH:mm��6g   54      �� 55      $��1��6   $��1��6)   $��Bottom=�64   #��[ 6O   #  Xceed.Wpf.Toolkit.RichTextBox  57      $��0q�6I   $��2��6]    �� 
IsReadOnly .    Text 6$   �� *CurrentNote.Content+6j   58      59      �� 5;   
   $	��420��6   $��1��6   $��5,0,0,0q�6-   ._�5<      �  5=      �� 5>      $��30 �6$   �� 5?      $��30 �6$   �� 5@      $��* �6$   .+�5C      � #��[ 6   .+�5D      �� $
��Bold"�6J   #��[ 6\   ��6    �� *CurrentHistoryNote.Title+6\   �� 5E      $��1��6    $��Bottom=�6+   #��[ 6F   5F      �� 5I      $ 
Horizontal=�6   $��Center=�66   $��1��6Q   .+�5J      �� $��修改时间:��6    #��[ 6-   �� 5K      #��[ 6n   ��6    �� *CurrentHistoryNote.ModifyDate+$ yyyy/MM/dd HH:mm��6n   5L      �� 5M      $��1��6   $��1��6)   $��Bottom=�64   #��[ 6O     5O      $��0q�6P   $��2��6d    .  6$   �� *CurrentHistoryNote.Content+6q   5P      5Q      �� 5S   
   $��2��6   $	��Top=�6!   ._�5T      �  5U      �� 5V      $��30 �6$   �� 5W      $��* �6$   .+�5Z      � #��[ 6   .+�5[      �� $��历史版本��6    $
��Bold"�6,   #��[ 6>   �� 5\      $��1��6    $��Bottom=�6+   #��[ 6F   5]      �� 5_      $��1��6j   $	��Top=�6w   $��0q�6�     NoteHistoryItemStyle#��[ 6�   ��6   �� *HistoryList+ �� SelectedItem 6>   �� *CurrentHistoryNote+��5`      �� 5a      .R�5b      �� ��6(   �� *
ModifyDate+$ yyyy/MM/dd HH:mm��5c      5e      5f      5g      5h      5i      