   M S B A M L   `   `   `  ????C  ?Clean UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Clean_UIClean_UI  5   	   A%clr-namespace:Clean_UI.MVVM.ViewModelClean_UI.MVVM.ViewModel  5   	       Clean_UI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Clean_UI     5   	   ;	viewModel%clr-namespace:Clean_UI.MVVM.ViewModel     5   	   -   5        $	??720??5	   	   $
??1000??6     ? WindowStyle$
  None=?5
   	    ? 
ResizeMode$ NoResize=?5   	   
??????  ? AllowsTransparency .  ? DataContext 5      +  %Clean_UI.MVVM.ViewModel.MainViewModel  5   
   .??5      ?? ???#272537 ?? CornerRadius$ 20??5      ._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5       ? RowDefinitions 5      ?? 5      $??75 ?6    ?? 5      .+?5!      ?? $??Black Tulip??6   $??Center=?5"      $
??Left=?5#      
???????$??22(?5%      $??20,0,0,0q?5&      $"??/Fonts/#Cleanvertising Black)?5'      ?? 5)      $??75??6   $??75??5*      $??/Images/Tulp Wit.png??5+      $??Right=?5,      $??Center=?5-      5.      ?? 50      $??1??6   .+?52      	? $
??Home??6   $??50??53      
???????$??14(?55         MenuButtonTheme#??[  56       d? 	IsChecked$
 TrueY?57      ??58      ?? *HomeViewCommand+	? 5:      $??	Producten??6   $??50??5;      
???????$??14(?5=      #??[  5>      ??5?      ?? *ProductenViewCommand+	? 5A      $??Klanten??6   $??50??5B      
???????$??14(?5D      #??[  5E      ??5F      ?? *KlantenViewCommand+	? 5H      $??Bestellingen??6   $??50??5I      
???????$??14(?5K      #??[  5L      ??5M      ?? *BestellingenViewCommand+	? 5O      $??Items??6   $??50??5P      
???????$??14(?5R      #??[  5S      ??5T      ?? *DiscoveryViewCommand+5W      ?? 5Y      $	??250??6   $??40??5Z      $??Center=?5[      $
??Left=?5\      $??5q?5]      $??1??5^        ModernTextbox#??[ 5_      ?? 5a      $??1??6   $??1??5b      $??10q?5c      ??5d      ?? *Currentview+5f      5j      5k      