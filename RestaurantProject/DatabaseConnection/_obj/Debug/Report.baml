   M S B A M L   `   `   `  ����M  IDatabaseConnection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ManagerPOS
ManagerPOS  5   	       ManagerPOS.Report   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ManagerPOS     5   	     � Title$  
MainWindow��5   
   $	��600��6   $	��900��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��125* �6   �� 5      $
��767* �6   .+�5   
   �� $
��Left=�6   $	��422��60   $��	26,69,0,0q�6=   $	��Top=�6P   $	��829��6h   $��2��6t   .@�5      �� $��	Top5 Sale��6   $	��100��6)   $��40��65   .��5      �� .+�5      (  "System.Windows.Controls.DatePicker  -   5        $��dpicker��5   !   $��27��60   $	��145��6<    �� Left$ 21��6H   
 �� Top$ 17��6Y   6i   �� 5      -   5         ��Name$ lstMain��5      $
��Left=�60   $	��243��6K   $	��Top=�6X   $	��153��6p   $	 248��6|   $	 122��6�    �� View 5      �� 5      .P�5   "   �� $��Item ��61    �� Width$	 100��6@    �� DisplayMemberBinding 6L   �� *
MenuName+�� 5   "   $	��Qty��61   $ 50��6>    6I   �� *Qty+5      .@�5      �� -   5        $ lstOrderItem_Copy2��5   #   $
��Left=�6?   $	��243��6Z   $	��Top=�6g   $	��153��6    5      �� 5   "   .P�5   &   �� $��Item ��65   $	 100��6D    6P   �� *
MenuName+�� 5   &   $	��Qty��65   $ 50��6B    6M   �� *Qty+5"   #   5%      5'      �� 5(      -   5        $ 
lstStarter��5(      $
��Left=�63   $	��243��6N   $	��Top=�6[   $	��153��6s   $	 418��6   $	 122��6�    5)      �� 5*      .P�5+   "   �� $��Item ��61   $	 100��6@    6L   �� *
MenuName+�� 5,   "   $	��Qty��61   $ 50��6>    6I   �� *Qty+5/      52      �� 53      -   5        $ lstDrink��53      $
��Left=�61   $	��243��6L   $	��Top=�6Y   $	��153��6q   $ 90��6}   $	 122��6�    54      �� 55      .P�56   "   �� $��Item ��61   $	 100��6@    6L   �� *
MenuName+�� 57   "   $	��Qty��61   $ 50��6>    6I   �� *Qty+5:      5=      �� 5>      -   5        $ 
lstDessert��5>      $
��Left=�63   $	��243��6N   $	��Top=�6[   $	��153��6s   $	 576��6   $	 122��6�    5?      �� 5@      .P�5A   "   �� $��Item ��61   $	 100��6@    6L   �� *
MenuName+�� 5B   "   $	��Qty��61   $ 50��6>    6I   �� *Qty+5E      5H      �� 5I      $��Drink��6   $ 90��6,   $ 86��6=   $��60��6M   �� 5J      $
��Main��6   $	 248��6+   $ 86��6=   $��60��6M   �� 5K      $��Starter��6   $	 418��6.   $ 91��6@   $��60��6P   �� 5L      $��Dessert��6   $	 576��6.   $ 91��6@   $��60��6P   5N      5O      �� 5P      $��Sales��6   $	��100��6%   $��40��61   .��5Q      �� $	��100��6   $	��200��6&   5R      5U      �� 5V   
   -   5        $��btMain��5V      $��Back to Main��6   $
��Left=�66   $��	26,32,0,0q�6Q   $	��Top=�6d   $��89��6|   $��32��6�   6�   5X      5Y      