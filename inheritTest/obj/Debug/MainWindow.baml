   M S B A M L   `   `   `  ����F  BinheritTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:inheritTestinheritTest  5   	       inheritTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:inheritTest     5   	     � Title$  Mobiler��5   	   $��851.38��6   $��960.123��6+   $��Right=�6;   .��5	      � $��0,0,0,-4q�6   $
��Left=�6   $	��950��68    J� RenderTransformOrigin$ 
0.505,0.49&�6D   .+�5   
   �� -   5         ��Name$ 	newMobile��5      $��Add new mobile��6$   $
��Left=�6=   $��63��6X   $��	10,10,0,0q�6d   $	��Top=�6w   $	��129��6�   6�   �� 5   
   -   5         ��Name$ firstDataTextBox��5      $
��Left=�6,   $��36��6G   $��0,78,0,0q�6S    �� TextWrapping$
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��507��6�   �� 5   
   -   5        $ readDBbutton��5      $��Read from DB��6'   $
��Left=�6>   $��63��6Y   $��
178,10,0,0q�6e   $	��Top=�6y   $	��129��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $	��402��6@   $��
24,119,0,0q�6M   $	��Top=�6a   $	��582��6y      Columns 5      5      �� 5   
   -   5        $ clearGridButton��5      $��Clear_tempButton��6*   $
��Left=�6E   $��63��6`   $��
353,10,0,0q�6l   $	��Top=�6�   $	��129��6�   6�   �� 5   
   $��
Search by:��6   $
��Left=�6%   $��41��6@   $��
713,73,0,0q�6L   $	��Top=�6`   $	��112��6x   $��20(�6�   $
��Bold"�6�   �� 5   
   $��	Producent��6   $
��Left=�6$   $��649,165,0,0q�6?   $	��Top=�6T   �� 5   
   $��Model��6   $
��Left=�6    $��649,191,0,0q�6;   $	��Top=�6P   �� 5   
   $
��IMEI��6   $
��Left=�6   $��649,217,0,0q�6:   $	��Top=�6O   �� 5    
   $��	Komentarz��6   $
��Left=�6$   $��649,243,0,0q�6?   $	��Top=�6T   �� 5!   
   $��
Wlasciciel��6   $
��Left=�6%   $��649,269,0,0q�6@   $	��Top=�6U   �� 5"   
   $��
Nr faktury��6   $
��Left=�6%   $��649,295,0,0q�6@   $	��Top=�6U   �� 5#   
   -   5        $��ProdSearchTB��5#      $
��Left=�6(   $��26��6C   $��727,165,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5$   
   -   5        $��ModelSearchTB��5$      $
��Left=�6)   $��26��6D   $��727,191,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5%   
   -   5        $��ImeiSearchTB��5%      $
��Left=�6(   $��26��6C   $��727,217,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5&   
   -	   5        $��CommentSearchTB��5&      $
��Left=�6+   $��26��6F   $��727,243,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   �� 5'   
   -
   5        $��OwnerSearchTB��5'      $
��Left=�6)   $��26��6D   $��727,269,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   �� 5(   
   -   5        $��InvoiceSearchTB��5(      $
��Left=�6+   $��26��6F   $��727,295,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��120��6�   5*      5+      