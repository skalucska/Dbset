   M S B A M L   `   `   `  ����M  IGestionEmploye.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GestionEmploye.WPFGestionEmploye.WPF  5   	   #    GestionEmploye.WPF.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:GestionEmploye.WPF     5   	     � Title$  
MainWindow��5   	   $	��529��6   $	��865��6)   .��5      � $
��auto��6   $
��auto��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   �� $��2��6   
��� E��._�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� $��/Image/employe.png��6   $	��100��64   �� 5      $��Gestion des employés��6   $��40(�68   $��Segoe UI)�6F   $��Center=�6\   $��15q�6w   5      5      �� 5   
   $��1��6   .+�5      �� $��Rafraîchir��6   
�������
���   �$��1q�6P   $��10q�6d   ��6p   �� *
ChargerCmd+�� 5        �� DisplayMemberPath$	 Nom��5"      ��5       �� *
Employes+ �� SelectedItem 5!      �� *EmployeSelectionne+ �� Mode$ TwoWay=�5"      5$      � 5&   
   $��1��6   $��1��6   y�5'      �� *PeutAfficherDetails+$ OneWay=� "  MyBooleanToVisibilityConverter �� 	Converter# [   5)      �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    .+�56      �� 	Prénom6#   �� 57      $��1��6   $��10q�6�   ��6#   �� *EmployeSelectionne.Prenom+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 59      $��2��6   Nom6,   �� 5:      $��3��6   $��10q�6}   ��6#   �� *EmployeSelectionne.Nom+$ TwoWay=�$ PropertyChanged=�6}   �� 5<      $��4��6   Date d'embauche68   (  "System.Windows.Controls.DatePicker  5=      $��5��6   $��10q�6o   	   SelectedDate	 6&   �� *$"EmployeSelectionne.DateEmbaucheWpf+$ TwoWay=�6o   �� 5?      $��6��6   Rôle6-   �� 5@      $��7��6   $	 Nom��5B      
 �� SelectedValuePath$
 Id��5C      $��10q�5D   R   ��5A      �� *Roles+$ OneWay=� �� SelectedValue 5D      �� *EmployeSelectionne.RoleId+$ TwoWay=�6R   �� 5F      $��8��6   $��Pilote de ligne��6$   $��10q�6�    d� 	IsChecked 6>   �� *%#EmployeSelectionne.EstPiloteDeLigne+$ TwoWay=�6�   �� 5H      $��9��6   $��Enregistrer��6"   
�������
���   �$��1q�6^   $��10 10 10 30q�6r   $��Bottom=�5J      ��5I      �� *" EmploySelectionne.SauvegarderCmd+5J      5K      5N      5O      