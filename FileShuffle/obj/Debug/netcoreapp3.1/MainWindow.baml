   M S B A M L   `   `   `  ����F  BFileShuffle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FileShuffleFileShuffle  5   	       FileShuffle.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FileShuffle     5   	     � Title$  	EzShuffle��5   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6@   $��Center=�6V   $��Center=�6s   $
��Left=�6�   $	��Top=�6�    � SizeToContent$ Manual=�6�   $	��100��6�   $	��810��6�   ��5	      �� 5
   
    �� Color# � ��6   .��5      � $��Stretch=�6   $��Stretch=�6)   .+�5   
   �� -   5         ��Name$ shuffleButton��5      $
��Left=�6(   $	��Top=�6C   $��25��6w   $��25��6�   $��14(�6�   $��
754,29,0,0q�6�   .��5      �� $��/shuffleIcon.png��6   5      �� 5   
   -   5         ��Name$ filepathTextBox��5      $��	10,29,0,0q�6+    �� TextWrapping$
 Wrap=�6>   $	��Top=�6R   $	��709��6j   $��25��6v   $��Center=�6�   $��14(�6�   $
��Left=�6�   ���	#FF444444$
��Bold"�6�   �� 5   
   -   5        $ browseButton��5      $
��Left=�6'   $	��Top=�6B   $��25��6Z   $��25��6f   $��14(�6q    � UseLayoutRounding$
 True��6   $��
724,29,0,0q�6�   .��5      � $��Stretch=�6   .+�5      �� $��/browseFolderIcon.png��6   5      5      �� 5   
   $��	Directory��6   $
��Left=�6$   $	��Top=�6?   $��	10,10,0,0q�6W   $��0,0,0,0q�6j   $��14(�6|   
���   �6�   5      5      