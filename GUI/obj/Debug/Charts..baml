   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	   > :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI 5   	      
GUI.Charts   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;toolkit-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit  5   	   localclr-namespace:GUI  5   	     � Title$  Charts��5
   	   $��342.672��6   $��671.121��6)   .��5      � $��0,0,-25,-20q�6    � ColumnDefinitions 5   
   �� 5      $	��34* �6   �� 5      $
��549* �6   �� 5      $	��26* �6   �� 5      $	��80* �6   .+�5   
   >   8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��chart��5       $
��Left=�6-   $��	10,47,0,0q�6H   $	��Top=�6[   $	��652��6s   $	��263��6   $��4��6�      Series. 5      C   =System.Windows.Controls.DataVisualization.Charting.LineSeries  $��	0,-3,-2,2q�6�   H   BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   ItemsSource 6)   ��    IndependentValueBinding 6A   ��  �� Path$
 Date�   DependentValueBinding 6o   �� $ SellRate� � DataContext 6�   �� 6�   5      �� 5   
   -   5         ��Name$
 Show��5      $
��Show��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $��75��6t   $��2��6   6�   	� 5   
   -   5        	 	�Name$		 EUR��5      $	��EUR��6#   $
��Left=�62   $��	67,13,0,0q�6M   $	��Top=�6`   $��25��6x   $��91��6�   $��1��6�   	� 5   
   -   5        $		 USD��5      $	��USD��6#   $
��Left=�61   $��
174,13,0,0q�6L   $	��Top=�6`   $��1��6x   	� 5   
   -   5        $		 CHF��5      $	��CHF��6#   $��1��61   $
��Left=�6A   $��
120,13,0,0q�6\   $	��Top=�6p   
 J� RenderTransformOrigin$
 0.015,1.423&�6�   	� 5   
   -   5        $		 GBP��5      $	��GBP��6#   $��1��61   $
��Left=�6A   $��
230,13,0,0q�6\   $	��Top=�6p   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 From��5      $��1��6#   $
��Left=�63   $��
318,10,0,0q�6N   $	��Top=�6b     5   
   -   5        $ To��5      $��1��6!   $
��Left=�61   $��
446,10,0,0q�6L   $	��Top=�6`   �� 5   
   -	   5         ��Name$ 	fromLabel��5      $��From:��6#   $��1��63   $
��Left=�6C   $��	273,8,0,0q�6^   $	��Top=�6q   �� 5   
   -
   5        $ ToLabel��5      $	��To:��6!   $��1��6/   $
��Left=�6?   $��	420,8,0,0q�6Z   $	��Top=�6m   5      5      