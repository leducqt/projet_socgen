   M S B A M L   `   `   `  ����  socgen_taux    socgen_taux.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Saissie des taux��5   	   $��299.028��6"   $��636.507��63   .��5	      � $��2,0,0,-88.5q�6   $
��Left=�6    $	��629��6;   $	��360��6G   $	��Top=�6T   
������� J� RenderTransformOrigin$ 0.5,0.5&�6�    � RowDefinitions 5
   
   �� 5      $
��281* �6   �� 5      $��0* �6   �� 5      $	��88* �6   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.091Q�6"   T� 5      5      .+�5   
   �� $
��Left=�6   $��	10,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��49��6n   $	��178��6z   �� 6�   $U�ORentrez les taux spots et forwards pour les différentes maturités ci-dessous.��6�   6�   �� 5   
   $
��Left=�6   $��	10,90,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��86��6n   $��23��6y   �� 6�   $�Taux 3 mois :��6�   �� 6�   �� 6�   6�   �� 5   
   $
��Left=�6   $��23��6-   $��
101,88,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6u   $	��120��6�   ��6a   �� *R3+6�   �� 5   
   $��Construire la courbe��67   $
��Left=�6V   $��
54,195,0,0q�6q   $	��Top=�6�   $	��199��6�   $��59��6�   ��6   �� *simulationCommand+6�   �� 5   
   $
��Left=�6   $��
10,120,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��86��6o   $��23��6z   �� 6�   $�Taux ��6�   �� 6�   $�6 ��6�   �� 6�   $�mois :��6�   �� 6�   �� 6�   6�   �� 5   
   $
��Left=�6   $��
10,148,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��86��6o   $��23��6z   �� 6�   $�Taux ��6�   �� 6�   $�9��6�   �� 6�   $� mois :��6�   �� 6�   �� 6�   6�   �� 5   
   $
��Left=�6   $��23��6-   $��101,118,0,0q�69   $
 Wrap=�6N   $	��Top=�6v   $	��120��6�   ��6b   �� *R6+6�   �� 5   
   $
��Left=�6   $��23��6-   $��101,148,0,0q�69   $
 Wrap=�6N   $	��Top=�6v   $	��120��6�   ��6b   �� *R9+6�   �� 5   
   $
��Left=�6   $��
226,88,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��13��6o   $��23��6z   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5    
   $
��Left=�6   $��226,120,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��13��6p   $��23��6{   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5!   
   $
��Left=�6   $��226,148,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��13��6p   $��23��6{   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5"   
   $
��Left=�6   $��
366,90,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��86��6o   $��23��6z   �� 6�   $�Taux 3x6 mois :��6�   �� 6�   �� 6�   6�   �� 5#   
   $
��Left=�6   $��23��6-   $��
457,88,0,0q�69   $
 Wrap=�6M   $	��Top=�6v   $	��120��6�   ��6a   �� *R6F+6�   �� 5$   
   $
��Left=�6   $��366,120,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��86��6p   $��23��6{   �� 6�   $�Taux ��6�   �� 6�   $
�3x9 ��6�   �� 6�   $�mois :��6�   �� 6�   �� 6�   6�   �� 5%   
   $
��Left=�6   $��366,148,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��91��6p   $��23��6{   �� 6�   $�Taux ��6�   �� 6�   $
�3x12��6�   �� 6�   $� mois :��6�   �� 6�   �� 6�   6�   �� 5&   
   $
��Left=�6   $��23��6-   $��457,118,0,0q�69   $
 Wrap=�6N   $	��Top=�6w   $	��120��6�   ��6b   �� *R9F+6�   �� 5'   
   $
��Left=�6   $��23��6-   $��457,148,0,0q�69   $
 Wrap=�6N   $	��Top=�6x   $	��120��6�   ��6b   �� *R12F+6�   �� 5(   
   $
��Left=�6   $��
582,88,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��13��6o   $��23��6z   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5)   
   $
��Left=�6   $��582,120,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��13��6p   $��23��6{   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5*   
   $
��Left=�6   $��582,148,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��13��6p   $��23��6{   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5+   
   $
��Left=�6   $��
366,62,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��86��6o   $��23��6z   �� 6�   $�Taux 3 mois :��6�   �� 6�   �� 6�   6�   �� 5,   
   $
��Left=�6   $��23��6-   $��
457,60,0,0q�69   $
 Wrap=�6M   $	��Top=�6v   $	��120��6�   ��6a   �� *R3F+6�   �� 5-   
   $
��Left=�6   $��
582,60,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��13��6o   $��23��6z   �� 6�   $�%��6�   �� 6�   �� 6�   6�   �� 5.   
   $��Construire la courbe��6>   $
��Left=�6]   $��378,195,0,0q�6x   $	��Top=�6�   $	��199��6�   $��59��6�   ��6   �� *simulationForwardCommand+6�   5/      50      