   M S B A M L   `   `   `  ����E  AKniha_jizd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Kniha_jizd.ViewKniha_jizd.View  5   	       Kniha_jizd.View.Prehled   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Kniha_jizd.View     5   	     � Title$  Prehled��5   	   $��464.754��6   $	��800��6*   .��5	      � .+�5
   
   �� -   5        $��Reload��5
      $
��Left=�6"   $��
707,10,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DatovyGrid��5         
IsReadOnly . $
��Left=�69   $	��357��6T   $��	10,62,0,0q�6a   $	��Top=�6t   $	��770��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Číslo��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *identifikator+6W     5      $  Odkud��6%   $ * 6O    65   �� *odkud+6O     5      $
  Kam��6%   $ * 6K    63   �� *kam+6K     5      $  Zaměření��6%   $ * 6P    68   �� *typ+6P     5      $  Datum��6%   $ * 6O    65   �� *datum+6O   5      �� 5   
   $��Přehled jízd��6   $��Center=�6'   $��0q�6D   $	��Top=�6O   $��36(�6g   5      5      