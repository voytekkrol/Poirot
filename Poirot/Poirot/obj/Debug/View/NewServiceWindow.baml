   M S B A M L   `   `   `  ����A  =Poirot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Poirot.ViewPoirot.View  5   	   3clr-namespace:Poirot.ViewmodelPoirot.Viewmodel  5   	   "    Poirot.View.NewServiceWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Poirot.View     5   	   -vmclr-namespace:Poirot.Viewmodel     5   	     � Title$  NewServiceWindow��5	   	   $	��600��6"   $	��400��6/    � 	Resources 5
      &   Poirot.Viewmodel.AddNewServiceVM   vm��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Title��6   $��0��5      $��0��5       $��5q�5!      �� 5"   
   -   5         ��Name$ titleTextBox��5"      $��1��5#      $��0��5$      $��5q�5%      ��5&      �� *NewService.Title+�� 5'   
   $��Hours��6   $��0��5(      $��1��5)      $��5q�5*      �� 5+   
   -   5        $ hoursTextBox��5+      $��1��5,      $��1��5-      $��5q�5.      ��5/      �� *NewService.Hours+�� 50   
   $��Serviceman 1��6   $��0��51      $��2��52      $��5q�53      �� 54   
   $��1��6   $��2��55      $	��285��56      $��5q�57      $
��Left=�58      ��59      �� *ListOfServicemen+ �� Mode$ TwoWay=� �� SelectedItem 5:      �� *SelectedServiceman1+$ TwoWay=��� 5;   
   $��Serviceman 2��6   $��0��5<      $��3��5=      $��5q�5>      �� 5?   
   $��1��6   $��3��5@      $	��285��5A      $��5q�5B      $
��Left=�5C      ��5D      �� *ListOfServicemen+$ TwoWay=� 5E      �� *SelectedServiceman2+$ TwoWay=��� 5F   
   $��	PrintShop��6   $��0��5G      $��4��5H      $��5q�5I      �� 5J   
   $��1��6   $��4��5K      $	��285��5L      $��5q�5M      $
��Left=�5N      ��5O      �� *ListOfPrintShopsNames+$ TwoWay=� 5P      �� *SelectedPrintShopName+$ TwoWay=��� 5Q   
   $��Machine��6   $��0��5R      $��5��5S      $��5q�5T      �� 5U   
   $��1��6   $��5��5V      $	��285��5W      $��5q�5X      $
��Left=�5Y      ��5Z      �� *ListOfMachinesNames+$ TwoWay=� 5[      �� *SelectedMachineName+$ TwoWay=�`� 5\   
   $��1��6   $��6��5]      5_      �� 5`   
   $��Description��6   $��0��5a      $��6��5b      $��2��5c      $��5q�5d      �� 5e   
   $��1��6   $��7��5f      $��5q�5g       �� TextWrapping$
 Wrap=�5h      ��5i      �� *NewService.Description+�� 5j   
   -   5        	 ��Name$	 AddNewService��5j      $��Add Service��5k      $��1��5l      $��8��5m      $��5q�5n      $��Right=�5o      ��5p      �� *AddNewServiceCommand+5q      5r      5s      