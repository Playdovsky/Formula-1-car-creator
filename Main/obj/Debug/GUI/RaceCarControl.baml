   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5          Main.RaceCarControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Main     5      
�������.��5
      � .+�5   
   �� -   5          ��Name$  TextBoxBrakes��5      $
��Left=�6)   $��24��6D   $��
730,92,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $��40��6�    �� 	MaxLength$ 4��6�   �� 5   
   -   5        $  TextBoxMaxSpeed��5      $
��Left=�6+   $��26��6F   $��
730,32,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $��40��6�   $ 3��6�   �� 5   
   -   5        $  TextBoxAcceleration��5      $
��Left=�6/   $��24��6J   $��
730,63,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $��40��6�   $ 3��6�   �� 5   
   -   5         ��Name$ CheckBoxFIA��5      $��Approved by FIA��6(   $
��Left=�6B   $��23��6]   $��2,98,0,0q�6i   $	��Top=�6{   $	��120��6�   �� 5   
   -   5         ��Name$ ComboBoxTyres��5      $
��Left=�6*   $��25��6E   $��
68,366,0,0q�6Q   $	��Top=�6e   $	��120��6}   .@�5      �� $��Hard (white)��6   �� 5      $��Medium (yellow)��6   �� 5      $��
Soft (red)��6   �� 5      $��Intermediate (green)��6   �� 5      $��
Wet (blue)��6   5      �� 5   
   -   5        $  TextBoxNumber��5      $
��Left=�6)   $��24��6D   $��
102,33,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $��40��6�    J� RenderTransformOrigin$ 0.502,0.578&�6�   $ 5��6�   �� 5   
   -   5        $  TextBoxType��5      $
��Left=�6'   $��24��6B   $��
102,68,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $��15��6�   $ 1��6�   �� 5   
   -   5        $ ComboBoxEngine��5      $
��Left=�6+   $��26��6F   $��554,350,0,0q�6R   $	��Top=�6g   $	��200��6   .@�5      �� $5��/Mercedes-Benz V6 hybrid turbocharger, 850+160hp��6   6W   �� 5      $0��*Red Bull V6 hybrid turbocharger, 880+110hp��6   6R   �� 5      $/��)Ferrari V6 hybrid turbocharger, 850+160hp��6   6Q   �� 5      $/��)Renault V6 hybrid turbocharger, 825+150hp��6   6Q   �� 5      $/��)Renault V6 hybrid turbocharger, 800+100hp��6   6Q   �� 5      $4��.Aston Martin V6 hybrid turbocharger, 820+110hp��6   6V   �� 5      $2��,AlphaTauri V6 hybrid turbocharger, 810+100hp��6   6T   �� 5       $1��+Alfa Romeo V6 hybrid turbocharger, 760+70hp��6   6S   �� 5!      $-��'Alpine V6 hybrid turbocharger, 750+80hp��6   6O   �� 5"      $/��)Williams V6 hybrid turbocharger, 790+95hp��6   6Q   �� 5#      $+��%Haas V6 hybrid turbocharger, 780+95hp��6   6M   �� 5$      $-��'Honda V6 hybrid turbocharger, 800+130hp��6   6O   �� 5%      $-��'Honda V6 hybrid turbocharger, 750+150hp��6   6O   �� 5&      $,��&Honda V6 hybrid turbocharger, 700+50hp��6   6N   5'      �� 5(   
   -	   5        $ ComboBoxAerodynamics��5(      $
��Left=�61   $��25��6L   $��
198,95,0,0q�6X   $	��Top=�6l   $	��220��6�   $ 
0.378,0.58&�6�   .@�5)      �� $:��4Wings, spoiler, diffuser, lightweight compounds, DRS��6   �� 5*      $5��/Wings, spoiler, diffuser, lightweight compounds��6   �� 5+      $��Wings, spoiler, diffuser��6   �� 5,      $��Wings, spoiler��6   5-      �� 5.   
   -
   5         ��Name$ ButtonBuild��5.      $��BUILD��6&   $��Center=�66   $��40��6S   $��	0,378,0,0q�6_   $	��Top=�6r   $��80��6�   $
��Bold"�6�   �� 5/   
   -   5         ��Name$ LabelRaceCarControlHeader��5/      $��F1 CAR - FOR RACE��63   $
��Left=�6O   $��2,2,0,0q�6j   $	��Top=�6{   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 50   
   $��Unique number��6   $��2,30,678,380q�6(   �� 51   
   $��Formula type��6   $��2,65,678,345q�6'   �� 52   
   $��F��6   $
��Left=�6   $��	86,65,0,0q�67   $	��Top=�6J   �� 53   
   $��40,140,40,130q�6   $��/GUI/f3_side.png��6'   �� 54   
   	 �� X1$ 50��6   		 �� Y1$	 50��6   	
 �� X2$	
 -50��6   	 �� Y2$	 200��6(   
���  ��$��1��6>   $��140,240,226,0q�6R   �� 55   
   $ 50��6   $	 50��6   $	
 200��6   $	 200��6(   
���  ��$��1��6>   $��464,158,-46,90q�6R   �� 56   
   $ 50��6   $
	 -100��6   $

 -120��6!   $ 50��6+   
���  ��$��1��6@   $��208,220,400,-113q�6T   $ 
0.687,0.43&�6n   �� 57   
   $	 590��6   $		 100��6   $

 1000��6!   $	 200��6+   
���  ��$��1��6A   $��-232,20,56,126q�6U   �� 58   
   -   5        $ LabelMaxSpeed��58      $��Max speed (km/h)��6'   $��594,30,50,380q�6B   �� 59   
   -   5        $ LabelAcceleration��59      $��Acceleration (0-100km)��6+   $��594,60,50,350q�6L   �� 5:   
   -   5        $ LabelBrakes��5:      $��Brakes balance (in %)��6%   $��594,89,50,321q�6E   5;      5<      