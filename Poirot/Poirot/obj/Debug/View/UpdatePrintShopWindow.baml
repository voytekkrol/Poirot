   M S B A M L   `   `   `  ����A  =Poirot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Poirot.ViewPoirot.View  5   	   3clr-namespace:Poirot.ViewmodelPoirot.Viewmodel  5   	   '    !Poirot.View.UpdatePrintShopWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Poirot.View     5   	   -vmclr-namespace:Poirot.Viewmodel     5   	     � Title$  UpdatePrintShopWindow��5	   	   $	��400��6'   $	��400��64    � 	Resources 5
      !  Poirot.Viewmodel.ServicesVM   vm��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $
��Name��6   $��0��5      $��0��5      $��5q�5      �� 5    
   -   5         ��Name$ nameTextBox��5       $��1��5!      $��0��5"      $��5q�5#      ��5$      �� *SelectedPrintShop.Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5%   
   $��Owner��6   $��0��5&      $��1��5'      $��5q�5(      �� 5)   
   -   5        $ ownerTextBox��5)      $��1��5*      $��1��5+      $��5q�5,      ��5-      �� *SelectedPrintShop.Owner+$ TwoWay=�$ PropertyChanged=��� 5.   
   $��Adress��6   $��0��5/      $��2��50      $��5q�51      �� 52   
   -   5        $ adressTextBox��52      $��1��53      $��2��54      $��5q�55      ��56      �� *SelectedPrintShop.Adress+$ TwoWay=�$ PropertyChanged=��� 57   
   $��Phone��6   $��0��58      $��3��59      $��5q�5:      �� 5;   
   -   5        $ phoneTextBox��5;      $��1��5<      $��3��5=      $��5q�5>      ��5?      �� *SelectedPrintShop.Phone+$ TwoWay=�$ PropertyChanged=��� 5@   
   $��Email��6   $��0��5A      $��4��5B      $��5q�5C      �� 5D   
   -   5        $ emailTextBox��5D      $��1��5E      $��4��5F      $��5q�5G      ��5H      �� *SelectedPrintShop.Email+$ TwoWay=�$ PropertyChanged=��� 5I   
   -   5         ��Name$ AddNewPrintShopButton��5I      $��Add Printshop��5J      $��1��5K      $��5��5L      $��Right=�5M      ��5N      �� *AddNewPrintShopCommand+5P      5Q      