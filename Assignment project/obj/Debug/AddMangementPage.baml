   M S B A M L   `   `   `  ����M  IAssignment project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Assignment_projectAssignment_project  5      )    #Assignment_project.AddMangementPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Assignment_project     5        N� Title$  AddMangementPage��5	      .��5      � ���	#FFA0ABAB$	��800��6"   $	��450��6.   .+�5   
   �� $��Task ID��6   $��20(�6#   $��Segoe UI Variable Display)�61   $��22,14,686,13q�6X   �� 5   
   -   5        $��	taskidtxt��5      $��107,13,493,13q�6#   �� 5   
   $��Status��6   $��20(�6"   $��Segoe UI Variable Display)�60   $��463,10,245,17q�6W    J� RenderTransformOrigin$ 0.947,0.511&�6n   �� 5   
   -   5        $��statxt��5      $��536,10,64,16q�6!   .@�5      �� .��6   	Pending6$   �� 5      .��6   	Inprogras6&   �� 5      .��6   	Completed6&   5      �� 5   
   $��Title��6   $��20(�6!   $��Segoe UI Variable Display)�6/   $��27,6,681,24q�6V   $ 0.947,0.511&�6k   $��1��6�   �� 5   
   -   5        $��titletxt��5      $��106,10,494,18q�6"   $��1��69   �� 5   
   $��Email��6   $��20(�6!   $��Segoe UI Variable Display)�6/   $��463,10,245,17q�6V   $ 0.947,0.511&�6m   $��1��6�   �� 5   
   -   5        $��emailtxt��5      $��536,10,64,16q�6"   $��1��69   �� 5   
   $��Descreption��6   $��20(�6'   $��Segoe UI Variable Display)�65   $��33,15,643,12q�6\   $ 0.947,0.511&�6r   $��2��6�   �� 5   
   -   5        $
��dtxt��5      $��177,10,423,16q�6   $��2��66   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dg��5      $��3��6   $��83,6,102,69q�6*   $��2��6?   �� 5   
   -   5        $	��ADD��5      $��4��6   $��9,14,650,13q�6,   $��25(�6A   6O   �� 5    
   -   5        $��Search��5       $��4��6"   $��188,13,471,14q�6/   $��25(�6F   $ 0.474,0.408&�6j   �� 5!   
   -	   5        $��Delete��5!      $��4��6"   $��378,15,281,12q�6/   $��25(�6F   6T   �� 5"   
   -
   5        $��Update��5"      $��4��6"   $��587,17,72,10q�6/   $��25(�6E   6S    � RowDefinitions 5#   
   �� 5$      $	��60* �6   �� 5%      $	��60* �6   �� 5&      $	��60* �6   �� 5'      $
��199* �6   �� 5(      $	��70* �6   5*      5+      