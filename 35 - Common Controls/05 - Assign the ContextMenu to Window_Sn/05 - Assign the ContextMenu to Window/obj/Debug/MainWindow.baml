   M S B A M L   `   `   `  ����`  \05 - Assign the ContextMenu to Window, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:_05___Assign_the_ContextMenu_to_Window&_05___Assign_the_ContextMenu_to_Window  5   	   7    1_05___Assign_the_ContextMenu_to_Window.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:_05___Assign_the_ContextMenu_to_Window     5   	     � Title$  
MainWindow��5   	   $	��150��6   $	��300��6)    � 	Resources 5	         DefaultStyle �� 
TargetType �� Property �� Value  
ItemsStyle��%  &	        &	 w     �� 5
   
   " ��6%   .�5      ��  � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   5      �� 5   
   " m�6#   .�5      ��  � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   5      5       � ContextMenu 5      �� 5   
   .@�5      m� -   5        $��windowExitMenuItem��5   J   #���  6   $
��Exit��6<   6d   m� 5      -   5        $��windowAboutMenuItem��5   &   $��About��6   6A   5      .��5      � .+�5   
   �� $��Right Click on Me!��6   $��Center=�6.   $��Center=�6K   $��39��6f   $	��124��6r    5      ��%  &	        &	 w     �� 5      " ��6-   .�5      ��  � ��
 �����63   �� 5        �@�Cursor$
 Hand��6/   5!      �� 5#      " m�6+   .�5$      ��  � ��
 �����63   �� 5%       �@�Cursor$
 Hand��6/   5&      5'       5)      �� 5*      .@�5+      m� -   5        $��exitApp��5+   ^   #���  6   $��Exit Application��6D   $
��Bold"�6�   $��Italic$�6�    m� Icon 5,      �� 5-      $��/pics/exit.png��6$   5/      �� 50      m� 51      -   5        $��cutMenuItem��51   ,   $	��Cut��6    52      �� 53      $��/pics/cut.png��6$   55      m� 56      -   5        $��copyMenuItem��56   -   $
��Copy��6    57      �� 58      $��/pics/copy.png��6$   5:      m� 5;      -   5        $��pasteMenuItem��5;   .   $��Paste��6    5<      �� 5=      $��/pics/paste-16.png��6$   5?      �� 5@      5A      5C      5E      5F      