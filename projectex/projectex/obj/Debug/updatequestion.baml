   M S B A M L   `   `   `  ����D  @projectex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:projectex	projectex  5   	       projectex.updatequestion   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:projectex     5   	   -   5          � Title$  Question_Update9��5   	   $	��450��6"   $	��950��6/   $
��Bold"�6R   ���#e1f4f3.��5	      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid1��5   &   $	��148��5      $
��Left=�6    $��0��6;   $��2��6H   $��	40,30,0,0q�5      $	��Top=�69   $	��600��6Q   6]   �� 5"   
   -   5         ��Name$ Question_body��5"   )   $��Question_Body:��6   $��1��6@   $��0��6M   $��Right=�6]   $��0,0,71,0q�6y   �� 5#   
   -   5         ��Name$ Question_Body��5#   P   
���   � �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6<   $��1��6g   $��
418,5,89,5q�6t   $	��200��6�   $��2��6�   �� 5(   
   -   5         ��Name$
 save��5(   O   $��410,10,81,10q�6   ���#333333
�������$
��Save��6]   $��2��6l   $��2��6�   �� 5)   
   -   5        $ delete��5)   O   $��410,10,81,10q�6   ���#333333
�������$��Delete��6_   $��3��6p   $��2��6�   �� 5*   
   $��Course Name : ��6   $��1��6)   $��223,29,-224,0q�69   $��2��6P   $��2��6a   6w   �� 5+   
   -   5        	 ��Name$
	 cmb1��5+   .   $
��Left=�6   $��
105,30,0,0q�6<   $	��120��6P   $��23��6\   $	��Top=�6h   $��2��6�   5-      5.      