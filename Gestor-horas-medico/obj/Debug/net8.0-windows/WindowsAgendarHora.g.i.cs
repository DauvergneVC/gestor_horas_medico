// Updated by XamlIntelliSenseFileGenerator 31/05/2024 17:03:03
#pragma checksum "..\..\..\WindowsAgendarHora.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3D5A3C10B32F0204D17C1187ABDBDDBC02585A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gestor_horas_medico;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Gestor_horas_medico
{


    /// <summary>
    /// WindowsAgendarHora
    /// </summary>
    public partial class WindowsAgendarHora : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\..\WindowsAgendarHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRutPaciente;

#line default
#line hidden


#line 20 "..\..\..\WindowsAgendarHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboNombresMedicos;

#line default
#line hidden


#line 21 "..\..\..\WindowsAgendarHora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEspecialidadMedico;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Gestor_horas_medico;component/windowsagendarhora.xaml", System.UriKind.Relative);

#line 1 "..\..\..\WindowsAgendarHora.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.txtRutPaciente = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.cboNombresMedicos = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 3:
                    this.cboEspecialidadMedico = ((System.Windows.Controls.ComboBox)(target));

#line 21 "..\..\..\WindowsAgendarHora.xaml"
                    this.cboEspecialidadMedico.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboEspecialidadMedico_SelectionChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtHora;
        internal System.Windows.Controls.TextBox txtMinuto;
        internal System.Windows.Controls.DatePicker dtFecha;
        internal System.Windows.Controls.Button btnAgregarConsulta;
    }
}

