   M S B A M L   `   `   `  ����D  @projectex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projectex	projectex  5   	       projectex.UpdateCourse7   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:projectex     5   	     � Title$  UpdateCourse7��5   	   $	��550��6   $	��900��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid1��5   '   $	��148��5      $
��Left=�6    $��0��6;   $��3��6H   $��
150,30,0,0q�5      $	��Top=�6:   $	��600��6R   6x   �� 5    
   -   5         ��Name$ Course_name��5    '   $��Course_Name:��6   $��1��6<   $��0��6I   $��Right=�6Y   $��0 20 0 0q�6u   �� 5!   
   -   5         ��Name$ Course_Name��5!   ;    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6'   $��1��6P   $��1��6]   $��0 20 0 0q�6m   $	��200��6�   �� 5#   
   -   5        $ Course_eDiscription��5#   /   $��Course_eDiscription:��6   $��2��6L   $��0��6Y   $��Right=�6i   �� 5$   
   -   5        $ Course_EDiscription��5$   ;    . $
 Wrap=�6'   $��2��6X   $��1��6e   $��5q�6u   $	��200��6�   �� 5&   
   -   5        $ 
Max_degree��5&   &   $��Max_Degree:��6   $��3��6:   $��0��6G   $��Right=�6W   �� 5'   
   -   5        $ 
Max_Degree��5'   <    . $
 Wrap=�6(   $��1��6P   $��3��6`   $��5q�6m   $	��200��6x   �� 5)   
   -   5        $ 
Min_degree��5)   &   $��Min_Degree:��6   $��4��6:   $��0��6G   $��Right=�6W   �� 5*   
   -	   5        $ 
Min_Degree��5*   <    . $
 Wrap=�6(   $��1��6P   $��4��6`   $��5q�6m   $	��200��6x   �� 5,   
   -
   5        $ Instructor_id��5,   &   $��Instructor:��6   $��5��6=   $��0��6J   $��Right=�6Z   �� 5-   
   -   5         ��Name$ Instructor_Id��5-   2   $��5��6   $��1��6!   6K   �� 5.   
   -   5        $ Track_id��5.   !   $��Track:��6   $��6��63   $��0��6@   $��Right=�6P   �� 5/   
   -   5        $ Track_Id��5/   2   $��6��6   $��1��6!   6F   �� 50   
   -   5        	 ��Name$
	 save��50      $
��Save��6   $��7��6.   $��1��6;   6K   �� 51   
   -   5        $	 delete��51      $��Delete��6!   $��8��62   $��1��6?   6O   52      53      