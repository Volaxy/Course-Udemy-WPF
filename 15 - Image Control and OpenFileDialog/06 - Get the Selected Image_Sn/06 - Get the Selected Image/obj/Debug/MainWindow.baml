   M S B A M L   `   `   `  ����V  R06 - Get the Selected Image, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_06___Get_the_Selected_Image_06___Get_the_Selected_Image  5   	   -    '_06___Get_the_Selected_Image.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_06___Get_the_Selected_Image     5   	     � Title$  
MainWindow��5   	   $	��236��6   $	��362��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��113* �6   �� 5      $
��107* �6   .+�5   
   �� -   5         ��Name$ imageControl��5      $��/koala_resized.jpg��6&   $
��Fill=�6B   $��1��6Q   $��0,3,0,0q�6^   �� 5   
   -   5         ��Name$ loadImageButton��5      $��
Load Image��6*   $
��Left=�6?   $	��Top=�6Z   $��20��6r   $��66��6~   $��	10,21,0,0q�6�   �� 5   
   -   5        $ 
fillButton��5      $
��Fill��6%   $
��Left=�64   $	��Top=�6O   $��20��6g   $��66��6s   $��
104,21,0,0q�6~   6�   �� 5   
   -   5        $ 
zoomButton��5      $
��Zoom��6%   $
��Left=�64   $	��Top=�6O   $��20��6g   $��66��6s   $��
193,10,0,0q�6~   6�   �� 5   
   -   5        $ browseButton��5      $��Browse��6'   $
��Left=�68   $��
274,22,0,0q�6S   $	��Top=�6g   $��19��6�   $��42��6�   �� 5   
   -   5         ��Name$ filePathLabel��5      $��Label��6'   $��Center=�67   $��0,57,0,0q�6T   $	��Top=�6f   $	��362��6~   $��33��6�   ���	#FF484848$��1,1,1,1q�6�   ���	#FFDAFBFF6�   5      5      