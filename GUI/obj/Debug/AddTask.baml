   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.AddTask   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  AddTask��5   	   $	��300��6   $	��300��6&   .��5	      � .+�5
   
   �� -   5         ��Name$ 	StartDate��5
      $��Start Date:��6#   $
��Left=�69   $��	47,84,0,0q�6T   $	��Top=�6g   $��75��6   �� 5   
   -   5        $ 	End_Date_��5      $��	End Date:��6#   $
��Left=�67   $��
173,84,0,0q�6R   $	��Top=�6f   $��60��6~   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	startDate��5      $
��Left=�6(   $��
36,115,0,0q�6C   $	��Top=�6W     5   
   -   5        $ EndDate��5      $
��Left=�6&   $��158,115,0,0q�6A   $	��Top=�6V   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��
144,23,0,0q�6@   $	��Top=�6T   $	��102��6l   �� 5   
   -   5        $ Choose_Currency��5      $��Choose Currency:��6)   $
��Left=�6D   $��	37,21,0,0q�6_   $	��Top=�6r   $	��106��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.345Q�6&   T� 5      5      5      	� 5   
   -   5         	�Name$ sellRate��5      $��Sell Rate
��6(   $
��Left=�6F   $��	77,57,0,0q�6a   $	��Top=�6t   	� 5   
   -   5        $ buyRate��5      $��
Buy Rate
��6'   $
��Left=�6D   $��
158,57,0,0q�6_   $	��Top=�6s   �� 5   
   -	   5         ��Name$ addTask��5      $��Add Task��6"   $
��Left=�65   $��
36,216,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -
   5         ��Name$ targetCourse��5      $
��Left=�6(   $��23��6C   $��158,158,0,0q�6O   	 �� TextWrapping$
	 Wrap=�6d   $��
��6x   $	��Top=�6�   $	��102��6�   �� 5   
   -   5        $ Target_Course��5      $��Target Rate:��6'   $
��Left=�6>   $��
36,155,0,0q�6Y   $	��Top=�6m   $��86��6�   �� 5   
   -   5        
 ��Name$
 slider��5      $��153,190,37,0q�6!   $	��Top=�67    � Maximum$ 10Q�6O    �� TickPlacement$ BottomRight=�6\    �� TickFrequency$ 1Q�6x    �� IsSnapToTickEnabled . 6�   �� 5   
   -   5        $ 	Tolerance��5      $��
Tolerance:��6#   $
��Left=�68   $��
36,186,0,0q�6S   $	��Top=�6g   $	��102��6   �� 5    
   -   5        $ ToleranceValue��5       $�� ��6(   $
��Left=�63   $��255,190,0,0q�6N   $	��Top=�6c   $��37��6{   �� 5!   
   -   5        $ Formula��5!      $��Target rate - Tolerance��6!   $
��Left=�6C   $��144,217,0,0q�6^   $	��Top=�6s   $	��138��6�   5"      5#      