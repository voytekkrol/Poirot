   M S B A M L   `   `   `  ����A  =Poirot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Poirot.ViewPoirot.View  5   	   3clr-namespace:Poirot.ViewmodelPoirot.Viewmodel  5   	   "    Poirot.View.NewMachineWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Poirot.View     5   	   -vmclr-namespace:Poirot.Viewmodel     5   	     � Title$  NewMachineWindow��5	   	   $	��400��6"   $	��400��6/    � 	Resources 5
      &   Poirot.Viewmodel.AddNewMachineVM   vm��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $
��Type��6   $��0��5      $��0��5      $��5q�5      �� 5   
   -   5         ��Name$ typeTextBox��5      $��1��5      $��0��5       $��5q�5!      ��5"      �� *NewMachine.Type+�� 5#   
   $��Serial Number��6   $��0��5$      $��1��5%      $��5q�5&      �� 5'   
   -   5        $ serialNumberTextBox��5'      $��1��5(      $��1��5)      $��5q�5*      ��5+      �� *NewMachine.SerialNumber+�� 5,   
   $��Year of Production��6   $��0��5-      $��2��5.      $��5q�5/      �� 50   
   -   5        $ yearOFProductionTextBox��50      $��1��51      $��2��52      $��5q�53      ��54      �� *NewMachine.YearOfProduction+�� 55   
   $��Sheet printed��6   $��0��56      $��3��57      $��5q�58      �� 59   
   -   5        $ sheetPrintedTextBox��59      $��1��5:      $��3��5;      $��5q�5<      ��5=      �� *!NewMachine.NumberOfSheetPrinted+�� 5>   
   $��	Printshop��6   $��0��5?      $��4��5@      $��5q�5A      �� 5B   
   $��1��6   $��4��5C      $	��267��5D      $��5q�5E      $
��Left=�5F      ��5G      �� *ListOfPrintShopsNames+ �� Mode$ TwoWay=� �� SelectedItem 5H      �� *SelectedPrintShopName+$ TwoWay=��� 5I   
   $��Add Machine��6   $��1��5J      $��5��5K      $��Right=�5L      $��5q�5M      ��5N      �� *AddNewMachineCommand+5O      5P      