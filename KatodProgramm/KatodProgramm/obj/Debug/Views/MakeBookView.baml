   M S B A M L   `   `   `  ����H  DKatodProgramm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KatodProgramm.ViewsKatodProgramm.Views  5      A%clr-namespace:KatodProgramm.ViewModelKatodProgramm.ViewModel  6>   &     KatodProgramm.Views.MakeBookView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:KatodProgramm.Views     5      ;	viewmodel%clr-namespace:KatodProgramm.ViewModel     6>   .��5	      �   � IsSharedSizeScope  .  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $!��Добавить книгу��6    
  Header#��[  6*   $��0��6J   � 5   
   $��1��6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��
Автор��6   $��0��6%   �� 5      $��1��6   $��0 5 0 0q�6_   ��6#   �� *
Автор+ �� UpdateSourceTrigger$ PropertyChanged=�6_   5      � 5   
   $��2��6    5      �� 5      $
��auto �6    �� 5       $
��auto �6    .+�5#      �� $!��Название книги��6   $��0��6.   �� 5$      $��1��6   $��0��6#   $��0 5 0 0q�6w   ��63   �� *НазваниеКниги+$ PropertyChanged=�6w   5%      � 5'   
   $��3��6    5(      �� 5)      $
��auto �6    �� 5*      $
��auto �6    .+�5-      �� $��Тематика��6   $��0��6(   $��1��65   �� 5.      $��2��6   $��1��6#   $��0 5 0 0q�6r   ��63   �� *Тематика+$ PropertyChanged=�6r   5/      � 51   
   $��4��6    52      �� 53      $
��auto �6    �� 54      $
��auto �6    .+�57      �� $��Год издания��6   $��0��6+   $��1��68   �� 58      $��2��6   $��1��6#   $��0 5 0 0q�6t   ��63   �� *ГодИздания+$ PropertyChanged=�6t   59      �� 5;   
   $��5��6   $��0 50 0 0q�6"    �� Orientation$ 
Horizontal=�64   .+�5<      �� $��Добавить��6   ��6(   �� *
AddCommand+�� 5=      $��5 0 0 0q�6   $��
Назад��6&   ��66   �� *CancelCommand+5>      5?      5@      