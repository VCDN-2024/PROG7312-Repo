   M S B A M L   `   `   `  ����  PriorityQueuePrinterExample%    PrintJobQueueExample.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Print Job Queue System��5   	   $	��470��6(   $	��625��65   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6!   $��Print Job Queue System��5      $��20(�5      $
��Bold"�6"   $��Center=�5      $��0,0,0,10q�61   �� 5   
   $��1��6   $��0��6!   $��Document Name:��61   $	��0,5q�6G   $��Center=�6T   �� 5   
   -   5         ��Name$ DocumentNameTextBox��5      $��1��6/   $��1��6<   $��5q�6L   �� 5   
   $��2��6   $��0��6!   $��Job Priority:��61   $��0,19,0,0q�6F   $	��Top=�6X   �� 5   
   -   5         ��Name$ JobPriorityComboBox��5      $��2��60   $��1��6=   $��	6,5,5,115q�6M   .@�5      �� $��Urgent��6   �� 5      $
��High��6   �� 5       $��Normal��6   �� 5!      $	��Low��6   5"      �� 5%   
   -   5        $��2��5%      $��1��6   $��Add Print Job��5&      $	��185��5'      $��
0,79,40,10q�6   $��Right=�5(      5)      �� 5,   
   -   5         ��Name$ PrintQueueListBox��5,      $��4��6-   $��2��6:   $��0,10,0,0q�5-      $	��200��6$   �� 50   
   -   5        $��2��50      $��2��6   $��Process Next Print Job��51      $	��200��52      $��	5,74,0,10q�6   $
��Left=�53      54      55      56      