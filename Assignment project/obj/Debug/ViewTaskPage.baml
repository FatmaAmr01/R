   M S B A M L   `   `   `  ����M  IAssignment project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Assignment_projectAssignment_project  5      %    Assignment_project.ViewTaskPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Assignment_project     5        N� Title$  ViewTaskPage��5	      .��5      � ���	#FFA0ABAB$	��800��6"   $	��450��6.   .+�5   
   �� -   5         ��Name$ txtname��5      $�� ��6!   $
��Left=�6,   $	��Top=�6G   $��30(�6_   $��Arial Black)�6m   $��
208,-8,0,0q�6�   �� 5   
   $��Pending/Inprogras��6   $��20(�6,   $��Arial Black)�6:   $��1��6S   $��11,7,568,117q�6`   
�������6v   &   System.Windows.Controls.DataGrid  5   
   -   5        $��pdgtxt��5      $��1��6!   $��162,51,162,0q�6.   �� 5   
   $��Task ID��6   $��20(�6#   $��2��61   $��
20,6,702,6q�6>   $��Segoe UI Variable Display)�6R   �� 5   
   -   5        $��	taskidtxt��5      $��2��6#   $��118,4,591,10q�60   �� 5   
   -   5        $
��ctxt��5      $��2��6   $��370,4,165,11q�6,   .@�5      �� .��6   	Pending6$   �� 5      .��6   	Inprogras6&   �� 5      .��6   	Completed6&   5      �� 5   
   $��Status��6   $��20(�6#   $��2��61   $��Segoe UI Variable Display)�6>   $��295,9,442,14q�6e   �� 5   
   -   5        $
��Save��5      $��648,6,12,12q�6    $��2��65   $��20(�6C   6Q   �� 5   
   $��	Completed��6   $��20(�6$   $��Arial Black)�62   $��3��6K   $��11,7,568,156q�6X   
�������6n     5   
   -   5        $��cdgtxt��5      $��3��6!   $��162,51,162,12q�6.    � RowDefinitions 5   
   �� 5       $	��20* �6   �� 5!      $	��80* �6   �� 5"      $	��24* �6   �� 5#      $
��101* �6   5&      5'      