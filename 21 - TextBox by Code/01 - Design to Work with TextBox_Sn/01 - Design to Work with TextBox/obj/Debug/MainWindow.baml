   M S B A M L   `   `   `  ����[  W01 - Design to Work with TextBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:_01___Design_to_Work_with_TextBox!_01___Design_to_Work_with_TextBox  5   	   2    ,_01___Design_to_Work_with_TextBox.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:_01___Design_to_Work_with_TextBox     5   	     � Title$  TextBox��5   	   $	��329��6   $	��774��6&    � WindowStartupLocation$ CenterScreen=�62   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFAE1FF3��6   � 5      $ 	#FF5DE7F9��6    � Offset$ 1Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ mainTextBox��5      $��
30,0,28,23q�6'    �� TextWrapping$
 Wrap=�6;   $��TextBox��6O   $	��170��6^   $��Bottom=�6k    �� AcceptsReturn . "	 �� VerticalScrollBarVisibility$
	 Auto=�6�   $
 �� HorizontalScrollBarVisibility$

 Auto=�6�   �� 5   
   -   5         ��Name$ zoomInButton��5      $��Zoom +��6'   $
��Left=�68   $��	30,19,0,0q�6S   $	��Top=�6f   $��60��6~   $��20��6�   6�   �� 5   
   -   5        $ zoomOutButton��5      $��Zoom -��6(   $
��Left=�69   $��
100,19,0,0q�6T   $	��Top=�6h   $��60��6�   $��20��6�   6�   �� 5   
   -   5        $ selectAllButton��5      $��
Select All��6*   $
��Left=�6?   $��
185,19,0,0q�6Z   $	��Top=�6n   $��60��6�   $��20��6�   6�   �� 5   
   -   5        $ 
undoButton��5      $
��Undo��6%   $
��Left=�64   $��
270,19,0,0q�6O   $	��Top=�6c   $��60��6{   $��20��6�   6�   �� 5   
   -   5        $ 
redoButton��5      $
��Redo��6%   $
��Left=�64   $��
334,19,0,0q�6O   $	��Top=�6c   $��60��6{   $��20��6�   6�   �� 5   
   -   5        $ 
copyButton��5      $
��Copy��6%   $
��Left=�64   $��
410,19,0,0q�6O   $	��Top=�6c   $��60��6{   $��20��6�   6�   �� 5   
   -   5        $ 	cutButton��5      $	��Cut��6$   $
��Left=�62   $��
475,19,0,0q�6M   $	��Top=�6a   $��60��6y   $��20��6�   6�   �� 5   
   -	   5        $ pasteButton��5      $��Paste��6&   $
��Left=�66   $��
551,19,0,0q�6Q   $	��Top=�6e   $��60��6}   $��20��6�   6�   �� 5   
   -
   5        $��Enable Word Wrap��5      $
��Left=�6,   $��
635,19,0,0q�6G   $	��Top=�6[   $	��111��6s   6   �� 5   
   -   5        $��Disable Word Wrap��5      $
��Left=�6-   $��
635,44,0,0q�6H   $	��Top=�6\   $	��111��6t   6�   5      5      