   M S B A M L   `   `   `  ����U  Q09 - Get File Info by Code, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:_09___Get_File_Info_by_Code_09___Get_File_Info_by_Code  5   	   ,    &_09___Get_File_Info_by_Code.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:_09___Get_File_Info_by_Code     5   	     � Title$  
MainWindow��5   	   $	��425��6   $	��385��6)   .��5	      � .+�5
   
   �� $��Button��6   $
��Left=�6"   $��
652,61,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ filePathTextBox��5      $
��Left=�6+   $��
134,49,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   �� 5   
   $��
File Path:��6   $
��Left=�6%   $��	25,45,0,0q�6@   $	��Top=�6S   �� 5   
   -   5        $ fileNameTextBox��5      $
��Left=�6+   $��
134,77,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   �� 5   
   $��
File Name:��6   $
��Left=�6%   $��	25,73,0,0q�6@   $	��Top=�6S   �� 5   
   -   5        $ fileFolderTextBox��5      $
��Left=�6-   $��134,105,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   $��File Folder:��6   $
��Left=�6'   $��
25,101,0,0q�6B   $	��Top=�6V   �� 5   
   -   5        $ fileDriveTextBox��5      $
��Left=�6,   $��134,133,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   $��File Drive:��6   $
��Left=�6&   $��
25,129,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ fileExtensionTextBox��5      $
��Left=�60   $��134,161,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   $��File Extension:��6   $
��Left=�6*   $��
25,157,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ fileCreationTextBox��5      $
��Left=�6/   $��134,189,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��File Creation:��6   $
��Left=�6)   $��
25,185,0,0q�6D   $	��Top=�6X   �� 5   
   -   5        $ fileLastAccessTextBox��5      $
��Left=�61   $��134,217,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $��File Last Access:��6   $
��Left=�6,   $��
25,213,0,0q�6G   $	��Top=�6[   �� 5   
   -   5        $ fileLastModifiedTextBox��5      $
��Left=�63   $��134,245,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   $��File Last Modified:��6   $
��Left=�6.   $��
25,241,0,0q�6I   $	��Top=�6]   �� 5   
   -	   5        $ fileSizeTextBox��5      $
��Left=�6+   $��134,273,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   $��
File Size:��6   $
��Left=�6%   $��
25,269,0,0q�6@   $	��Top=�6T   �� 5   
   -
   5         ��Name$ browseButton��5      $��Browse��6'   $
��Left=�68   $��
265,47,0,0q�6S   $	��Top=�6g   $��74��6   6�   �� 5   
   -   5        $ fileInfoButton��5      $��Get File Info��6)   $
��Left=�6A   $��134,305,0,0q�6\   $	��Top=�6q   $	��120��6�   $��31��6�   6�   5       5!      