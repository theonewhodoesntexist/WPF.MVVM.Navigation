   M S B A M L   `   `   `  ����N  JWPF.MVVM.Navigation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF.MVVM.Navigation.ViewsWPF.MVVM.Navigation.Views  5      )    #WPF.MVVM.Navigation.Views.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:WPF.MVVM.Navigation.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      � $��50,25q�5   	   $��Center=�5   	   $��Center=�5   	     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5      $��0,0,0,20q�5      $��Center=�5      $��28(�5      $��LOGIN��5      � 5   
   $��1��6    � IsSharedSizeScope$
 True��6     5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5"      � $��0��6    � ColumnDefinitions 5#      �� 5$      $
��auto �6'    z� SharedSizeGroup$ Label��64   �� 5%      $
��auto �6'   .+�5(      �� $��0��6   $��Username��6,   �� 5)      $��1��5*      $	��100��5+      $��20,0,0,0q�5,      ��5-      �� *
Username+5.      � 50      $��1��6   $��0,5,0,0q�6     51      �� 52      $
��auto �6'   $ Label��64   �� 53      $
��auto �6'   .+�56      �� $��0��6   $��Password��6,   �� 57      $��1��58      $	��100��59      $��20,0,0,0q�5:      ��5;      �� *
Password+5<      5=      �� 5?   
   $��2��5@      $	��150��5A      $��30��5B      $��0,20,0,0q�5C      $��LOGIN��5E      ��5D      �� *LoginCommand+5E      5F      5G      