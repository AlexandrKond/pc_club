   M S B A M L   `   `   `  ����B  >CLUB_PC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CLUB_PCCLUB_PC  5   	       CLUB_PC.DataGrid   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CLUB_PC     5   	     � Title$  DataGrid��5      $	��530��6   $	��820��6+    � WindowStartupLocation$ CenterScreen=�67    � 	Resources 5	         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    '�� �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      "	 ��6&   .R�5(      �� $
 border��6!   #��z��61   $ 20��6[   #��z��6m   #��z��6�   $
 true��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      N� $��0,0,0,-6q�6   .��5C   
   � $	��520��6   $��Center=�6   ���	#FF18052D � RowDefinitions 5D      �� 5E      $
��380* �6    �� 5F      $	��90* �6    .+�5H      &   System.Windows.Controls.DataGrid  -   5          Name$ DGridMovies��5H         AutoGenerateColumns$ False��6,      
IsReadOnly$
 True��6H   
�������$��0,5,0,95q�6�   $��2��6�      Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ idTable��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
id_table+6d     5K      $ idHall��6)   $ 60 6U    69   �� *	id_hall+6b     5L      $ keyboard��6)   $	 200 6X    6;   �� *
keyboard+6f     5M      $ mouse��6)   $	 200 6R    68   �� *mouse+6`     5N      $ 
headphones��6)   $	 200 6\    6=   �� *
headphones+6j   4  .System.Windows.Controls.DataGridTemplateColumn  5O      $
 auto 6-      CellTemplate 5P      �� 5Q      .R�5R   "   �� $��BtnEdit��6Y   -   5        $ ��Редактировать��5R   )   $	��100��6A   $��30��6M   6�   5S      5U      5W      �� 5X      -   5         ��Name$ 	BtnDelete��5X   P   $��Удалить��6   $
��Left=�6'   $��1��6B   $	��192��6c   $��37��6o   $��588,23,0,38q�6{   
���   �
�������$��18(�6�   $��Dubai Medium)�6�   
���   �6�   �� 5Y      -   5        $ BtnAdd��5Y   Q   $��Добавить��6   $
��Left=�6(   $��1��6C   $	��192��6b   $��37��6n   $��
30,22,0,39q�6z   
���   �
���   �$��18(�6�   $��Dubai Medium)�6�   
�������6�   5Z      5[      5\      