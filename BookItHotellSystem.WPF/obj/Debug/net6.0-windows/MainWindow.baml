   M S B A M L   `   `   `  ????Q  MBookItHotellSystem.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:BookItHotellSystem.WPFBookItHotellSystem.WPF  5   	   S.clr-namespace:BookItHotellSystem.WPF.ViewModel BookItHotellSystem.WPF.ViewModel  5   	   '    !BookItHotellSystem.WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:BookItHotellSystem.WPF     5   	   D	viewModel.clr-namespace:BookItHotellSystem.WPF.ViewModel     5   	     ? WindowStartupLocation$  CenterScreen=?5	   	    ? Title$ 
MainWindow??5
   	   $	??700??5   	   $
??1200??6   
??????  ? AllowsTransparency$
 True??5   	    ? WindowStyle$
 None=?5   	   $??14(?5   	    ? DataContext 5      4  .BookItHotellSystem.WPF.ViewModel.MainViewModel  5   
   .??5      ?? ???	#FF082553 ?? CornerRadius$ 20??5      ._?5   
   ?  ? RowDefinitions 5      ?? 5      $??75 ?5      ?? 5      $??* ?5      ?? 5      $??55 ?5      .+?5       ?? $??0??6   $??Book It Hotelsystem??5!      $??30(?5"      $??Medium"?5#      $
??Left=?5$      $??	30,20,0,0q?5%      
???????5&      ? 5'      $??1??6    ? ColumnDefinitions 5(      ?? 5)      $	??200 ?6'   ?? 5*      $??* ?6'   .+?5-      ?? $??0??6   $??1??5.      $??0,40,0,0q?5/      .+?50      	? $??Bookings??6"   $??50??51   !   
???????$??20(?53   !      
MenuButton#??[  54   !    d? 	IsChecked$
 TrueY?55   !   ??56   !   ?? *BookingListViewCommand+	? 58      $??Guests??6"   $??50??59   !   
???????$??20(?5;   !   #??[  5<   !   ??5=   !   ?? *GuestListViewCommand+	? 5>      $??Rooms??6"   $??50??5?   !   
???????$??20(?5A   !   #??[  5B   !   ??5C   !   ?? *RoomListViewCommand+5D      ?? 5E      $??1??6!   $??1??5F   !   $??10q?5G   !   ??5H   !   ?? *CurrentView+5J      ?? 5K      $??2??6   	 ?? Orientation$	 
Horizontal=?5L      .+?5M      ?? $??You are logged in as: ??5N      $
??Left=?5O      
???????5P      ?? 5R      $
??Tina??5S      
???????5T      5V      5W      5X      5Y      