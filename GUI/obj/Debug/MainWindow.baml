   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � $��0,0,-8,0q�6   .+�5
   
   �� -   5         ��Name$ title1��5
      $��Choose your currency:��6    $
��Left=�6@   $��
320,31,0,0q�6[   $	��Top=�6o   $	��133��6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��
320,57,0,0q�6@   $	��Top=�6T   $	��133��6l   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	beginDate��5      $
��Left=�6(   $��270,115,0,0q�6C   $	��Top=�6X     5   
   -   5        $ endDate��5      $
��Left=�6&   $��405,115,0,0q�6A   $	��Top=�6V   �� 5   
   -   5        $ Title2��5      $��Select the period��6    $
��Left=�6<   $��
337,84,0,0q�6W   $	��Top=�6k   $	��101��6�   � 5   
   -   5        $��pbStatus��5   0    � Minimum$ 0Q�6    � Maximum$	 100Q�6"    � IsIndeterminate . $y�Visible=�6X   $��337,185,72,110q�6m    J� RenderTransformOrigin$ 	0.485,0.5&�6�   �� 5   
   -   5        $
 From��5      $��From :��6   $
��Left=�6/   $��228,114,0,0q�6J   $	��Top=�6_   $��42��6w   $��24��6�   �� 5   
   -	   5        $ To��5      $	��To:��6   $
��Left=�6*   $��377,115,0,0q�6E   $	��Top=�6Z   �� 5   
   -
   5         ��Name$ RunApp��5      $	��Run��6!   $
��Left=�6/   $��337,158,0,0q�6J   $	��Top=�6_   $	��101��6w   6�   �� 5   
   -   5        $ History��5      $��View History��6"   $
��Left=�69   $��	10,70,0,0q�6T   $	��Top=�6g   $��93��6   6�   �� 5   
   -   5        $
 menu��5      $��Manu:��6   $
��Left=�6.   $��	10,39,0,0q�6I   $	��Top=�6\   $��78��6t   �� 5   
   -   5        $ 
ShowCharts��5      $��Show Charts��6%   $
��Left=�6;   $��	10,99,0,0q�6V   $	��Top=�6i   $��93��6�   6�   �� 5   
   -   5        $ Tasks��5      $��Tasks��6    $
��Left=�60   $��
10,126,0,0q�6K   $	��Top=�6_   $��93��6w   6�   �� 5   
   -   5        $ Forecasting��5      $��Forecast Rate��6&   $
��Left=�6>   $��
31,288,0,0q�6Y   $	��Top=�6m   $��93��6�   6�   	� 5   
   -   5        	 	�Name$	 SellRate��5      $��	Sell Rate��6(   $
��Left=�6<   $��
88,236,0,0q�6W   $	��Top=�6k   	� 5   
   -   5        $	 BuyRate��5      $��Buy Rate��6'   $
��Left=�6:   $��
88,257,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        
 ��Name$
 Monthly��5      $��Monthly��6$   $
��Left=�66   $��
10,239,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $
 Daily��5      $��Daily��6"   $
��Left=�62   $��
10,260,0,0q�6M   $	��Top=�6a   5      5      