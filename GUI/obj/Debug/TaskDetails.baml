   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.TaskDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  TaskDetails��5   	   $	��300��6   $	��300��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ TaskID��5
      $��Task ID:��6    $
��Left=�63   $��	25,25,0,0q�6N   $	��Top=�6a   $��85��6y   �� 5   
   -   5        $ CurrencyCode��5      $��Currency Code: ��6&   $
��Left=�6@   $��	25,56,0,0q�6[   $	��Top=�6n   $	��223��6�   �� 5   
   -   5        $ BuyRate��5      $��	Buy Rate:��6!   $
��Left=�65   $��
25,180,0,0q�6P   $	��Top=�6d   $	��108��6|   �� 5   
   -   5        $ SellRate��5      $��
Sell Rate:��6"   $
��Left=�67   $��
25,149,0,0q�6R   $	��Top=�6f   $	��108��6~   �� 5   
   -   5        $ EndDate��5      $��
End Date: ��6!   $
��Left=�66   $��
25,118,0,0q�6Q   $	��Top=�6e   $��85��6}   �� 5   
   -   5        $ 	StartDate��5      $��Start Date:��6#   $
��Left=�69   $��	25,87,0,0q�6T   $	��Top=�6g   $��85��6   �� 5   
   -   5        $ TargetCourse��5      $��Target Course:��6&   $
��Left=�6?   $��
25,206,0,0q�6Z   $	��Top=�6n   $	��108��6�   �� 5   
   -   5         ��Name$ sellRate��5      $
��Left=�6$   $��23��6?   $��128,152,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -	   5        $ buyRate��5      $
��Left=�6#   $��23��6>   $��128,183,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -
   5        $ targetCourse��5      $
��Left=�6(   $��23��6C   $��128,211,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	startDate��5      $
��Left=�6(   $��
128,87,0,0q�6C   $	��Top=�6W   $	��120��6o     5   
   -   5        $ endDate��5      $
��Left=�6&   $��128,123,0,0q�6A   $	��Top=�6V   $	��120��6n   �� 5   
   -   5         ��Name$
 edit��5      $
��Edit��6   $
��Left=�6.   $��108,239,0,0q�6I   $	��Top=�6^   $��84��6v   6�   �� 5   
   -   5        $ ID��5      $�� ��6   $
��Left=�6'   $��
128,25,0,0q�6B   $	��Top=�6V    J� RenderTransformOrigin$ 0.439,0.426&�6n   $��64��6�   5      5      