   M S B A M L   `   `   `  ����_  [02 - OneWay Binding with ProgressBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_02___OneWay_Binding_with_ProgressBar%_02___OneWay_Binding_with_ProgressBar  5   	   6    0_02___OneWay_Binding_with_ProgressBar.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:_02___OneWay_Binding_with_ProgressBar     5   	     � Title$  
MainWindow��5   	   $	��236��6   $	��429��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ mySlider��5
      $
��Left=�6#   $��59,0,0,0q�6>   $��Center=�6P   $	��120��6k    �� TickPlacement$ BottomRight=�6w    � Maximum$	 100Q�6�    �� TickFrequency$ 5Q�6�   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��
193,98,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $��59��6~   ��6�   �� *Value+ �� ElementName$ mySlider�� �� Mode$ OneWay=�� 5   
   -   5        	 �Name$	 myProgressBar��5      $
��Left=�6-   $��23��6H   $��
205,31,0,0q�6T   $	��Top=�6h   $	��127��6�   
 � Value
 6�   �� *Value+$ mySlider��$ OneWay=�� 5   
   -   5        $	 secondProgressBar��5      $
��Left=�61   $	��164��6L   $��
370,31,0,0q�6Y   $	��Top=�6m   $��23��6�    � Orientation$ Vertical=�6�   
 6�   �� *Text+$ textBox��5      5      