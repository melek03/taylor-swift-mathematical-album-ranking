   M S B A M L   `   `   `  ����O  Ktswift album ranking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:tswift_album_rankingtswift_album_ranking  5          tswift_album_ranking.Red   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:tswift_album_ranking     5        N� Title$	  Red��5	      .��5      � ��5   
   �� 5       �� ImageSource$ 
/redbg.png��6   .+�5   
   A� -   5         A�Name$
 Back��5      $��0��5      $��15��6   $��15��6&   $��Right=�5      $	��Top=�6)   $��
0,10,770,0q�5       � ToolTip$
 Back��6!   ���	#FFA871525      �� 5   
   -   5        $
��Save��5         RoundButtonTemplate#��[  5      $	��200��5      $��40��6   ���#fff$��Save ranking��5      $��500,320,100,90q�5       $��Franklin Gothic Demi Cond)�5!      $��22(�5"      ���	#FFA871525$   &   �� 5&   
   -   5        $��Average��5*      #��[  5'      $	��200��5(      $��40��6   ���#fff$��Calculate average��5+      $��500,368,100,42q�5,      $��Franklin Gothic Demi Cond)�5-      $��22(�5.      ���	#FF4A000050   )   �� 52   
   -   5         ��Name$ 
debutImage��52      $
��Left=�6$   $	��200��6?   $	��200��6K   $��500,58,0,192q�6X   ��53      �� 54       �� 	UriSource$: 4C:\Users\mirja\Desktop\tswift album ranking\red.jpeg?�6   56      ]� 58   
   $
��Left=�59      $	��350��5:      $	��300��6   $��100,50,0,34q�6&   ���	#FFB99284.+�5=      &   System.Windows.Controls.DataGrid  -   5          Name$ songDataGrid��5=      $	��0.5q�5>      $   HorizontalScrollBarVisibility$ Disabled=�5?      "   VerticalScrollBarVisibility$
 Auto=�5@      	   AutoGenerateColumns	 .  $	��300��5B      ���	#FFB99284
   CanUserReorderColumns
 .     CanUserResizeColumns .     CanUserSortColumns .     HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   CanUserAddRows .     CanUserDeleteRows .     CanUserResizeRows .  $��Normal"�5K         RowBackground �	#FFB99284   RowHeaderWidth$ 0Q�5L       � 	Resources 5N      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%�  '        7 �� 5O      8   "  6U   .�5P      ��  � �� �	#FF4A000067   �� 5Q       � ��
 �����68   �� 5R       � ��$ 0,0,2,0q�6<   �� 5S       � ��$ 14(�65   �� 5T       � ��
 �����67   �� 5U       � ��$ Stretch=�6@   �� 5V       � ��$
 Left=�6G   �� 5W       � ��$ 30��63   �� 5X       � ��$
 Bold"�67   �� 5Y       � ��$ 10,0,0,0q�64   5Z      5[         Columns 5]      0  *System.Windows.Controls.DataGridTextColumn  5^      ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$	 220 5`         
IsReadOnly .    Header$ 
Song Title��5a         
FontWeight$
 Bold"�5b      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5a   -   �� *	SongTitle+5b        5c      $ 82 6)   $ Ranking��64    6E   �� *	Ranking+5f      5g      �� 5i   
   -   5          ��Name$  AverageDisplay��5j      $��Album Average: ��6%   $
��Left=�5k      $��40��5l      $	��245��6   $��484,273,0,0q�6%   ! �� TextWrapping$
! Wrap=�5m      $	��Top=�5n      $
��Bold"�5p      $��18(�6   
�������" �� TextAlignment$" Center=�5q      ��5o      Z� ��6#   Z� 5q      5s      5t      