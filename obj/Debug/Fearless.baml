   M S B A M L   `   `   `  ����O  Ktswift album ranking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:tswift_album_rankingtswift_album_ranking  5      #    tswift_album_ranking.Fearless   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:tswift_album_ranking     5        N� Title$  Fearless��5	      .��5      � ��5   
   �� 5       �� ImageSource$ /fearlessbg.png��6   .+�5   
   A� -   5         A�Name$
 Back��5      $��0��6    $��15��6-   $��15��69   $��Right=�6D   $	��Top=�6`   $��
0,10,770,0q�6x    � ToolTip$
 Back��6�   ���	#FF9464366�   �� 5   
   -   5        $
��Save��5         RoundButtonTemplate#��[  5      $	��200��5      $��40��6   ���#fff$��Save ranking��5      $��500,320,100,90q�5      $��Franklin Gothic Demi Cond)�5      $��22(�5      ���	#FFB08A4C5   &   �� 5   
   -   5        $��Average��5"      #��[  5      $	��200��5       $��40��6   ���#fff$��Calculate average��5#      $��500,368,100,42q�5$      $��Franklin Gothic Demi Cond)�5%      $��22(�5&      ���	#FF9464365(   )   �� 5*   
   -   5         ��Name$ 
debutImage��5*      $
��Left=�6$   $	��200��6?   $	��200��6K   $��500,58,0,192q�6X   ��5+      �� 5,       �� 	UriSource$? 9C:\Users\mirja\Desktop\tswift album ranking\fearless.jpeg?�6   5.      ]� 50   
   $
��Left=�51      $	��350��52      $	��300��6   $��100,50,0,34q�6&   ���	#FFF4E6BF.+�55      &   System.Windows.Controls.DataGrid  -   5          Name$ songDataGrid��55      $	��0.5q�56      $   HorizontalScrollBarVisibility$ Disabled=�57      "   VerticalScrollBarVisibility$
 Auto=�58      	   AutoGenerateColumns	 .  $	��300��5:      ���	#FFF4E6BF
   CanUserReorderColumns
 .     CanUserResizeColumns .     CanUserSortColumns .     HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   CanUserAddRows .     CanUserDeleteRows .     CanUserResizeRows .  $��Normal"�5C         RowBackground �	#FFF4E6BF   RowHeaderWidth$ 0Q�5D       � 	Resources 5F      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�  '        7 �� 5G      8   "  6U   .�5H      ��  � �� �	#FF60412467   �� 5I       � ��
 �����68   �� 5J       � ��$ 0,0,2,0q�6<   �� 5K       � ��$ 14(�65   �� 5L       � ��
 �����67   �� 5M       � ��$ Stretch=�6@   �� 5N       � ��$
 Left=�6G   �� 5O       � ��$ 30��63   �� 5P       � ��$
 Bold"�67   �� 5Q       � ��$ 10,0,0,0q�64   5R      5S         Columns 5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$	 220 5X         
IsReadOnly .    Header$ 
Song Title��5Y         
FontWeight$
 Bold"�5Z      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5Y   -   �� *	SongTitle+5Z        5[      $ 82 6)   $ Ranking��64    6E   �� *	Ranking+5^      5_      �� 5a   
   -   5          ��Name$  AverageDisplay��5b      $��Album Average: ��6%   $
��Left=�5c      $��40��5d      $	��245��6   $��484,273,0,0q�6%   ! �� TextWrapping$
! Wrap=�5e      $	��Top=�5f      $
��Bold"�5h      $��18(�6   
�������" �� TextAlignment$" Center=�5i      ��5g      Z� ��6#   Z� 5i      5j      5k      