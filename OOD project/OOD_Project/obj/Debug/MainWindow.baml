   M S B A M L   `   `   `  ����F  BOOD_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OOD_ProjectOOD_Project  5   	       OOD_Project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OOD_Project     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
�������$��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5      
���   �   MaterialDesignFont#���   5      .��5      �� .@�5   
   �� $��Add Workouts��6   .��5      � $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'    � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5       $
��0.5* �6$   �� 5!      $
��0.5* �6$   �� 5"      $
��0.5* �6$   �� 5#      $��* �6$   �� 5$      $��* �6$   �� 5%      $��* �6$   .+�5(      �� -   5         ��Name$ bodyPartComboBox��5(   8   $��0��6   $��0��6(   $��Center=�6R   $��Center=�6p    �� DisplayMemberPath$
 Name��5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Body Parts��6,      FloatingScale$	 1.5Q�6X   	   FloatingOffset$	 0, -22&�6�   $	��150��5*       & "MaterialDesignFloatingHintComboBox#��[ 6\   ��6"   �� *#!LongListToTestComboVirtualization+6\   �� 5,      -   5        $ exerciseComboBox��5,   8   $��1��6   $��0��6(   $
 Name��6R   $��Center=�6k   $��Center=�6�   $	��150��6�   $ 	Exercises��5-      $	 1.5Q�6>   $	 0, -22&�6l   #��[ 5.   M   ��6   �� *#!LongListToTestComboVirtualization+5/      �� 52      -   5        $ repsComboBox��52   :   $��0��6   $��1��6)   $��Center=�6P   $��Center=�6n   $	��150��6�   $
 Reps��53      $	 1.5Q�6:   $	 0, -22&�6h   #��[ 54   M   ��6   �� *#!LongListToTestComboVirtualization+6M   �� 56      -   5        $ setsComboBox��56   :   $��1��6   $��1��6)   $��Center=�6P   $��Center=�6n   $	��150��6�   $
 Sets��57      $	 1.5Q�6:   $	 0, -22&�6h   #��[ 58   M   ��6   �� *#!LongListToTestComboVirtualization+6M   �� 5:      -   5        
 ��Name$
 checkBoxTUT��5:   8   $��1��6   $��2��6+   $��Time Under Tension��6M   $
��Left=�6j   $��Center=�6�   �� 5;      -   5        $
 checkBoxPause��5;   8   $��1��6   $��3��6+   $��Pause��6O   $
��Left=�6_   $��Center=�6{   �� 5<      -   5        $
 checkBox1_5Reps��5<   9   $��1��6   $��4��6+   $��	1.5x Reps��6R   $
��Left=�6f   $��Center=�6�   �� 5>      -	   5         ��Name$ deleteButton��5>   7   $��5��6   $��1��6&   $��Delete��6M   $��Right=�6^   $��Center=�6{   $��76��6�   6�   �� 5?      -
   5        $ 	addButton��5?   6   $��5��6   $��1��6&   $	��Add��6I   $
��Left=�6W   $��Center=�6s   $��76��6�   6�   �� 5A      -   5        $ profileComboBox��5A   8   $��0��6   $��2��6(   $
 Name��6Q   $��Center=�6j   $��Center=�6�   $	��150��6�   $ Profiles��5B      $	 1.5Q�6>   $	 0, -22&�6l   #��[ 5C   M   ��6   �� *#!LongListToTestComboVirtualization+6M   &   System.Windows.Controls.DataGrid  5F      -   5          Name$ 
workoutBox��5G      $��2��5F      $��2��6(   $��2��68   $��5��6L   5G      �� 5I      -   5        $ 
saveButton��5I   6   $��7��6   $��3��6&   $
��Save��6J   $��Center=�6Y   $��Center=�6w   $	��125��6�   6�   �� 5K      $��2��6   $��0��6*   $��6��6:   $��21,10,21,13q�6K   .+�5L      �� -   5         ��Name$ ExerciseImage��5L      $��UniformToFill=�64   5M      5N      5O      �� 5Q   
   -   5        $��Workout History��5Q      .��5S      � $��10q�6   .+�5T        -   5        $ 
AllWorkout��5T      5U      5V      5W      5X      