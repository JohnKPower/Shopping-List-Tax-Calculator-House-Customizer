   M S B A M L   `   `   `  ����]  YFinal Practices - Ioannis Koutsios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Final_Practices___Ioannis_Koutsios"Final_Practices___Ioannis_Koutsios  5   	   >    8Final_Practices___Ioannis_Koutsios.HouseCustomizerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Final_Practices___Ioannis_Koutsios     5   	     � Title$  HouseCustomizerWindow��5   	   $	��200��6'   $	��350��64   .��5	      � $��8q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��4 �6   �� 5      $
��auto �6   �� 5      $��4 �6   �� 5      $
��auto �6   �� 5      $��4 �6   �� 5      $
��auto �6   �� 5      $��4 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��4 �6   �� 5      .+�5   
   �� $��3��5      $��Center=�5      $��House Customizer��5      $��16(�5       $��SemiBold"�5!      �� 5$   
   $��2��5%      $��0��5&      $��Wall Colors��5'      � 5(   
   $��2��5)      $��2��5*      $��Center=�5+      .+�5,      	� -   5         	�Name$ RedRadioButton��5-      $��0,0,8,0q�5.      $	��Red��5/       d� 	IsChecked$
 TrueY�50      	� 51      -   5        $ GreenRadioButton��52      $��0,0,8,0q�53      $��Green��54      	� 55      -   5        $ BlueRadioButton��56      $��0,0,8,0q�57      $
��Blue��58      59      �� 5;   
   $��4��5<      $��0��5=      $��Number of Bedrooms��5>      �� 5?   
   -   5         ��Name$ NumberOfBedroomsTextBox��5@      $��4��5A      $��2��5B      $��Center=�5C      $��0��5D      �� 5G   
   $��6��5H      $��0��5I      $��Additional Options��5J      � 5K   
   $��6��5L      $��2��5M      $��Center=�5N      .+�5O      �� -   5         ��Name$ SwimmingPoolCheckBox��5P      $��0,0,8,0q�5Q      $��Swimming Pool��5R      �� 5S      -   5        $ SolarRoofCheckBox��5T      $��0,0,8,0q�5U      $��
Solar Roof��5V      �� 5W      -   5        $ GardenCheckBox��5X      $��0,0,8,0q�5Y      $��Garden��5Z      5[      �� 5]   
   -   5         ��Name$ SubmitButton��5^      $��8��5_      $��3��5`      $	��0,4q�5a      $��Submit��5c      5d      5e      