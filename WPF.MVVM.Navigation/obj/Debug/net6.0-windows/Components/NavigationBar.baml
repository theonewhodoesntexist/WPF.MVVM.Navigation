   M S B A M L   `   `   `  ����N  JWPF.MVVM.Navigation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WPF.MVVM.Navigation.ComponentsWPF.MVVM.Navigation.Components  5      2    ,WPF.MVVM.Navigation.Components.NavigationBar   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:WPF.MVVM.Navigation.Components     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      
���\\��  � 	Resources  5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value    BooleanToVisibilityConverter��%  '��       &	  �    �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 0q�60   �� 5       � ��
 �����6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� #��z��6,   $��	Underline{�6M   5       5"      5#      5%      �� 5&   
   6'   5'      .��5(      � $��20,10q�6    � ColumnDefinitions 5)   
   �� 5*      $��* �6   �� 5+      $
��auto �6   �� 5,      $
��auto �6   �� 5-      $
��auto �6   �� 5.      $
��auto �6   �� 5/      $
��auto �6   .+�52   
   �� $��0��53      $��14(�54      
�������$��Navigation Demo��56      �� 58   
   $��1��59      $��10,0,0,0q�5:      $
��Home��5<      ��5;      �� *NavigateHomeCommand+5<      �� 5=   
   $��2��5>      $��10,0,0,0q�5?      $��Account��5A      ��5@      �� *NavigateAccountCommand+y�5B      �� *
IsLoggedIn+	 �� 	Converter#	 [  �� 5C   
   $��3��5D      $��10,0,0,0q�5E      $��People��5G      ��5F      �� *NavigatePeopleListingCommand+y�5H      �� *
IsLoggedIn+#	 [  �� 5I   
   $��4��5J      $��10,0,0,0q�5K      $��Login��5M      ��5L      �� *NavigateLoginCommand+5M      �� 5N   
   $��5��5O      $��10,0,0,0q�5P      $��Logout��5R      ��5Q      �� *LogoutCommand+y�5S      �� *
IsLoggedIn+#	 [  5T      5U      