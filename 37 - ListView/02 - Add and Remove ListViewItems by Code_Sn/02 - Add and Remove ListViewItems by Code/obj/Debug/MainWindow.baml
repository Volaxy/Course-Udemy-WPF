   M S B A M L   `   `   `  ����d  `02 - Add and Remove ListViewItems by Code, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:_02___Add_and_Remove_ListViewItems_by_Code*_02___Add_and_Remove_ListViewItems_by_Code  5   	   ;    5_02___Add_and_Remove_ListViewItems_by_Code.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jlocal8clr-namespace:_02___Add_and_Remove_ListViewItems_by_Code     5   	   -   5          � Title$  
MainWindow��5   	   $	��281��6   $	��498��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ mainListView��5
      $��
72,52,72,0q�6)   $	��136��6=   $	��Top=�6J    �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$	 250��63   5      .@�5      �� $
��Data��6   �� 5      $��DB��6   �� 5      $��Image��6   �� 5      $��Output��6   5      �� 5   
   -   5         ��Name$ 	addButton��5      $	��Add��6$   $
��Left=�62   $��	359,8,0,0q�6M   $	��Top=�6`   $��29��6x   $��67��6�   6�   �� 5   
   $��Name:��6   $
��Left=�6    $��
163,10,0,0q�6;   $	��Top=�6O   �� 5   
   -   5         ��Name$ nameTextBox��5      $
��Left=�6'   $��
212,14,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5   
   $
��Left=�6   $��
72,193,0,0q�6+   $	��Top=�6?   $��Count:��6W   �� 5   
   -   5         ��Name$ 
countLabel��5      $
��Left=�6$   $��122,193,0,0q�6?   $	��Top=�6T   $��0��6l   �� 5   
   -   5        $ deleteAllButton��5      $��
Delete All��6*   $
��Left=�6?   $��348,193,0,0q�6Z   $	��Top=�6o   $��27��6�   $��78��6�   6�   �� 5   
   -   5        $ deleteSelectedButton��5      $��Delete Selected��6/   $
��Left=�6I   $��237,193,0,0q�6d   $	��Top=�6y   $��27��6�   $	��106��6�   6�   5      5      