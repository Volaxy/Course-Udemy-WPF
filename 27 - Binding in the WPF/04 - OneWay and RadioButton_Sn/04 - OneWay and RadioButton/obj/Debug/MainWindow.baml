   M S B A M L   `   `   `  ����V  R04 - OneWay and RadioButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_04___OneWay_and_RadioButton_04___OneWay_and_RadioButton  5   	   -    '_04___OneWay_and_RadioButton.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_04___OneWay_and_RadioButton     5   	     � Title$  
MainWindow��5   	   $	��255��6   $	��426��6)   .��5	      � .+�5
   
   	� -   5         	�Name$ maleRadioButton��5
      $
��Left=�6/   $��
240,38,0,0q�6J   $	��Top=�6^    	� 	GroupName$ Gender��6v    d� 	IsChecked$
 TrueY�6�   $��2��6�   $��Center=�6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��/male_user.png��6   $��16��60   $��16��6;   �� 5      $
��Male��6   5      5      	� 5   
   -   5        $ femaleRadioButton��5      $
��Left=�61   $	��Top=�6L   $��
240,63,0,0q�6d   $ Gender��6x   $��Center=�6�   .��5      �� $ 
Horizontal=�6   .+�5      �� $��16��6   $��16��6#   $��/female_user.png��6/   �� 5      $��Female��6   5      5      	� 5   
   $
��Left��6   $
��Left=�6%   $��241,133,0,0q�6@   $	��Top=�6U   $ Align��6m   $
 TrueY�6   	� 5   
   $��Center��6   $
��Left=�6'   $��241,154,0,0q�6B   $	��Top=�6W   $ Align��6o   	� 5   
   $��Right��6   $
��Left=�6&   $��241,176,0,0q�6A   $	��Top=�6V   $ Align��6n   �� 5   
   -   5         ��Name$ femaleComboBox��5      $
��Left=�6+   $��
241,93,0,0q�6F   $	��Top=�6Z   $��70��6r   $y�Visible=�6}   {�6�   �� *	IsChecked+ �� ElementName$ femaleRadioButton�� �� Mode$ OneWay=�.@�5      �� $
��Girl��6   �� 5      $��Woman��6   5      5      5      