   M S B A M L   `   `   `  ����F  BCalcProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CalcProjectCalcProject  5   	       CalcProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CalcProject     5   	   -   5          � Title$  Калькулятор��5   	   $	��480��6   $	��640��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ CanMinimize=�6[    � Icon 5	      �� 5
   
    �� 	UriSource$O Ifile:///C:/GB/C%23. My projects/CalculatorRep/CalcSolution/calculator.png?�6   .��5      � .+�5   
   �� $��
Табло��6   $��66��6"   $��	10,10,0,0q�6.   $	��Top=�6A   .��5      �� -   5         ��Name$ lblTablo��5      $��0��6&   $��4,-6,0,0q�62   $	��Top=�6D   $��36(�6\   $��	Open Sans)�6j   5      �� 5   
   $��Опции табло��6   $��50��6(   $��	10,76,0,0q�64   $��Stretch=�6G   $	��Top=�6j   $��Stretch=�6�   .��5      � $��0q�6   .+�5      �� -   5         ��Name$ btnClear��5      $��Очистить��6+   $
��Left=�6>   $��0,1,0,0q�6Y   $	��Top=�6j   $��75��6�   $��25��6�   6�   �� 5      -   5        $ btnBackspace��5      $��Удалить��6/   $
��Left=�6A   $��80,1,0,0q�6\   $	��Top=�6n   $��75��6�   $��25��6�   6�   5      5      �� 5   
   $%��Базовые операции��6   $��50��6-   $��
10,126,0,0q�69   $��Stretch=�6M   $	��Top=�6p   $��Stretch=�6�   .��5      � $��0q�6   .+�5      �� $��+��6   $
��Left=�6%   $��0,1,0,0q�6@   $	��Top=�6Q   $��30��6i   $��25��6t   �� 5      $��-��6   $
��Left=�6%   $��35,1,0,0q�6@   $	��Top=�6R   $��30��6j   $��25��6u   �� 5      $��Х��6   $
��Left=�6%   $��70,1,0,0q�6@   $	��Top=�6R   $��30��6j   $��25��6u   �� 5      $��/��6   $
��Left=�6%   $��	105,1,0,0q�6@   $	��Top=�6S   $��30��6k   $��25��6v   �� 5      $��=��6   $
��Left=�6%   $��	140,1,0,0q�6@   $	��Top=�6S   $��30��6k   $��25��6v   5      5      �� 5   
   $��
Цифры��6   $��
10,181,0,0q�6"   $��Stretch=�66   $��Stretch=�6Y   $
��Left=�6~   $	��Top=�6�   .��5       � $��0q�6   .+�5!      �� -   5        $
 btn1��5!      $��1��6'   $
��Left=�63   $��0,1,0,0q�6N   $	��Top=�6_   $��30��6w   $��25��6�   6�   �� 5"      -   5        $
 btn2��5"      $��2��6'   $
��Left=�63   $��35,1,0,0q�6N   $	��Top=�6`   $��30��6x   $��25��6�   6�   �� 5#      -   5        $
 btn3��5#      $��3��6'   $
��Left=�63   $��70,1,0,0q�6N   $	��Top=�6`   $��30��6x   $��25��6�   6�   �� 5$      -   5        $
 btn4��5$      $��4��6'   $
��Left=�63   $��0,31,0,0q�6N   $	��Top=�6`   $��30��6x   $��25��6�   6�   �� 5%      -	   5        $
 btn5��5%      $��5��6'   $
��Left=�63   $��	35,31,0,0q�6N   $	��Top=�6a   $��30��6y   $��25��6�   6�   �� 5&      -
   5        $
 btn6��5&      $��6��6'   $
��Left=�63   $��	70,31,0,0q�6N   $	��Top=�6a   $��30��6y   $��25��6�   6�   �� 5'      -   5        $
 btn7��5'      $��7��6'   $
��Left=�63   $��0,61,0,0q�6N   $	��Top=�6`   $��30��6x   $��25��6�   6�   �� 5(      -   5        $
 btn8��5(      $��8��6'   $
��Left=�63   $��	35,61,0,0q�6N   $	��Top=�6a   $��30��6y   $��25��6�   6�   �� 5)      -   5        $
 btn9��5)      $��9��6'   $
��Left=�63   $��	70,61,0,0q�6N   $	��Top=�6a   $��30��6y   $��25��6�   6�   �� 5*      -   5        $
 btn0��5*      $��0��6'   $
��Left=�63   $��0,91,0,0q�6N   $	��Top=�6`   $��65��6x   $��25��6�   6�   �� 5+      -   5        $ btnPoint��5+      $��.��6+   $
��Left=�67   $��	70,91,0,0q�6R   $	��Top=�6e   $��30��6}   $��25��6�   6�   5,      5-      5.      5/      