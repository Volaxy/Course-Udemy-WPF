   M S B A M L   `   `   `  ����V  R11 - Split Button to Ribbon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_11___Split_Button_to_Ribbon_11___Split_Button_to_Ribbon  5   	   -    '_11___Split_Button_to_Ribbon.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:_11___Split_Button_to_Ribbon     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   +  %System.Windows.Controls.Ribbon.Ribbon  -   5          Name$ 
mainRibbon��5
       �� SelectedIndex$ 1��6%      HelpPaneContent 5      1  +System.Windows.Controls.Ribbon.RibbonButton  5         Label$
 Help��6      SmallImageSource$ /images/about.png��6,      QuickAccessToolBar 5      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5      5  /System.Windows.Controls.Ribbon.RibbonMenuButton     SmallImageSource$ /images/floppy-16.png��6'   .@�5      3  -System.Windows.Controls.Ribbon.RibbonMenuItem  $
��Save��6)      ImageSource$ /images/floppy-16.png��67     5      $��Save As��6)   $ /images/file_32.png��6:   5        5      $
 Undo��6#   $ /images/Undo-2-16.png��60     5      $
 Redo��6#   $ /images/Redo-2-16.png��60   5      	   ApplicationMenu	 5      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5      
   Label$

 Main��6(   .@�5      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  $	��New��60   $ /images/add_memo.png��6=     5      $
��Save��60   $ /images/floppy-16.png��6>     5      $��Save As��60   $ /images/file_32.png��6A     5       $��Search��60   $ /images/view_32.png��6@     5!      $��Options��60   $! /images/settings-alt-32.png��6A     5"      -   5          Name$ exitRibbonMenuItem��5"   0   $
��Exit��6L   $ /images/exit.png��6Z   6y      FooterPaneContent 5$      �� 5%      .+�5&        $ About��6+      LargeImageSource$ /images/help_32.png��69     5'      $ Users��6+   $ /images/male_user.png��69   5(         AuxiliaryPaneContent 5+      �� 5,      .+�5-      �� $��Recent Files:��6$   $
��Bold"�6<   4  .System.Windows.Controls.Ribbon.RibbonSeparator  5.      �� 5/      .@�50   "   �� $��1.jpg��6.   �� 51   "   $��2.jpg��6.   �� 52   "   $��3.jpg��6.   �� 53   "   $��4.jpg��6.   54      55      57      .@�5:      .	  (System.Windows.Controls.Ribbon.RibbonTab	  $
��Home��6   .@�5;      0
  *System.Windows.Controls.Ribbon.RibbonGroup
  $��	ClipBoard��6   $
��auto��61   .@�5<        $
 Paste��6'      LargeImageSource$ /images/add_memo.png��65   .@�5=        -   5          Name$ pasteRibbonMenuItem��5=   )   $��Paste��6F   $" /images/content-paste-16.png��6U   6�     5>      -   5        $  pasteSpecialRibbonMenuItem��5>   )   $��Paste Special��6M   $ /images/add_memo.png��6d    m� IsCheckable . 6�   5?        5A      -   5          Name$ cutRibbonButton��5A   #   $	 Cut��6<   $ /images/cut.png��6H   6k     5B      -   5        $ copyRibbonButton��5B   #   $
 Copy��6=   $) #/images/ic_content_copy_48px-16.png��6J   6�   5C      
  5D      $
��Font��6   $	��135��6,   .@�5E      ��  �� Orientation$ 
Horizontal=�6!   .+�5F      7  1System.Windows.Controls.Ribbon.RibbonToggleButton     SmallImageSource$ /images/bold.png��6-     5G      $ /images/Italic.png��6-     5H      $ /images/underline.png��6-   5I      5J      
  5K      $��Format��6   $	��135��6.   .@�5L      �� $ 
Horizontal=�6!   .+�5M      6  0System.Windows.Controls.Ribbon.RibbonRadioButton     SmallImageSource$$ /images/text_align_left-16.png��6,     5N      $&  /images/text_align_center-16.png��6,     5O      $% /images/text_align_right-16.png��6,   5P      5Q      
  5R      $��Search��6   .@�5S      �� $ 
Horizontal=�6!   .+�5T      6  0System.Windows.Controls.Ribbon.RibbonTwoLineText     Text$ Title:��6,   2  ,System.Windows.Controls.Ribbon.RibbonTextBox  5U        5V      $ /images/search_memo.png��6'   5W      5X      5Y      	  5Z      $
��View��6   .@�5[      
  $
��Zoom��6   $	��121��6,   .@�5\        $ Zoom +��6#   $ /images/search_memo.png��62     5]      $ Zoom -��6#   $ /images/view_32.png��62   5^      
  5`      $��Show | Hide��6   $	��150��63   .@�5a      3  -System.Windows.Controls.Ribbon.RibbonCheckBox     Label$ Ruler��6%     5b      $ 
Status Bar��6%   5c      
  5e      $��Settings��6   .@�5f      6  0System.Windows.Controls.Ribbon.RibbonSplitButton  $
 	Word Wrap��6(   $! /images/settings-alt-32.png��6:   .@�5g      8  2System.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��No Wrap��6.     5h      $��Wrap to Ruler��6.    .  m� 	IsChecked . 6X   5i      5j      5k      	  5l      $��Format��6   5n      5o      5q      5r      