   M S B A M L   `   `   `  ����D  @projectex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projectex	projectex  5   	       projectex.updateexam   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:projectex     5   	     � Title$  Exam_Update��5   	   $	��550��6   $	��900��6*   $
��Bold"�66   ���#e1f4f3.��5	      �  � RowDefinitions 5
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
150,30,0,0q�5      $	��Top=�6:   $	��600��6R   6^   �� 5    
   -   5         ��Name$ 	Exam_name��5    %   $��
Exam_Name:��6   $��2��68   $��0��6E   $��Right=�6U   �� 5!   
   -   5         ��Name$ 	Exam_Name��5!   O   
���   � �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6;   $��2��6b   $��1��6o   $��5q�6   $	��200��6�   �� 5$   
   -   5        $ 
MCQ_degree��5$   &   $��MCQ_Degree:��6   $��4��6:   $��0��6G   $��Right=�6W   �� 5%   
   -   5        $ 
MCQ_Degree��5%   P   
���   � . $
 Wrap=�6<   $��1��6d   $��4��6t   $��5q�6�   $	��200��6�   �� 5'   
   -   5        $ 
T_F_degree��5'   &   $��T_F_Degree:��6   $��5��6:   $��0��6G   $��Right=�6W   �� 5(   
   -   5        $ 
T_F_Degree��5(   P   
���   � . $
 Wrap=�6<   $��1��6d   $��5��6t   $��5q�6�   $	��200��6�   �� 5*   
   -   5        $ Text_degree��5*   '   $��Text_Degree:��6   $��6��6<   $��0��6I   $��Right=�6Y   �� 5+   
   -	   5        $ Text_Degree��5+   P   
���   � . $
 Wrap=�6<   $��1��6e   $��6��6u   $��5q�6�   $	��200��6�   �� 5-   
   -
   5         ��Name$
 Save��5-   E   $��10q�6   ���#333333
�������$
��Save��6S   $��7��6b   $��1��6o   6   �� 5.   
   -   5        $ Delete��5.   E   $��10q�6   ���#333333
�������$��Delete��6U   $��8��6f   $��1��6s   6�   5/      50      