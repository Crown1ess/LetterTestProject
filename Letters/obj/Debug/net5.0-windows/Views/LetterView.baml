   M S B A M L   `   `   `  ����B  >Letters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Letters.ViewsLetters.Views  5          Letters.Views.LetterView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Letters.Views     5      .��5	      � .+�5
   
   �� -   5          ��Name$  Panel��5
      $	��Top=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ IsUseFilter��5      $(��"Фильтрация по дате��5      $��Center=�5      ��5      �� *UseFilterCommand+��5      �� *	IsChecked+ �� RelativeSource �� *Self+ �� Mode$ OneWay=��� 5      -   5        $  DatesFilter��5      $ 
Horizontal=�5      $��	130 0 0 0q�5      .+�5      (  "System.Windows.Controls.DatePicker  -   5        $��	StartDate��5         SelectedDate 5      �� *	StartDate+  5      -   5        $��LastDate��5       5      �� *
FinishDate+5      5      �� 5   
   -   5        $  
LetterArea��5      $ Vertical=�5       $��	0 100 0 0q�5!      .+�5"      �� $
��75px��5&      $��100px��5'      $��300px��5(      $��350px��5)      
���   �$	��1pxq�5+      $��Center=�5,       �� TextWrapping$
 Wrap=�5-      ��5"      �� *LetterContent+ �� NotifyOnSourceUpdated$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�$ TwoWay=�5-      �� 5.      $
��Send��6   $
��10pxq�5/      $��Center=�50      $��100px��51      	 � Cursor$
	 Hand��53      ��52      �� *SendCommand+53      54      �� 55   
   $ Vertical=�6   $��Bottom=�56      $	��350��57      $	��480��58      $
��Left=�59      .+�5:      �� $��Hidden=�6   $
��Auto=�5;      $	��300��5<      $
��True��5=      .��5>      �� -   5        
 ��Name$
 
LetterList��5>       %� IsVirtualizing$
 True��5@       %� VirtualizationMode$ 	Recycling=�5A       %� IsContainerVirtualizable$
 True��5B      ! �� IsDeferredScrollingEnabled$
 True��5C      ��5?      �� *SendedLetters+��5E      �� 5F      .R�5G      $� 5H      ��5K      �� 5L      .R�5M      ��  �� CornerRadius$ 4��6%   $	��1pxq�5N   %   
���   �$	��450��5P   %   $��Center=�5Q   %   ._�5R   "   � $��1q�6'   .+�5S   &   �� $ Vertical=�61   .+�5T   *   �� $ 
Horizontal=�65   .+�5U   .   �� $��	0 0 150 0q�5X   4   ��5U   4   �� *
Username+$
 True��$ PropertyChanged=�5X   4   �� 5Y   .   $��
140 0 0 10q�5\   4   ��5Y   4   �� *LetterSendDate+$
 True��$ PropertyChanged=�5\   4   5]   +   �� 5^   *   $��Center=�5a   4   $
��Wrap=�5b   4   ��5^   4   �� *LetterContent+$
 True��$ PropertyChanged=�5b   4   5c   '   5d   #   5e      5f      5h      5i      5j      5l      5m      