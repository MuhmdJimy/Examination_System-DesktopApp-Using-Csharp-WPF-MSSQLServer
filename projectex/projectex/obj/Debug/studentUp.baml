   M S B A M L   `   `   `  ����D  @projectex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projectex	projectex  5   	       projectex.studentUp   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:projectex     5   	     � Title$  	studentUp��5   	   $	��650��6   $	��900��6(   .��5	      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid1��5   '   $	��148��5      $
��Left=�6    $��0��6;   $��3��6H   $��
150,30,0,0q�5      $	��Top=�6:   $	��600��6R   6x   �� 5"   
   -   5         ��Name$ Student_name��5"   (   $��Student_Name:��6   $��2��6>   $��0��6K   $��Right=�6[   �� 5#   
   -   5         ��Name$ Student_Name��5#   ;    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6'   $��2��6Q   $��1��6^   $��5q�6n   $	��200��6y   �� 5(   
   -   5        $ student_code��5(   (   $��student_code:��6   $��3��6>   $��0��6K   $��Right=�6[   �� 5)   
   -   5        $ student_Code��5)   ;    . $
 Wrap=�6'   $��1��6Q   $��3��6a   $��5q�6n   $	��200��6y   �� 5+   
   -   5        $ 	Branch_id��5+   %   $��
Branch_Id:��6   $��4��68   $��0��6E   $��Right=�6U   �� 5-   
   -   5         ��Name$ 	Branch_Id��5-   1   $��4��6   $��1��6    6F   �� 50   
   -   5        $ 	Intake_id��50   %   $��
Intake_Id:��6   $��5��68   $��0��6E   $��Right=�6U   �� 51   
   -	   5        $ 	Intake_Id��51   1   $��5��6   $��1��6!   6F   �� 55   
   -
   5        $ Track_id��55   $   $��	Track_Id:��6   $��6��66   $��0��6C   $��Right=�6S   �� 56   
   -   5        $ Track_Id��56   1   $��6��6   $��1��6    6E   �� 5=   
   -   5        	 ��Name$
	 save��5=      $
��Save��6   $��7��6.   $��1��6;   6K   �� 5>   
   -   5        $	 delete��5>      $��Delete��6!   $��8��62   $��1��6?   6O   5?      5@      