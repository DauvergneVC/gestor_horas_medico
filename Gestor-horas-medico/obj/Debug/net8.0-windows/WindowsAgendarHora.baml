   M S B A M L   `   `   `  ����N  JGestor_horas_medico, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Gestor_horas_medicoGestor_horas_medico  5   	   ,    &Gestor_horas_medico.WindowsAgendarHora   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Gestor_horas_medico     5   	     � Title$  WindowsAgendarHora��5   	   $	��356��6$   $	��794��61   .��5	      � .+�5
   
   �� $#��/Img/PsiHorasAgendarHoras.png��6   $
��Fill=�67   $	��800��6F   $��Center=�6R   $��98��6o   $	��Top=�6{   �� 5   
   $��Rut del paciente��6   $
��Left=�6+   $��
80,149,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Seleccione especialidad��6   $
��Left=�62   $��
80,192,0,0q�6M   $	��Top=�6a   �� 5   
   $��Nombre del medico��6   $
��Left=�6,   $��445,153,0,0q�6G   $	��Top=�6\   �� 5   
   $��Fecha de la consulta��6   $
��Left=�6/   $��
80,240,0,0q�6J   $	��Top=�6^   �� 5   
   -   5         ��Name$ txtRutPaciente��5      $
��Left=�6*   $��220,153,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��159��6�   $��22��6�   �� 5   
   -   5         ��Name$ cboNombresMedicos��5      $
��Left=�6.   $��24��6I   $��566,155,0,0q�6U   $	��Top=�6j   $	��158��6�   �� 5   
   -   5        $ cboEspecialidadMedico��5      $
��Left=�62   $��221,194,0,0q�6M   $	��Top=�6b   $	��158��6z   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtFecha��5      $
��Left=�6&   $��221,241,0,0q�6A   $	��Top=�6V   $	��158��6n   �� 5   
   -   5         ��Name$ btnAgregarConsulta��5      $��Agregar consulta��6-   $
��Left=�6H   $��548,225,0,0q�6c   $	��Top=�6x   $��40��6�   $	��176��6�   ���	#FF014CAE
�������6�   5      5      