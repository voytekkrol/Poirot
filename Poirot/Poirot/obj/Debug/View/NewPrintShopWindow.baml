   M S B A M L   `   `   `  ����A  =Poirot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Poirot.ViewPoirot.View  5   	   3clr-namespace:Poirot.ViewmodelPoirot.Viewmodel  5   	   $    Poirot.View.NewPrintShopWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Poirot.View     5   	   -vmclr-namespace:Poirot.Viewmodel     5   	     � Title$  NewPrintShopWindow��5	   	   $	��400��6$   $	��400��61    � 	Resources 5
      (  "Poirot.Viewmodel.AddNewPrintShopVM   vm��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $
��Name��6   $��0��5      $��0��5      $��5q�5      �� 5   
   -   5         ��Name$ nameTextBox��5      $��1��5       $��0��5!      $��5q�5"      ��5#      �� *NewPrintShop.Name+�� 5$   
   $��Owner��6   $��0��5%      $��1��5&      $��5q�5'      �� 5(   
   -   5        $ ownerTextBox��5(      $��1��5)      $��1��5*      $��5q�5+      ��5,      �� *NewPrintShop.Owner+�� 5-   
   $��Adress��6   $��0��5.      $��2��5/      $��5q�50      �� 51   
   -   5        $ adressTextBox��51      $��1��52      $��2��53      $��5q�54      ��55      �� *NewPrintShop.Adress+�� 56   
   $��Phone��6   $��0��57      $��3��58      $��5q�59      �� 5:   
   -   5        $ phoneTextBox��5:      $��1��5;      $��3��5<      $��5q�5=      ��5>      �� *NewPrintShop.Phone+�� 5?   
   $��Email��6   $��0��5@      $��4��5A      $��5q�5B      �� 5C   
   -   5        $ emailTextBox��5C      $��1��5D      $��4��5E      $��5q�5F      ��5G      �� *NewPrintShop.Email+�� 5H   
   -   5         ��Name$ AddNewPrintShopButton��5H      $��Add Printshop��5I      $��1��5J      $��5��5K      $��Right=�5L      ��5M      �� *AddNewPrintShopCommand+5O      5P      