   M S B A M L   `   `   `  ����D  @projectex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projectex	projectex  5   	        projectex.Question_Update9   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:projectex     5   	     � Title$  Question_Update9��5   	   $	��450��6"   $	��950��6/   .��5	      �  � RowDefinitions 5
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
110,30,0,0q�5      $	��Top=�6:   $	��600��6R   6^   �� 5!   
   -   5         ��Name$ Question_body��5!   )   $��Question_Body:��6   $��1��6@   $��0��6M   $��Right=�6]   �� 5"   
   -   5         ��Name$ Question_Body��5"   <    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6(   $��1��6S   $��1��6c   $��5q�6p   $	��200��6{   �� 5'   
   -   5         ��Name$
 save��5'      $
��Save��6   $��2��6.   $��1��6;   6K   �� 5(   
   -   5        $ delete��5(      $��Delete��6!   $��3��62   $��1��6?   6O   5*      5+      