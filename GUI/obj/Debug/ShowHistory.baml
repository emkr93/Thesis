   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.ShowHistory   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  ShowHistory��5   	   $	��400��6   $	��500��6*   .��5	      � $��0,0,2,-3q�6    � ColumnDefinitions 5
   
   �� 5      $	��35* �6   �� 5      $
��206* �6   �� 5      $	��23* �6   �� 5      $	��40* �6   �� 5      $
��120* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns . $
��Left=�6A   $��	0,136,0,0q�6\   $	��Top=�6o   $��5��6�   $	��237��6�   $	��490��6�   �� 5   
   -   5         ��Name$ SortBy��5      $��
Sort by:
��6    $
��Left=�6=   $��	16,10,0,0q�6X   $	��Top=�6k   $��2��6�   	� 5   
   -   5         	�Name$	 EUR��5      $	��EUR��6#   $
��Left=�62   $��	20,39,0,0q�6M   $	��Top=�6`   $��2��6x   $��25��6�   $��91��6�   	� 5   
   -   5        $	 USD��5      $	��USD��6#   $
��Left=�61   $��	20,64,0,0q�6L   $	��Top=�6_   $��2��6w   	� 5   
   -   5        $	 CHF��5      $	��CHF��6#   $��1��61   $
��Left=�6A   $��	33,39,0,0q�6\   $	��Top=�6o    J� RenderTransformOrigin$ 0.015,1.423&�6�   	� 5   
   -   5        $	 GBP��5      $	��GBP��6#   $��1��61   $
��Left=�6A   $��	33,64,0,0q�6\   $	��Top=�6o   �� 5   
   -   5         ��Name$
 Show��5      $
��Show��6   $
��Left=�6.   $��	20,97,0,0q�6I   $	��Top=�6\   $��75��6t   $��2��6   6�   	� 5   
   -   5        $	 ALL��5      $	��ALL��6#   $��1��61   $
��Left=�6A   $��	76,39,0,0q�6\   $	��Top=�6o   5      5      