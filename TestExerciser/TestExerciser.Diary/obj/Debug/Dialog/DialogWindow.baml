   M S B A M L   `   `   `  ����  TestExerciser.Diary-    'TestExerciser.Diary.Dialog.DialogWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��window��5   	     � Title$  工作笔记��5   	    � SizeToContent$ WidthAndHeight=�6   $	��350��5   	   $	��150��6      ChildWindowStyle#��[  6(    � WindowStartupLocation$ CenterOwner=�5      .��5      � $��20,10,20,20q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��	tbCaption��5      $
��Left=�6%   $��14(�6m   $
��Bold"�6{   ��6@   �� *	Caption+ �� ElementName$ window��6{   �� 5   
   -   5        $��tbDescription��5      $
��Left=�6)   $��Center=�6D   $��1��6_   $
��Wrap=�6l    J� Opacity$	 0.7Q�6�   ��6�   �� *Description+$ window��6�   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5      �� -   5        $��btnOK��5      $��确定��66     SubmitButton#��[ 6C   �� 5      -   5        $��	btnCancel��5      $��取消��6>   $	��100��6K   $��24��6W   $��20,0,0,0q�6c   $y�	Collapsed=�6u   5      5      5      