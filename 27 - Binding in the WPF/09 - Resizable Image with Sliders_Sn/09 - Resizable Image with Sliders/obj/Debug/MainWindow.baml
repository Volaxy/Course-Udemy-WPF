   M S B A M L   `   `   `  ����\  X09 - Resizable Image with Sliders, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:_09___Resizable_Image_with_Sliders"_09___Resizable_Image_with_Sliders  5   	   3    -_09___Resizable_Image_with_Sliders.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:_09___Resizable_Image_with_Sliders     5   	     � Title$  
MainWindow��5   	   $	��462��6   $	��816��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ widthSlider��5
      $��Center=�6&   $��0,10,0,0q�6C   $	��Top=�6U   $	��712��6m    � Minimum$ 50Q�6y    � Maximum$	 600Q�6�    �� TickPlacement$ BottomRight=�6�    �� TickFrequency$ 20Q�6�    � Value$ 50Q�6�   �� 5   
   -   5        $ heightSlider��5      $
��Left=�6'   $��11,0,0,0q�6B   $��Center=�6T   $��29��6o    �� Orientation$ Vertical=�6z   $	��364��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $ TopLeft=�6�   $ 20Q�6�   $	 500Q�6�   $ 50Q�6�   $ 50Q�6  z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$		 180Q�6&   T� 5      5      5      �� 5   
   -   5        
 ��Name$
 	mainImage��5      $
��Left=�6#   $��	44,39,0,0q�6~   $	��Top=�6�   $��/koala_resized.jpg��6�   $
��Fill=�6  ��6>   �� *Value+ �� ElementName$ heightSlider�� �� Mode$ OneWay=���6�   �� *Value+$ widthSlider��$ OneWay=�6  5      5      