   M S B A M L   `   `   `  ����]  YFinal Practices - Ioannis Koutsios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Final_Practices___Ioannis_Koutsios"Final_Practices___Ioannis_Koutsios  5   	   ;    5Final_Practices___Ioannis_Koutsios.ShoppingListWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Final_Practices___Ioannis_Koutsios     5   	     � Title$  ShoppingListWindow��5   	   $	��450��6$   $	��800��61   .��5	      � $��8q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��4 �6   �� 5      �� 5      $��4 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �  5      �� 5      $
��auto �6#   �� 5      $��4 �6#   �� 5      �� 5      $��4 �6#   �� 5      $
��auto �6#   �� 5      $��4 �6#   �� 5      �� 5      $��4 �6#   �� 5       $
��auto �6#   .+�5#      �� $��	Item Name��6   �� 5$      -   5         ��Name$ ItemNameTextBox��5$      $��2��6/   $��Center=�6?   �� 5&      $��4��6   $��Item Quantity��6$   �� 5'      -   5        $ ItemQuantityTextBox��5'      $��6��63   $��Center=�6C   �� 5)      -   5         ��Name$ AddItemButton��5)      $��8��6,   $	��8,0q�6<   $��Center=�6J   $	��Add��6�   5+      �� 5.   
   -   5         ��Name$ ItemsStackPanel��5.      $��2��6.   $��8q�6;   �� 50   
   -   5        $ RemoveSelectedItemsButton��50      $��4��64   $��8q�6A   $��Center=�6M   
���  ��$��Remove Selected Items��6�   $��SemiBold"�6�   
�������6�   52      54      